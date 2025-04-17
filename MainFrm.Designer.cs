namespace FileHunter
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.radOpenFileDialog1 = new Telerik.WinControls.UI.RadOpenFileDialog();
            this.radOpenFolderDialog1 = new Telerik.WinControls.UI.RadOpenFolderDialog();
            this.windows11DarkTheme1 = new Telerik.WinControls.Themes.Windows11DarkTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radBtnHunt = new Telerik.WinControls.UI.RadButton();
            this.radBtnSrc = new Telerik.WinControls.UI.RadButton();
            this.radBtnDest = new Telerik.WinControls.UI.RadButton();
            this.radBtnTxtFile = new Telerik.WinControls.UI.RadButton();
            this.radOpenFolderDialog2 = new Telerik.WinControls.UI.RadOpenFolderDialog();
            this.lblImgSrc = new System.Windows.Forms.Label();
            this.lblImgDest = new System.Windows.Forms.Label();
            this.lblImgFile = new System.Windows.Forms.Label();
            this.radBtnClose = new Telerik.WinControls.UI.RadButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.rmnuExit = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.rmnuAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.office2019DarkTheme1 = new Telerik.WinControls.Themes.Office2019DarkTheme();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radFileTypes = new Telerik.WinControls.UI.RadGroupBox();
            this.radImages = new Telerik.WinControls.UI.RadRadioButton();
            this.radAllFiles = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnHunt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnTxtFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radFileTypes)).BeginInit();
            this.radFileTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAllFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radOpenFileDialog1
            // 
            this.radOpenFileDialog1.DefaultExt = ".txt, .csv";
            this.radOpenFileDialog1.Filter = "";
            this.radOpenFileDialog1.InitialDirectory = "Downloads";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radLabel1.Location = new System.Drawing.Point(24, 72);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(150, 22);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Image Source Folder:";
            this.radLabel1.ThemeName = "Windows11Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radLabel2.Location = new System.Drawing.Point(24, 144);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(182, 22);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Image Destination Folder:";
            this.radLabel2.ThemeName = "Windows11Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radLabel3.Location = new System.Drawing.Point(24, 222);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(131, 22);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Image Names File:";
            this.radLabel3.ThemeName = "Windows11Dark";
            // 
            // radBtnHunt
            // 
            this.radBtnHunt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtnHunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radBtnHunt.Location = new System.Drawing.Point(262, 450);
            this.radBtnHunt.Name = "radBtnHunt";
            this.radBtnHunt.Size = new System.Drawing.Size(140, 32);
            this.radBtnHunt.TabIndex = 5;
            this.radBtnHunt.Text = "Hunt For Files!";
            this.radBtnHunt.ThemeName = "Windows11Dark";
            this.radBtnHunt.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radBtnSrc
            // 
            this.radBtnSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtnSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radBtnSrc.Location = new System.Drawing.Point(408, 62);
            this.radBtnSrc.Name = "radBtnSrc";
            // 
            // 
            // 
            this.radBtnSrc.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.radBtnSrc.Size = new System.Drawing.Size(77, 32);
            this.radBtnSrc.TabIndex = 1;
            this.radBtnSrc.Text = "Browse";
            this.radBtnSrc.ThemeName = "Windows11Dark";
            this.radBtnSrc.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radBtnDest
            // 
            this.radBtnDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtnDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radBtnDest.Location = new System.Drawing.Point(408, 134);
            this.radBtnDest.Name = "radBtnDest";
            this.radBtnDest.Size = new System.Drawing.Size(77, 32);
            this.radBtnDest.TabIndex = 2;
            this.radBtnDest.Text = "Browse";
            this.radBtnDest.ThemeName = "Windows11Dark";
            this.radBtnDest.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radBtnTxtFile
            // 
            this.radBtnTxtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtnTxtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radBtnTxtFile.Location = new System.Drawing.Point(408, 212);
            this.radBtnTxtFile.Name = "radBtnTxtFile";
            this.radBtnTxtFile.Size = new System.Drawing.Size(77, 32);
            this.radBtnTxtFile.TabIndex = 3;
            this.radBtnTxtFile.Text = "Browse";
            this.radBtnTxtFile.ThemeName = "Windows11Dark";
            this.radBtnTxtFile.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // lblImgSrc
            // 
            this.lblImgSrc.AutoSize = true;
            this.lblImgSrc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblImgSrc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.lblImgSrc.Location = new System.Drawing.Point(32, 98);
            this.lblImgSrc.Name = "lblImgSrc";
            this.lblImgSrc.Size = new System.Drawing.Size(0, 19);
            this.lblImgSrc.TabIndex = 5;
            // 
            // lblImgDest
            // 
            this.lblImgDest.AutoSize = true;
            this.lblImgDest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblImgDest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.lblImgDest.Location = new System.Drawing.Point(36, 173);
            this.lblImgDest.Name = "lblImgDest";
            this.lblImgDest.Size = new System.Drawing.Size(0, 19);
            this.lblImgDest.TabIndex = 6;
            // 
            // lblImgFile
            // 
            this.lblImgFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImgFile.AutoSize = true;
            this.lblImgFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblImgFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.lblImgFile.Location = new System.Drawing.Point(36, 247);
            this.lblImgFile.Name = "lblImgFile";
            this.lblImgFile.Size = new System.Drawing.Size(0, 19);
            this.lblImgFile.TabIndex = 7;
            // 
            // radBtnClose
            // 
            this.radBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radBtnClose.Location = new System.Drawing.Point(408, 450);
            this.radBtnClose.Name = "radBtnClose";
            this.radBtnClose.Size = new System.Drawing.Size(77, 32);
            this.radBtnClose.TabIndex = 10;
            this.radBtnClose.Text = "Close";
            this.radBtnClose.ThemeName = "Windows11Dark";
            this.radBtnClose.Click += new System.EventHandler(this.radButton5_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.progressBar1.Location = new System.Drawing.Point(24, 394);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(461, 19);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // lblProcessing
            // 
            this.lblProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblProcessing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.lblProcessing.Location = new System.Drawing.Point(20, 372);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(95, 19);
            this.lblProcessing.TabIndex = 12;
            this.lblProcessing.Text = "Hunting for: ";
            this.lblProcessing.Visible = false;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmnuExit});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            // 
            // rmnuExit
            // 
            this.rmnuExit.Name = "rmnuExit";
            this.rmnuExit.Text = "Exit";
            this.rmnuExit.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmnuAbout});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Help";
            // 
            // rmnuAbout
            // 
            this.rmnuAbout.Name = "rmnuAbout";
            this.rmnuAbout.Text = "About";
            this.rmnuAbout.Click += new System.EventHandler(this.rmnuAbout_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(497, 25);
            this.radMenu1.TabIndex = 13;
            this.radMenu1.ThemeName = "Office2019Dark";
            // 
            // radFileTypes
            // 
            this.radFileTypes.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radFileTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radFileTypes.Controls.Add(this.radImages);
            this.radFileTypes.Controls.Add(this.radAllFiles);
            this.radFileTypes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.radFileTypes.ForeColor = System.Drawing.Color.White;
            this.radFileTypes.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radFileTypes.HeaderText = "File Types: ";
            this.radFileTypes.Location = new System.Drawing.Point(24, 290);
            this.radFileTypes.Name = "radFileTypes";
            // 
            // 
            // 
            this.radFileTypes.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.radFileTypes.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.radFileTypes.Size = new System.Drawing.Size(461, 58);
            this.radFileTypes.TabIndex = 14;
            this.radFileTypes.Text = "File Types: ";
            this.radFileTypes.ThemeName = "Windows11Dark";
            // 
            // radImages
            // 
            this.radImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radImages.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.radImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radImages.Location = new System.Drawing.Point(339, 21);
            this.radImages.Name = "radImages";
            // 
            // 
            // 
            this.radImages.RootElement.AutoToolTip = true;
            this.radImages.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.radImages.Size = new System.Drawing.Size(105, 24);
            this.radImages.TabIndex = 1;
            this.radImages.Text = "Images Only";
            this.radImages.ThemeName = "Windows11Dark";
            this.radImages.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radImages.ScreenTipNeeded += new Telerik.WinControls.ScreenTipNeededEventHandler(this.radImages_ScreenTipNeeded);
            // 
            // radAllFiles
            // 
            this.radAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radAllFiles.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.radAllFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.radAllFiles.Location = new System.Drawing.Point(246, 21);
            this.radAllFiles.Name = "radAllFiles";
            // 
            // 
            // 
            this.radAllFiles.RootElement.AutoToolTip = true;
            this.radAllFiles.Size = new System.Drawing.Size(74, 24);
            this.radAllFiles.TabIndex = 0;
            this.radAllFiles.TabStop = false;
            this.radAllFiles.Text = "All Files";
            this.radAllFiles.ThemeName = "Windows11Dark";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 494);
            this.Controls.Add(this.radFileTypes);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radBtnClose);
            this.Controls.Add(this.lblImgFile);
            this.Controls.Add(this.lblImgDest);
            this.Controls.Add(this.lblImgSrc);
            this.Controls.Add(this.radBtnTxtFile);
            this.Controls.Add(this.radBtnDest);
            this.Controls.Add(this.radBtnSrc);
            this.Controls.Add(this.radBtnHunt);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "File Hunter";
            this.ThemeName = "Windows11Dark";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnHunt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnTxtFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radFileTypes)).EndInit();
            this.radFileTypes.ResumeLayout(false);
            this.radFileTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAllFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadOpenFileDialog radOpenFileDialog1;
        private Telerik.WinControls.UI.RadOpenFolderDialog radOpenFolderDialog1;
        private Telerik.WinControls.Themes.Windows11DarkTheme windows11DarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton radBtnHunt;
        private Telerik.WinControls.UI.RadButton radBtnSrc;
        private Telerik.WinControls.UI.RadButton radBtnDest;
        private Telerik.WinControls.UI.RadButton radBtnTxtFile;
        private Telerik.WinControls.UI.RadOpenFolderDialog radOpenFolderDialog2;
        private System.Windows.Forms.Label lblImgSrc;
        private System.Windows.Forms.Label lblImgDest;
        private System.Windows.Forms.Label lblImgFile;
        private Telerik.WinControls.UI.RadButton radBtnClose;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProcessing;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem rmnuExit;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem rmnuAbout;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.Themes.Office2019DarkTheme office2019DarkTheme1;
        private Telerik.WinControls.UI.RadGroupBox radFileTypes;
        private Telerik.WinControls.UI.RadRadioButton radImages;
        private Telerik.WinControls.UI.RadRadioButton radAllFiles;
    }
}
