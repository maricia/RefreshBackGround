namespace RefreshBackGroundV3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picPreview = new PictureBox();
            grpStatus = new GroupBox();
            lblStatusIcon = new Label();
            grpCONUSGeoColor = new GroupBox();
            lblDescription = new Label();
            label3 = new Label();
            lblCONUSGeoColor = new Label();
            progressDownload = new ProgressBar();
            lblLastDownloadedAgain = new Label();
            btnDownloadNow = new Button();
            label2 = new Label();
            label1 = new Label();
            lblStatus = new Label();
            lblResolutionValue = new Label();
            lblFileNameValue = new Label();
            lblLastDownload = new Label();
            lblLastDownloadValue = new Label();
            lblRefreshMinutes = new Label();
            numRefreshMinutes = new NumericUpDown();
            grpSettings = new GroupBox();
            btnRestoreWallpaper = new Button();
            btnSaveSettings = new Button();
            lblMonitor = new Label();
            btnSetWallpaper = new Button();
            cmbMonitors = new ComboBox();
            rbConusGeoColor = new RadioButton();
            refreshTimer = new System.Windows.Forms.Timer(components);
            pbConusGeoColor = new PictureBox();
            pbGulfAmerica = new PictureBox();
            pbGeoColor = new PictureBox();
            pbDust = new PictureBox();
            rbGeoColor = new RadioButton();
            rbDust = new RadioButton();
            rbGulfAmerica = new RadioButton();
            flowLayoutPanelSources = new FlowLayoutPanel();
            pnlWallpaperSources = new Panel();
            pnlGeoColor = new Panel();
            label9 = new Label();
            label5 = new Label();
            lblresolution3 = new Label();
            pnlGulf = new Panel();
            label12 = new Label();
            lblresolution2 = new Label();
            label4 = new Label();
            pnlConus = new Panel();
            label11 = new Label();
            label6 = new Label();
            lblresolution4 = new Label();
            pnlDust = new Panel();
            label10 = new Label();
            label7 = new Label();
            lblresolution5 = new Label();
            label8 = new Label();
            lblInfoIcon = new Label();
            lblNoaaCredit = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            grpStatus.SuspendLayout();
            grpCONUSGeoColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRefreshMinutes).BeginInit();
            grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConusGeoColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGulfAmerica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGeoColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDust).BeginInit();
            flowLayoutPanelSources.SuspendLayout();
            pnlWallpaperSources.SuspendLayout();
            pnlGeoColor.SuspendLayout();
            pnlGulf.SuspendLayout();
            pnlConus.SuspendLayout();
            pnlDust.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // picPreview
            // 
            picPreview.Enabled = false;
            picPreview.Location = new Point(9, 178);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(315, 145);
            picPreview.SizeMode = PictureBoxSizeMode.AutoSize;
            picPreview.TabIndex = 0;
            picPreview.TabStop = false;
            picPreview.Click += picPreview_Click;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(lblStatusIcon);
            grpStatus.Controls.Add(grpCONUSGeoColor);
            grpStatus.Controls.Add(progressDownload);
            grpStatus.Controls.Add(lblLastDownloadedAgain);
            grpStatus.Controls.Add(btnDownloadNow);
            grpStatus.Controls.Add(label2);
            grpStatus.Controls.Add(label1);
            grpStatus.Controls.Add(picPreview);
            grpStatus.Controls.Add(lblStatus);
            grpStatus.Controls.Add(lblResolutionValue);
            grpStatus.Controls.Add(lblFileNameValue);
            grpStatus.Controls.Add(lblLastDownload);
            grpStatus.Location = new Point(12, 42);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(365, 388);
            grpStatus.TabIndex = 1;
            grpStatus.TabStop = false;
            grpStatus.Text = "Status";
            // 
            // lblStatusIcon
            // 
            lblStatusIcon.AutoSize = true;
            lblStatusIcon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusIcon.ForeColor = Color.Green;
            lblStatusIcon.Location = new Point(20, 34);
            lblStatusIcon.Name = "lblStatusIcon";
            lblStatusIcon.Size = new Size(30, 30);
            lblStatusIcon.TabIndex = 10;
            lblStatusIcon.Text = "✓";
            // 
            // grpCONUSGeoColor
            // 
            grpCONUSGeoColor.Controls.Add(lblDescription);
            grpCONUSGeoColor.Controls.Add(label3);
            grpCONUSGeoColor.Controls.Add(lblCONUSGeoColor);
            grpCONUSGeoColor.Location = new Point(371, 371);
            grpCONUSGeoColor.Name = "grpCONUSGeoColor";
            grpCONUSGeoColor.Size = new Size(602, 468);
            grpCONUSGeoColor.TabIndex = 9;
            grpCONUSGeoColor.TabStop = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = SystemColors.ActiveCaptionText;
            lblDescription.Location = new Point(288, 78);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(364, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "True Color day time and night time imagery for the Continental U.S.";
            lblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 130);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Resolution";
            // 
            // lblCONUSGeoColor
            // 
            lblCONUSGeoColor.AutoSize = true;
            lblCONUSGeoColor.Location = new Point(315, 41);
            lblCONUSGeoColor.Name = "lblCONUSGeoColor";
            lblCONUSGeoColor.Size = new Size(108, 15);
            lblCONUSGeoColor.TabIndex = 8;
            lblCONUSGeoColor.Text = "CONUS / GeoColor";
            // 
            // progressDownload
            // 
            progressDownload.Location = new Point(77, 238);
            progressDownload.Name = "progressDownload";
            progressDownload.Size = new Size(154, 23);
            progressDownload.Style = ProgressBarStyle.Marquee;
            progressDownload.TabIndex = 10;
            progressDownload.Visible = false;
            // 
            // lblLastDownloadedAgain
            // 
            lblLastDownloadedAgain.AutoSize = true;
            lblLastDownloadedAgain.Location = new Point(17, 160);
            lblLastDownloadedAgain.Name = "lblLastDownloadedAgain";
            lblLastDownloadedAgain.Size = new Size(85, 15);
            lblLastDownloadedAgain.TabIndex = 9;
            lblLastDownloadedAgain.Text = "Last Download";
            lblLastDownloadedAgain.Click += lblLastDownloadedAgain_Click;
            // 
            // btnDownloadNow
            // 
            btnDownloadNow.Location = new Point(6, 335);
            btnDownloadNow.Name = "btnDownloadNow";
            btnDownloadNow.Size = new Size(170, 36);
            btnDownloadNow.TabIndex = 1;
            btnDownloadNow.Text = "Download Now";
            btnDownloadNow.UseVisualStyleBackColor = true;
            btnDownloadNow.Click += btnDownloadNow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 133);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Resolution";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 100);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 7;
            label1.Text = "File Name";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(56, 46);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Ready";
            // 
            // lblResolutionValue
            // 
            lblResolutionValue.AutoSize = true;
            lblResolutionValue.Location = new Point(119, 133);
            lblResolutionValue.Name = "lblResolutionValue";
            lblResolutionValue.Size = new Size(63, 15);
            lblResolutionValue.TabIndex = 2;
            lblResolutionValue.Text = "Resolution";
            // 
            // lblFileNameValue
            // 
            lblFileNameValue.AutoSize = true;
            lblFileNameValue.Location = new Point(119, 100);
            lblFileNameValue.Name = "lblFileNameValue";
            lblFileNameValue.Size = new Size(60, 15);
            lblFileNameValue.TabIndex = 1;
            lblFileNameValue.Text = "File Name";
            lblFileNameValue.Click += lblFileName_Click;
            // 
            // lblLastDownload
            // 
            lblLastDownload.AutoSize = true;
            lblLastDownload.Location = new Point(17, 69);
            lblLastDownload.Name = "lblLastDownload";
            lblLastDownload.Size = new Size(85, 15);
            lblLastDownload.TabIndex = 0;
            lblLastDownload.Text = "Last Download";
            // 
            // lblLastDownloadValue
            // 
            lblLastDownloadValue.AutoSize = true;
            lblLastDownloadValue.Location = new Point(198, 83);
            lblLastDownloadValue.Name = "lblLastDownloadValue";
            lblLastDownloadValue.Size = new Size(85, 15);
            lblLastDownloadValue.TabIndex = 1;
            lblLastDownloadValue.Text = "Last Download";
            // 
            // lblRefreshMinutes
            // 
            lblRefreshMinutes.AutoSize = true;
            lblRefreshMinutes.Location = new Point(54, 83);
            lblRefreshMinutes.Name = "lblRefreshMinutes";
            lblRefreshMinutes.Size = new Size(92, 15);
            lblRefreshMinutes.TabIndex = 2;
            lblRefreshMinutes.Text = "Refresh Minutes";
            // 
            // numRefreshMinutes
            // 
            numRefreshMinutes.ImeMode = ImeMode.On;
            numRefreshMinutes.Location = new Point(152, 81);
            numRefreshMinutes.Name = "numRefreshMinutes";
            numRefreshMinutes.Size = new Size(40, 23);
            numRefreshMinutes.TabIndex = 0;
            numRefreshMinutes.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numRefreshMinutes.ValueChanged += numRefreshMinutes_ValueChanged;
            // 
            // grpSettings
            // 
            grpSettings.Controls.Add(btnRestoreWallpaper);
            grpSettings.Controls.Add(btnSaveSettings);
            grpSettings.Controls.Add(lblMonitor);
            grpSettings.Controls.Add(btnSetWallpaper);
            grpSettings.Controls.Add(lblLastDownloadValue);
            grpSettings.Controls.Add(cmbMonitors);
            grpSettings.Controls.Add(lblRefreshMinutes);
            grpSettings.Controls.Add(numRefreshMinutes);
            grpSettings.Location = new Point(11, 440);
            grpSettings.Name = "grpSettings";
            grpSettings.Size = new Size(366, 196);
            grpSettings.TabIndex = 2;
            grpSettings.TabStop = false;
            grpSettings.Text = "Settings";
            // 
            // btnRestoreWallpaper
            // 
            btnRestoreWallpaper.Location = new Point(163, 112);
            btnRestoreWallpaper.Name = "btnRestoreWallpaper";
            btnRestoreWallpaper.Size = new Size(133, 33);
            btnRestoreWallpaper.TabIndex = 4;
            btnRestoreWallpaper.Text = "Restore Previous";
            btnRestoreWallpaper.UseVisualStyleBackColor = true;
            btnRestoreWallpaper.Click += btnRestoreWallpaper_Click;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(91, 149);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(131, 34);
            btnSaveSettings.TabIndex = 3;
            btnSaveSettings.Text = "Save Settings";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // lblMonitor
            // 
            lblMonitor.AutoSize = true;
            lblMonitor.Location = new Point(25, 22);
            lblMonitor.Name = "lblMonitor";
            lblMonitor.Size = new Size(50, 15);
            lblMonitor.TabIndex = 1;
            lblMonitor.Text = "Monitor";
            lblMonitor.Click += lblMonitor_Click;
            // 
            // btnSetWallpaper
            // 
            btnSetWallpaper.Location = new Point(36, 114);
            btnSetWallpaper.Name = "btnSetWallpaper";
            btnSetWallpaper.Size = new Size(121, 31);
            btnSetWallpaper.TabIndex = 2;
            btnSetWallpaper.Text = "Set Wallpaper";
            btnSetWallpaper.UseVisualStyleBackColor = true;
            btnSetWallpaper.Click += btnSetWallpaper_Click;
            // 
            // cmbMonitors
            // 
            cmbMonitors.FormattingEnabled = true;
            cmbMonitors.Location = new Point(22, 45);
            cmbMonitors.Name = "cmbMonitors";
            cmbMonitors.Size = new Size(278, 23);
            cmbMonitors.TabIndex = 0;
            cmbMonitors.SelectedIndexChanged += cmbMonitors_SelectedIndexChanged;
            // 
            // rbConusGeoColor
            // 
            rbConusGeoColor.AutoSize = true;
            rbConusGeoColor.Location = new Point(5, 60);
            rbConusGeoColor.Name = "rbConusGeoColor";
            rbConusGeoColor.Size = new Size(14, 13);
            rbConusGeoColor.TabIndex = 7;
            rbConusGeoColor.TabStop = true;
            rbConusGeoColor.UseVisualStyleBackColor = true;
            // 
            // refreshTimer
            // 
            refreshTimer.Tick += refreshTimer_Tick;
            // 
            // pbConusGeoColor
            // 
            pbConusGeoColor.Location = new Point(25, 0);
            pbConusGeoColor.Name = "pbConusGeoColor";
            pbConusGeoColor.Size = new Size(220, 132);
            pbConusGeoColor.SizeMode = PictureBoxSizeMode.Zoom;
            pbConusGeoColor.TabIndex = 3;
            pbConusGeoColor.TabStop = false;
            // 
            // pbGulfAmerica
            // 
            pbGulfAmerica.Location = new Point(25, 0);
            pbGulfAmerica.Name = "pbGulfAmerica";
            pbGulfAmerica.Size = new Size(160, 160);
            pbGulfAmerica.SizeMode = PictureBoxSizeMode.Zoom;
            pbGulfAmerica.TabIndex = 4;
            pbGulfAmerica.TabStop = false;
            // 
            // pbGeoColor
            // 
            pbGeoColor.Location = new Point(25, 3);
            pbGeoColor.Name = "pbGeoColor";
            pbGeoColor.Size = new Size(160, 160);
            pbGeoColor.SizeMode = PictureBoxSizeMode.AutoSize;
            pbGeoColor.TabIndex = 1;
            pbGeoColor.TabStop = false;
            // 
            // pbDust
            // 
            pbDust.Location = new Point(25, 3);
            pbDust.Name = "pbDust";
            pbDust.Size = new Size(160, 160);
            pbDust.SizeMode = PictureBoxSizeMode.AutoSize;
            pbDust.TabIndex = 2;
            pbDust.TabStop = false;
            // 
            // rbGeoColor
            // 
            rbGeoColor.AutoSize = true;
            rbGeoColor.Location = new Point(5, 53);
            rbGeoColor.Name = "rbGeoColor";
            rbGeoColor.Size = new Size(14, 13);
            rbGeoColor.TabIndex = 5;
            rbGeoColor.TabStop = true;
            rbGeoColor.UseVisualStyleBackColor = true;
            // 
            // rbDust
            // 
            rbDust.AutoSize = true;
            rbDust.Location = new Point(5, 55);
            rbDust.Name = "rbDust";
            rbDust.Size = new Size(14, 13);
            rbDust.TabIndex = 6;
            rbDust.TabStop = true;
            rbDust.UseVisualStyleBackColor = true;
            // 
            // rbGulfAmerica
            // 
            rbGulfAmerica.AutoSize = true;
            rbGulfAmerica.Location = new Point(5, 57);
            rbGulfAmerica.Name = "rbGulfAmerica";
            rbGulfAmerica.Size = new Size(14, 13);
            rbGulfAmerica.TabIndex = 8;
            rbGulfAmerica.TabStop = true;
            rbGulfAmerica.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSources
            // 
            flowLayoutPanelSources.AutoScroll = true;
            flowLayoutPanelSources.Controls.Add(pnlWallpaperSources);
            flowLayoutPanelSources.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelSources.Location = new Point(6, 48);
            flowLayoutPanelSources.Name = "flowLayoutPanelSources";
            flowLayoutPanelSources.Size = new Size(382, 570);
            flowLayoutPanelSources.TabIndex = 9;
            flowLayoutPanelSources.WrapContents = false;
            // 
            // pnlWallpaperSources
            // 
            pnlWallpaperSources.Controls.Add(pnlGeoColor);
            pnlWallpaperSources.Controls.Add(pnlGulf);
            pnlWallpaperSources.Controls.Add(pnlConus);
            pnlWallpaperSources.Controls.Add(pnlDust);
            pnlWallpaperSources.Location = new Point(3, 3);
            pnlWallpaperSources.Name = "pnlWallpaperSources";
            pnlWallpaperSources.Size = new Size(365, 557);
            pnlWallpaperSources.TabIndex = 10;
            // 
            // pnlGeoColor
            // 
            pnlGeoColor.Controls.Add(label9);
            pnlGeoColor.Controls.Add(label5);
            pnlGeoColor.Controls.Add(lblresolution3);
            pnlGeoColor.Controls.Add(rbGeoColor);
            pnlGeoColor.Controls.Add(pbGeoColor);
            pnlGeoColor.Location = new Point(3, 3);
            pnlGeoColor.Name = "pnlGeoColor";
            pnlGeoColor.Size = new Size(362, 142);
            pnlGeoColor.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoEllipsis = true;
            label9.Location = new Point(191, 53);
            label9.Name = "label9";
            label9.Size = new Size(169, 35);
            label9.TabIndex = 13;
            label9.Text = "True color imagery with day/night lighting";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 22);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "GeoColor";
            // 
            // lblresolution3
            // 
            lblresolution3.AutoSize = true;
            lblresolution3.Location = new Point(224, 99);
            lblresolution3.Name = "lblresolution3";
            lblresolution3.Size = new Size(63, 15);
            lblresolution3.TabIndex = 11;
            lblresolution3.Text = "Resolution";
            // 
            // pnlGulf
            // 
            pnlGulf.Controls.Add(label12);
            pnlGulf.Controls.Add(lblresolution2);
            pnlGulf.Controls.Add(label4);
            pnlGulf.Controls.Add(rbGulfAmerica);
            pnlGulf.Controls.Add(pbGulfAmerica);
            pnlGulf.Location = new Point(3, 423);
            pnlGulf.Name = "pnlGulf";
            pnlGulf.Size = new Size(362, 131);
            pnlGulf.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoEllipsis = true;
            label12.Location = new Point(197, 47);
            label12.Name = "label12";
            label12.Size = new Size(100, 31);
            label12.TabIndex = 11;
            label12.Text = "Regional Gulf satellite imagery";
            // 
            // lblresolution2
            // 
            lblresolution2.AutoSize = true;
            lblresolution2.Location = new Point(205, 92);
            lblresolution2.Name = "lblresolution2";
            lblresolution2.Size = new Size(63, 15);
            lblresolution2.TabIndex = 10;
            lblresolution2.Text = "Resolution";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 19);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 9;
            label4.Text = "Gulf of America";
            // 
            // pnlConus
            // 
            pnlConus.Controls.Add(label11);
            pnlConus.Controls.Add(label6);
            pnlConus.Controls.Add(lblresolution4);
            pnlConus.Controls.Add(rbConusGeoColor);
            pnlConus.Controls.Add(pbConusGeoColor);
            pnlConus.Location = new Point(3, 286);
            pnlConus.Name = "pnlConus";
            pnlConus.Size = new Size(362, 131);
            pnlConus.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoEllipsis = true;
            label11.Location = new Point(248, 35);
            label11.Name = "label11";
            label11.Size = new Size(110, 62);
            label11.TabIndex = 10;
            label11.Text = "Full continental United States imagery";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 11);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 9;
            label6.Text = "Conus / Geo Color";
            // 
            // lblresolution4
            // 
            lblresolution4.AutoSize = true;
            lblresolution4.Location = new Point(276, 104);
            lblresolution4.Name = "lblresolution4";
            lblresolution4.Size = new Size(63, 15);
            lblresolution4.TabIndex = 8;
            lblresolution4.Text = "Resolution";
            // 
            // pnlDust
            // 
            pnlDust.Controls.Add(label10);
            pnlDust.Controls.Add(label7);
            pnlDust.Controls.Add(lblresolution5);
            pnlDust.Controls.Add(rbDust);
            pnlDust.Controls.Add(pbDust);
            pnlDust.Location = new Point(3, 149);
            pnlDust.Name = "pnlDust";
            pnlDust.Size = new Size(362, 131);
            pnlDust.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.Location = new Point(185, 47);
            label10.Name = "label10";
            label10.Size = new Size(145, 35);
            label10.TabIndex = 14;
            label10.Text = "Dust and aerosol detection imagery";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(238, 32);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 10;
            label7.Text = "Dust";
            label7.Click += label7_Click;
            // 
            // lblresolution5
            // 
            lblresolution5.AutoSize = true;
            lblresolution5.Location = new Point(224, 92);
            lblresolution5.Name = "lblresolution5";
            lblresolution5.Size = new Size(63, 15);
            lblresolution5.TabIndex = 9;
            lblresolution5.Text = "Resolution";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(263, 21);
            label8.TabIndex = 0;
            label8.Text = "Choose a NOAA  satellite product";
            // 
            // lblInfoIcon
            // 
            lblInfoIcon.AutoSize = true;
            lblInfoIcon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoIcon.Location = new Point(6, 621);
            lblInfoIcon.Name = "lblInfoIcon";
            lblInfoIcon.Size = new Size(25, 21);
            lblInfoIcon.TabIndex = 4;
            lblInfoIcon.Text = "ⓘ";
            lblInfoIcon.Click += lblInfoIcon_Click;
            // 
            // lblNoaaCredit
            // 
            lblNoaaCredit.AutoSize = true;
            lblNoaaCredit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoaaCredit.Location = new Point(37, 621);
            lblNoaaCredit.Name = "lblNoaaCredit";
            lblNoaaCredit.Size = new Size(337, 21);
            lblNoaaCredit.TabIndex = 5;
            lblNoaaCredit.Text = "Images provided by NOAA / NESDIS / STAR";
            lblNoaaCredit.Click += lblNoaaCredit_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(flowLayoutPanelSources);
            groupBox1.Controls.Add(lblInfoIcon);
            groupBox1.Controls.Add(lblNoaaCredit);
            groupBox1.Location = new Point(383, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 661);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Wallpaper Source";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 695);
            Controls.Add(grpSettings);
            Controls.Add(grpStatus);
            Controls.Add(groupBox1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RefreshBackGround V3";
            Shown += MainForm_Shown;
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            grpCONUSGeoColor.ResumeLayout(false);
            grpCONUSGeoColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRefreshMinutes).EndInit();
            grpSettings.ResumeLayout(false);
            grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbConusGeoColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGulfAmerica).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGeoColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDust).EndInit();
            flowLayoutPanelSources.ResumeLayout(false);
            pnlWallpaperSources.ResumeLayout(false);
            pnlGeoColor.ResumeLayout(false);
            pnlGeoColor.PerformLayout();
            pnlGulf.ResumeLayout(false);
            pnlGulf.PerformLayout();
            pnlConus.ResumeLayout(false);
            pnlConus.PerformLayout();
            pnlDust.ResumeLayout(false);
            pnlDust.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPreview;
        private GroupBox grpStatus;
        private GroupBox grpSettings;
        private Label lblFileNameValue;
        private Label lblLastDownload;
        private Label lblResolutionValue;
        private NumericUpDown numRefreshMinutes;
        private Button btnDownloadNow;
        private Button btnSetWallpaper;
        private Button btnSaveSettings;
        private Label lblLastDownloadValue;
        private Label lblStatus;
        private Label lblRefreshMinutes;
        private Label label2;
        private Label label1;
        private Label lblMonitor;
        private ComboBox cmbMonitors;
        private RadioButton rbConusGeoColor;
        private Button btnRestoreWallpaper;
        private Label lblLastDownloadedAgain;
        private ProgressBar progressDownload;
        private System.Windows.Forms.Timer refreshTimer;
        private GroupBox grpCONUSGeoColor;
        private PictureBox pbGulfAmerica;
        private PictureBox pbGeoColor;
        private PictureBox pbDust;
        private PictureBox pbConusGeoColor;
        private RadioButton rbGeoColor;
        private RadioButton rbDust;
        private RadioButton rbGulfAmerica;
        private Label lblDescription;
        private Label label3;
        private Label lblCONUSGeoColor;
        private FlowLayoutPanel flowLayoutPanelSources;
        private Panel pnlGeoColor;
        private Panel pnlDust;
        private Panel pnlConus;
        private Panel pnlGulf;
        private Label label4;
        private Label lblresolution2;
        private Label lblresolution3;
        private Label label5;
        private Label label7;
        private Label lblresolution5;
        private Label label6;
        private Label lblresolution4;
        private Label lblStatusIcon;
        private Label lblInfoIcon;
        private Label lblNoaaCredit;
        private Panel pnlWallpaperSources;
        private GroupBox groupBox1;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label12;
    }
}
