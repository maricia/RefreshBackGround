namespace RefreshBackGround
{
    partial class Items
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            refreshbtn = new Button();
            downloadimagebtn = new Button();
            icon = new NotifyIcon(components);
            myMenu = new ContextMenuStrip(components);
            open = new ToolStripMenuItem();
            FetchImage = new ToolStripMenuItem();
            refresh = new ToolStripMenuItem();
            downloaddirlbl = new Label();
            lastwritetimelbl = new Label();
            idldlbl = new Label();
            URLlbl = new Label();
            stopprocessbtn = new Button();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            countlbl = new Label();
            namelbl = new Label();
            lwrtlbl = new Label();
            GOESEastFullDisk = new RadioButton();
            GOESWestFullDisk = new RadioButton();
            SouthernSouthAmerica = new RadioButton();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ContinentalUS = new RadioButton();
            pictureBox1 = new PictureBox();
            NorthernSouthAmerica = new RadioButton();
            Himawari8FullDisk = new RadioButton();
            pictureBox5 = new PictureBox();
            NorthernPacific = new RadioButton();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            TropicalAtlantic = new RadioButton();
            pictureBox10 = new PictureBox();
            USWestCoast = new RadioButton();
            pictureBox4 = new PictureBox();
            TropicalPacific = new RadioButton();
            myMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // refreshbtn
            // 
            refreshbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            refreshbtn.AutoSize = true;
            refreshbtn.FlatStyle = FlatStyle.Popup;
            refreshbtn.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            refreshbtn.Location = new Point(117, 305);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(269, 54);
            refreshbtn.TabIndex = 1;
            refreshbtn.Text = "Refresh Background";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // downloadimagebtn
            // 
            downloadimagebtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downloadimagebtn.AutoEllipsis = true;
            downloadimagebtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            downloadimagebtn.BackColor = SystemColors.Control;
            downloadimagebtn.BackgroundImageLayout = ImageLayout.None;
            downloadimagebtn.FlatStyle = FlatStyle.Popup;
            downloadimagebtn.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            downloadimagebtn.Location = new Point(166, 257);
            downloadimagebtn.Name = "downloadimagebtn";
            downloadimagebtn.Size = new Size(158, 42);
            downloadimagebtn.TabIndex = 0;
            downloadimagebtn.Text = " Download";
            downloadimagebtn.UseVisualStyleBackColor = false;
            downloadimagebtn.Click += downloadimagebtn_Click;
            // 
            // icon
            // 
            icon.BalloonTipIcon = ToolTipIcon.Info;
            icon.BalloonTipText = "DownLink for PC";
            icon.ContextMenuStrip = myMenu;
            icon.Icon = (Icon)resources.GetObject("icon.Icon");
            icon.Text = " ";
            icon.Visible = true;
            icon.Click += Items_Load;
            // 
            // myMenu
            // 
            myMenu.AccessibleRole = AccessibleRole.None;
            myMenu.ImageScalingSize = new Size(24, 24);
            myMenu.Items.AddRange(new ToolStripItem[] { open, FetchImage, refresh });
            myMenu.Name = "contextMenuStrip1";
            myMenu.ShowCheckMargin = true;
            myMenu.ShowImageMargin = false;
            myMenu.Size = new Size(182, 100);
            myMenu.Text = "Downlink";
            myMenu.Opened += Items_Load;
            myMenu.Click += Items_Load;
            myMenu.DoubleClick += Items_Load;
            // 
            // open
            // 
            open.DisplayStyle = ToolStripItemDisplayStyle.Text;
            open.DoubleClickEnabled = true;
            open.Name = "open";
            open.Size = new Size(181, 32);
            open.Text = "Open";
            open.ToolTipText = "open window?";
            open.Click += open_Click;
            // 
            // FetchImage
            // 
            FetchImage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FetchImage.DoubleClickEnabled = true;
            FetchImage.Name = "FetchImage";
            FetchImage.Size = new Size(181, 32);
            FetchImage.Text = "Fetch Image";
            FetchImage.ToolTipText = "Download updated image";
            FetchImage.Click += downloadimagebtn_Click;
            FetchImage.DoubleClick += downloadimagebtn_Click;
            // 
            // refresh
            // 
            refresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            refresh.DoubleClickEnabled = true;
            refresh.Name = "refresh";
            refresh.Size = new Size(181, 32);
            refresh.Text = "Refresh";
            refresh.ToolTipText = "Refresh Background";
            refresh.Click += refreshbtn_Click;
            refresh.DoubleClick += refreshbtn_Click;
            // 
            // downloaddirlbl
            // 
            downloaddirlbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downloaddirlbl.AutoSize = true;
            downloaddirlbl.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            downloaddirlbl.Location = new Point(13, 42);
            downloaddirlbl.Name = "downloaddirlbl";
            downloaddirlbl.Size = new Size(327, 35);
            downloaddirlbl.TabIndex = 6;
            downloaddirlbl.Text = "Image Download Directory";
            downloaddirlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastwritetimelbl
            // 
            lastwritetimelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lastwritetimelbl.AutoSize = true;
            lastwritetimelbl.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastwritetimelbl.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lastwritetimelbl.Location = new Point(13, 327);
            lastwritetimelbl.Name = "lastwritetimelbl";
            lastwritetimelbl.Size = new Size(169, 29);
            lastwritetimelbl.TabIndex = 7;
            lastwritetimelbl.Text = "Last Write Time";
            lastwritetimelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idldlbl
            // 
            idldlbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            idldlbl.AutoSize = true;
            idldlbl.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            idldlbl.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            idldlbl.Location = new Point(18, 88);
            idldlbl.Name = "idldlbl";
            idldlbl.Size = new Size(145, 24);
            idldlbl.TabIndex = 10;
            idldlbl.Text = "imagedownload";
            idldlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // URLlbl
            // 
            URLlbl.AutoEllipsis = true;
            URLlbl.AutoSize = true;
            URLlbl.FlatStyle = FlatStyle.Popup;
            URLlbl.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            URLlbl.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            URLlbl.Location = new Point(23, 196);
            URLlbl.Name = "URLlbl";
            URLlbl.Size = new Size(42, 24);
            URLlbl.TabIndex = 12;
            URLlbl.Text = "URL";
            URLlbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stopprocessbtn
            // 
            stopprocessbtn.Enabled = false;
            stopprocessbtn.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            stopprocessbtn.Location = new Point(269, 1044);
            stopprocessbtn.Name = "stopprocessbtn";
            stopprocessbtn.Size = new Size(139, 39);
            stopprocessbtn.TabIndex = 3;
            stopprocessbtn.Text = "Stop";
            stopprocessbtn.UseVisualStyleBackColor = true;
            stopprocessbtn.Visible = false;
            stopprocessbtn.Click += stopprocessbtn_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.ForeColor = Color.DodgerBlue;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightGray;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.None;
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(stopprocessbtn);
            splitContainer1.Panel1.Controls.Add(downloadimagebtn);
            splitContainer1.Panel1.Controls.Add(refreshbtn);
            splitContainer1.Panel1.ForeColor = Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(GOESEastFullDisk);
            splitContainer1.Panel2.Controls.Add(GOESWestFullDisk);
            splitContainer1.Panel2.Controls.Add(SouthernSouthAmerica);
            splitContainer1.Panel2.Controls.Add(pictureBox3);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(ContinentalUS);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(NorthernSouthAmerica);
            splitContainer1.Panel2.Controls.Add(Himawari8FullDisk);
            splitContainer1.Panel2.Controls.Add(pictureBox5);
            splitContainer1.Panel2.Controls.Add(NorthernPacific);
            splitContainer1.Panel2.Controls.Add(pictureBox6);
            splitContainer1.Panel2.Controls.Add(pictureBox8);
            splitContainer1.Panel2.Controls.Add(pictureBox7);
            splitContainer1.Panel2.Controls.Add(pictureBox9);
            splitContainer1.Panel2.Controls.Add(TropicalAtlantic);
            splitContainer1.Panel2.Controls.Add(pictureBox10);
            splitContainer1.Panel2.Controls.Add(USWestCoast);
            splitContainer1.Panel2.Controls.Add(pictureBox4);
            splitContainer1.Panel2.Controls.Add(TropicalPacific);
            splitContainer1.Panel2.ForeColor = Color.DodgerBlue;
            splitContainer1.Size = new Size(1612, 1113);
            splitContainer1.SplitterDistance = 468;
            splitContainer1.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(5, 44);
            label2.Name = "label2";
            label2.Size = new Size(458, 199);
            label2.TabIndex = 19;
            label2.Text = "Select an image on the right and click download.\r\nClick refresh background button to update your desktop background.\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Location = new Point(18, 424);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(396, 192);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Refresh Rate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 37);
            label1.Name = "label1";
            label1.Size = new Size(380, 24);
            label1.TabIndex = 16;
            label1.Text = "Refresh time in seconds with the max 86400";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new Point(18, 72);
            numericUpDown1.Maximum = new decimal(new int[] { 86400, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 32);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.Value = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(countlbl);
            groupBox1.Controls.Add(namelbl);
            groupBox1.Controls.Add(URLlbl);
            groupBox1.Controls.Add(downloaddirlbl);
            groupBox1.Controls.Add(lwrtlbl);
            groupBox1.Controls.Add(lastwritetimelbl);
            groupBox1.Controls.Add(idldlbl);
            groupBox1.Location = new Point(5, 661);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 377);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info Box";
            // 
            // countlbl
            // 
            countlbl.AutoSize = true;
            countlbl.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            countlbl.Location = new Point(22, 236);
            countlbl.Name = "countlbl";
            countlbl.Size = new Size(71, 24);
            countlbl.TabIndex = 15;
            countlbl.Text = "COUNT";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.BackColor = SystemColors.Control;
            namelbl.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            namelbl.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            namelbl.Location = new Point(18, 134);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(70, 29);
            namelbl.TabIndex = 14;
            namelbl.Text = "name";
            // 
            // lwrtlbl
            // 
            lwrtlbl.AutoSize = true;
            lwrtlbl.CausesValidation = false;
            lwrtlbl.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lwrtlbl.Location = new Point(13, 274);
            lwrtlbl.Name = "lwrtlbl";
            lwrtlbl.Size = new Size(197, 35);
            lwrtlbl.TabIndex = 9;
            lwrtlbl.Text = "Last Write Time";
            lwrtlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GOESEastFullDisk
            // 
            GOESEastFullDisk.AutoSize = true;
            GOESEastFullDisk.Location = new Point(776, 100);
            GOESEastFullDisk.Name = "GOESEastFullDisk";
            GOESEastFullDisk.Size = new Size(198, 28);
            GOESEastFullDisk.TabIndex = 40;
            GOESEastFullDisk.Text = "GOES-East Full Disk";
            GOESEastFullDisk.UseVisualStyleBackColor = true;
            GOESEastFullDisk.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // GOESWestFullDisk
            // 
            GOESWestFullDisk.AutoSize = true;
            GOESWestFullDisk.Location = new Point(769, 586);
            GOESWestFullDisk.Name = "GOESWestFullDisk";
            GOESWestFullDisk.Size = new Size(205, 28);
            GOESWestFullDisk.TabIndex = 39;
            GOESWestFullDisk.Text = "GOES-West Full Disk";
            GOESWestFullDisk.UseVisualStyleBackColor = true;
            GOESWestFullDisk.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // SouthernSouthAmerica
            // 
            SouthernSouthAmerica.AutoSize = true;
            SouthernSouthAmerica.Location = new Point(404, 328);
            SouthernSouthAmerica.Name = "SouthernSouthAmerica";
            SouthernSouthAmerica.Size = new Size(239, 28);
            SouthernSouthAmerica.TabIndex = 42;
            SouthernSouthAmerica.Text = "Southern South America";
            SouthernSouthAmerica.UseVisualStyleBackColor = true;
            SouthernSouthAmerica.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/FD/GEOCOLOR/thumbnail.jpg";
            pictureBox3.Location = new Point(769, 620);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(340, 339);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/FD/GEOCOLOR/thumbnail.jpg";
            pictureBox2.Location = new Point(776, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 339);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // ContinentalUS
            // 
            ContinentalUS.AutoSize = true;
            ContinentalUS.Checked = true;
            ContinentalUS.Location = new Point(20, 76);
            ContinentalUS.Name = "ContinentalUS";
            ContinentalUS.Size = new Size(161, 28);
            ContinentalUS.TabIndex = 37;
            ContinentalUS.TabStop = true;
            ContinentalUS.Text = "Continental US";
            ContinentalUS.UseVisualStyleBackColor = true;
            ContinentalUS.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/thumbnail.jpg";
            pictureBox1.Location = new Point(20, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // NorthernSouthAmerica
            // 
            NorthernSouthAmerica.AutoSize = true;
            NorthernSouthAmerica.Location = new Point(404, 76);
            NorthernSouthAmerica.Name = "NorthernSouthAmerica";
            NorthernSouthAmerica.Size = new Size(239, 28);
            NorthernSouthAmerica.TabIndex = 41;
            NorthernSouthAmerica.Text = "Northern South America";
            NorthernSouthAmerica.UseVisualStyleBackColor = true;
            NorthernSouthAmerica.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // Himawari8FullDisk
            // 
            Himawari8FullDisk.AutoSize = true;
            Himawari8FullDisk.Location = new Point(410, 840);
            Himawari8FullDisk.Name = "Himawari8FullDisk";
            Himawari8FullDisk.Size = new Size(208, 28);
            Himawari8FullDisk.TabIndex = 38;
            Himawari8FullDisk.Text = "Himawari-8 Full Disk";
            Himawari8FullDisk.UseVisualStyleBackColor = true;
            Himawari8FullDisk.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/taw/GEOCOLOR/thumbnail.jpg";
            pictureBox5.Location = new Point(20, 362);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(325, 202);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // NorthernPacific
            // 
            NorthernPacific.AutoSize = true;
            NorthernPacific.Location = new Point(404, 588);
            NorthernPacific.Name = "NorthernPacific";
            NorthernPacific.Size = new Size(170, 28);
            NorthernPacific.TabIndex = 33;
            NorthernPacific.Text = "Northern Pacific";
            NorthernPacific.UseVisualStyleBackColor = true;
            NorthernPacific.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/tpw/GEOCOLOR/thumbnail.jpg";
            pictureBox6.Location = new Point(20, 620);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(325, 202);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/np/GEOCOLOR/thumbnail.jpg";
            pictureBox8.Location = new Point(404, 622);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(325, 202);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 27;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/CONUS/GEOCOLOR/thumbnail.jpg";
            pictureBox7.Location = new Point(20, 872);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(325, 202);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 25;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/nsa/GEOCOLOR/thumbnail.jpg";
            pictureBox9.Location = new Point(404, 110);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(325, 202);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 29;
            pictureBox9.TabStop = false;
            // 
            // TropicalAtlantic
            // 
            TropicalAtlantic.AutoSize = true;
            TropicalAtlantic.Location = new Point(20, 331);
            TropicalAtlantic.Name = "TropicalAtlantic";
            TropicalAtlantic.Size = new Size(170, 28);
            TropicalAtlantic.TabIndex = 36;
            TropicalAtlantic.Text = "Tropical Atlantic";
            TropicalAtlantic.UseVisualStyleBackColor = true;
            TropicalAtlantic.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // pictureBox10
            // 
            pictureBox10.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/ssa/GEOCOLOR/thumbnail.jpg";
            pictureBox10.Location = new Point(404, 364);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(325, 202);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 31;
            pictureBox10.TabStop = false;
            // 
            // USWestCoast
            // 
            USWestCoast.AutoSize = true;
            USWestCoast.Location = new Point(20, 838);
            USWestCoast.Name = "USWestCoast";
            USWestCoast.Size = new Size(156, 28);
            USWestCoast.TabIndex = 34;
            USWestCoast.Text = "US West Coast";
            USWestCoast.UseVisualStyleBackColor = true;
            USWestCoast.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.ImageLocation = "http://rammb.cira.colostate.edu/ramsdis/online/images/thumb/himawari-8/full_disk_ahi_true_color.jpg";
            pictureBox4.Location = new Point(410, 874);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 201);
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // TropicalPacific
            // 
            TropicalPacific.AutoSize = true;
            TropicalPacific.Location = new Point(20, 586);
            TropicalPacific.Name = "TropicalPacific";
            TropicalPacific.Size = new Size(159, 28);
            TropicalPacific.TabIndex = 35;
            TropicalPacific.Text = "Tropical Pacific";
            TropicalPacific.UseVisualStyleBackColor = true;
            TropicalPacific.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.th;
            CancelButton = stopprocessbtn;
            ClientSize = new Size(1636, 1131);
            ContextMenuStrip = myMenu;
            Controls.Add(splitContainer1);
            Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Items";
            Text = " DownLink for the PC";
            TransparencyKey = Color.Transparent;
            FormClosing += Items_FormCloseing;
            myMenu.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button refreshbtn;
        private Button downloadimagebtn;
        private ToolStripMenuItem refresh;
        private ToolStripMenuItem FetchImage;
        public ContextMenuStrip myMenu;
        private Label downloaddirlbl;
        private Button stopprocessbtn;
        public Label lastwritetimelbl;
        public Label idldlbl;
        private SplitContainer splitContainer1;
        private Label lwrtlbl;
        public Label URLlbl;
        public Label namelbl;
        private Label label1;
        public NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label2;
        public Label countlbl;
        private ToolStripMenuItem open;
        private RadioButton SouthernSouthAmerica;
        private RadioButton GOESEastFullDisk;
        private RadioButton GOESWestFullDisk;
        private RadioButton NorthernSouthAmerica;
        private RadioButton Himawari8FullDisk;
        private RadioButton ContinentalUS;
        private RadioButton TropicalAtlantic;
        private RadioButton TropicalPacific;
        private RadioButton USWestCoast;
        private RadioButton NorthernPacific;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox7;
        private PictureBox pictureBox10;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private NotifyIcon icon;
    }
}