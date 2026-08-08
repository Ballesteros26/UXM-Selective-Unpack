using SoulsFormats;
using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;

[assembly: DisableDpiAwareness]
namespace UXM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Properties.Settings settings = Properties.Settings.Default;
                if (settings.UpgradeRequired)
                {
                    settings.Upgrade();
                    settings.UpgradeRequired = false;
                    settings.Save();
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());

                settings.Save();
            } catch (Exception ex)
            {
                File.WriteAllText("crash_log.log", ex.ToString());
                throw;
            }

        }
    }
}
