using Microsoft.WindowsAPICodePack.Taskbar;
using SoulsFormats;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace UXM
{
    public partial class FormMain : Form
    {
        private const string UPDATE_LINK = "https://www.nexusmods.com/eldenring/mods/1651?tab=files";
        private static Properties.Settings settings = Properties.Settings.Default;

        private bool closing;
        private CancellationTokenSource cts;
        private IProgress<(double value, string status)> progress;

        public FormMain()
        {
            InitializeComponent();

            closing = false;
            cts = null;
            progress = new Progress<(double value, string status)>(ReportProgress);
            formFileView = new FormFileView(this);
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            Text = $"UXM {Application.ProductVersion} Selective Unpacker";
            EnableControls(true);

            Location = settings.WindowLocation;
            if (settings.WindowSize.Width >= MinimumSize.Width && settings.WindowSize.Height >= MinimumSize.Height)
                Size = settings.WindowSize;
            if (settings.WindowMaximized)
                WindowState = FormWindowState.Maximized;

            string installPath = Util.TryGetGameInstallLocation(settings.ExePath.Replace("{0}", ""));
            if (!string.IsNullOrEmpty(installPath))
                settings.ExePath = installPath;

            txtExePath.Text = settings.ExePath;

            Octokit.GitHubClient gitHubClient = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("UXM-Selective-Unpack"));
            try
            {
                Octokit.Release release = await gitHubClient.Repository.Release.GetLatest("Nordgaren", "UXM-Selective-Unpack");
                if (Version.Parse(release.TagName) > Version.Parse(Application.ProductVersion))
                {
                    lblUpdate.Visible = false;
                    LinkLabel.Link link = new LinkLabel.Link();
                    link.LinkData = UPDATE_LINK;
                    llbUpdate.Links.Add(link);
                    llbUpdate.Visible = true;
                }
                else
                {
                    lblUpdate.Text = "App up to date";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is Octokit.ApiException || ex is ArgumentException)
            {
                lblUpdate.Text = "Update status unknown";
            }
        }

        public async Task GetTreeView()
        {
            await Dispatcher.CurrentDispatcher.Invoke(async () =>
            {
                try
                {
                    btnFileView.Enabled = false;
                    btnFileView.Text = "Loading";
                    await Task.Run(() => formFileView.PopulateTreeview(txtExePath.Text));
                    btnFileView.Text = "View Files";
                    btnFileView.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtExePath.Text = settings.ExePath;
                    return;

                }

                settings.ExePath = txtExePath.Text;

            });

        }


        private void llbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null)
            {
                txtStatus.Text = "Aborting...";
                closing = true;
                btnAbort.Enabled = false;
                cts.Cancel();
                e.Cancel = true;
            }
            else
            {
                settings.WindowMaximized = WindowState == FormWindowState.Maximized;
                if (WindowState == FormWindowState.Normal)
                {
                    settings.WindowLocation = Location;
                    settings.WindowSize = Size;
                }
                else
                {
                    settings.WindowLocation = RestoreBounds.Location;
                    settings.WindowSize = RestoreBounds.Size;
                }

                try
                {
                    Util.GetExeVersion(txtExePath.Text);
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Aborting...";
            btnAbort.Enabled = false;
            cts.Cancel();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdExe.InitialDirectory = Path.GetDirectoryName(txtExePath.Text);
            if (ofdExe.ShowDialog() == DialogResult.OK)
                txtExePath.Text = ofdExe.FileName;
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(txtExePath.Text);
            if (Directory.Exists(dir))
                Process.Start(dir);
            else
                SystemSounds.Hand.Play();
        }

        private async void btnPatch_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            cts = new CancellationTokenSource();
            string error = await Task.Run(() => ExePatcher.Patch(txtExePath.Text, progress, cts.Token));

            if (cts.Token.IsCancellationRequested)
            {
                progress.Report((0, "Patching aborted."));
            }
            else if (error != null)
            {
                progress.Report((0, "Patching failed."));
                ShowError(error);
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }

            cts.Dispose();
            cts = null;
            EnableControls(true);

            if (closing)
                Close();
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Restoring the game will delete any modified files you have installed.\n" +
                "Do you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
                return;

            EnableControls(false);
            cts = new CancellationTokenSource();
            string error = await Task.Run(() => GameRestorer.Restore(txtExePath.Text, progress, cts.Token));

            if (cts.Token.IsCancellationRequested)
            {
                progress.Report((0, "Restoration aborted."));
            }
            else if (error != null)
            {
                progress.Report((0, "Restoration failed."));
                ShowError(error);
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }

            cts.Dispose();
            cts = null;
            EnableControls(true);

            if (closing)
                Close();
        }

        private async void btnUnpack_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            cts = new CancellationTokenSource();
            string outputPath = string.IsNullOrWhiteSpace(txtOutputPath.Text) ? txtExePath.Text : txtOutputPath.Text;
            string error = await Task.Run(() => ArchiveUnpacker.Unpack(txtExePath.Text, outputPath, progress, cts.Token));

            if (cts.Token.IsCancellationRequested)
            {
                progress.Report((0, "Unpacking aborted."));
            }
            else if (error != null)
            {
                progress.Report((0, "Unpacking failed."));
                ShowError(error);
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }

            cts.Dispose();
            cts = null;
            EnableControls(true);

            if (closing)
                Close();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnableControls(bool enable)
        {
            txtExePath.Enabled = enable;
            btnBrowse.Enabled = enable;
            btnAbort.Enabled = !enable;
            btnRestore.Enabled = enable;
            btnPatch.Enabled = enable;
            btnUnpack.Enabled = enable;
        }

        private void ReportProgress((double value, string status) report)
        {
            if (report.value < 0 || report.value > 1)
                throw new ArgumentOutOfRangeException("Progress value must be between 0 and 1, inclusive.");

            int percent = (int)Math.Floor(report.value * pbrProgress.Maximum);
            pbrProgress.Value = percent;
            txtStatus.Text = report.status;
            if (TaskbarManager.IsPlatformSupported)
            {
                TaskbarManager.Instance.SetProgressValue(percent, pbrProgress.Maximum);
                if (percent == pbrProgress.Maximum && ActiveForm == this)
                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
            }
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            if (TaskbarManager.IsPlatformSupported && pbrProgress.Value == pbrProgress.Maximum)
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
            }
        }

        private void cbxSkip_CheckedChanged(object sender, EventArgs e)
        {
            ArchiveUnpacker.SetSkip(cbxSkip.Checked);
        }

        private FormFileView formFileView { get; set; }

        private void btnView_Click(object sender, EventArgs e)
        {
            Enabled = false;
            formFileView.ShowDialog();
            Enabled = true;
        }

        private async void txtExePath_TextChanged(object sender, EventArgs e)
        {
            if (!Path.IsPathRooted(txtExePath.Text))
                return;

            await Dispatcher.CurrentDispatcher.Invoke(async () =>
            {
                await GetTreeView();
            });


        }

        public void SetSkip(bool enable)
        {
            cbxSkip.Checked = enable;
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            string outputPath = string.IsNullOrWhiteSpace(txtOutputPath.Text) ? txtExePath.Text: txtOutputPath.Text;

            ofdFolder.InitialDirectory = Path.GetDirectoryName(outputPath);
            ofdFolder.ValidateNames = false;
            ofdFolder.CheckFileExists = false;
            ofdFolder.CheckPathExists = true;
            ofdFolder.FileName = "Folder Selection";
            if (ofdFolder.ShowDialog() == DialogResult.OK)
                txtOutputPath.Text = Path.GetDirectoryName(ofdFolder.FileName);
        }
    }
}
