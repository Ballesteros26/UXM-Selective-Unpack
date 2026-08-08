namespace UXM
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblBreak;
            System.Windows.Forms.Label lblExePath;
            System.Windows.Forms.Label lblStatus;
            System.Windows.Forms.Label lblOutputPath;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnPatch = new System.Windows.Forms.Button();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtExePath = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.ofdExe = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxSkip = new System.Windows.Forms.CheckBox();
            this.btnFileView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.ofdFolder = new System.Windows.Forms.OpenFileDialog();
            lblBreak = new System.Windows.Forms.Label();
            lblExePath = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblOutputPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBreak
            // 
            lblBreak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblBreak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblBreak.Location = new System.Drawing.Point(-27, 240);
            lblBreak.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblBreak.Name = "lblBreak";
            lblBreak.Size = new System.Drawing.Size(1320, 4);
            lblBreak.TabIndex = 31;
            // 
            // lblExePath
            // 
            lblExePath.AutoSize = true;
            lblExePath.Location = new System.Drawing.Point(24, 18);
            lblExePath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblExePath.Name = "lblExePath";
            lblExePath.Size = new System.Drawing.Size(169, 25);
            lblExePath.TabIndex = 30;
            lblExePath.Text = "Executable Path";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(24, 246);
            lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(73, 25);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Status";
            // 
            // btnPatch
            // 
            this.btnPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatch.Location = new System.Drawing.Point(773, 176);
            this.btnPatch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(149, 44);
            this.btnPatch.TabIndex = 27;
            this.btnPatch.Text = "Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // btnUnpack
            // 
            this.btnUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpack.Location = new System.Drawing.Point(610, 176);
            this.btnUnpack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(149, 44);
            this.btnUnpack.TabIndex = 26;
            this.btnUnpack.Text = "Unpack";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(936, 176);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(149, 44);
            this.btnRestore.TabIndex = 28;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Enabled = false;
            this.btnAbort.Location = new System.Drawing.Point(1097, 176);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(149, 44);
            this.btnAbort.TabIndex = 29;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExplore.Location = new System.Drawing.Point(1097, 44);
            this.btnExplore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(149, 44);
            this.btnExplore.TabIndex = 25;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(936, 44);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(149, 44);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtExePath
            // 
            this.txtExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExePath.Location = new System.Drawing.Point(24, 48);
            this.txtExePath.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtExePath.Name = "txtExePath";
            this.txtExePath.Size = new System.Drawing.Size(894, 31);
            this.txtExePath.TabIndex = 23;
            this.txtExePath.Text = "{0}\\steamapps\\common\\EldenRing\\Game\\eldenring.exe";
            this.txtExePath.TextChanged += new System.EventHandler(this.txtExePath_TextChanged);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdate.Location = new System.Drawing.Point(341, 388);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(907, 25);
            this.lblUpdate.TabIndex = 35;
            this.lblUpdate.Text = "Checking for update...";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbUpdate.Location = new System.Drawing.Point(346, 388);
            this.llbUpdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(900, 25);
            this.llbUpdate.TabIndex = 36;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(24, 277);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(1220, 31);
            this.txtStatus.TabIndex = 33;
            // 
            // pbrProgress
            // 
            this.pbrProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrProgress.Location = new System.Drawing.Point(24, 327);
            this.pbrProgress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pbrProgress.Maximum = 1000;
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(1224, 44);
            this.pbrProgress.TabIndex = 34;
            // 
            // ofdExe
            // 
            this.ofdExe.FileName = "eldenring.exe";
            this.ofdExe.Filter = "FromSoft Game Executable|*.exe";
            this.ofdExe.Title = "Select FromSoft Game executable...";
            // 
            // cbxSkip
            // 
            this.cbxSkip.AutoSize = true;
            this.cbxSkip.Location = new System.Drawing.Point(183, 184);
            this.cbxSkip.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSkip.Name = "cbxSkip";
            this.cbxSkip.Size = new System.Drawing.Size(224, 29);
            this.cbxSkip.TabIndex = 37;
            this.cbxSkip.Text = "Use Selected Files";
            this.cbxSkip.UseVisualStyleBackColor = true;
            this.cbxSkip.CheckedChanged += new System.EventHandler(this.cbxSkip_CheckedChanged);
            // 
            // btnFileView
            // 
            this.btnFileView.Location = new System.Drawing.Point(24, 176);
            this.btnFileView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFileView.Name = "btnFileView";
            this.btnFileView.Size = new System.Drawing.Size(149, 44);
            this.btnFileView.TabIndex = 38;
            this.btnFileView.Text = "View Files";
            this.btnFileView.UseVisualStyleBackColor = true;
            this.btnFileView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(936, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 40;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPath.Location = new System.Drawing.Point(24, 123);
            this.txtOutputPath.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(894, 31);
            this.txtOutputPath.TabIndex = 39;
            // 
            // lblOutputPath
            // 
            lblOutputPath.AutoSize = true;
            lblOutputPath.Location = new System.Drawing.Point(24, 92);
            lblOutputPath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new System.Drawing.Size(126, 25);
            lblOutputPath.TabIndex = 41;
            lblOutputPath.Text = "Output Path";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 405);
            this.Controls.Add(lblOutputPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.btnFileView);
            this.Controls.Add(this.cbxSkip);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(lblStatus);
            this.Controls.Add(this.pbrProgress);
            this.Controls.Add(lblBreak);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.btnUnpack);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtExePath);
            this.Controls.Add(lblExePath);
            this.Controls.Add(this.lblUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(3975, 480);
            this.MinimumSize = new System.Drawing.Size(1302, 480);
            this.Name = "FormMain";
            this.Text = "UXM <version>";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.OpenFileDialog ofdExe;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbxSkip;
        private System.Windows.Forms.Button btnFileView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.OpenFileDialog ofdFolder;
    }
}

