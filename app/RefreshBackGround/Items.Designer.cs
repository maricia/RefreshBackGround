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
            image1 = new PictureBox();
            icon = new NotifyIcon(components);
            myMenu = new ContextMenuStrip(components);
            refreshToolStripMenuItem = new ToolStripMenuItem();
            FetchImage = new ToolStripMenuItem();
            downloaddirlbl = new Label();
            lastwritetimelbl = new Label();
            lwrtlbl = new Label();
            idldlbl = new Label();
            label1 = new Label();
            URLlbl = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            stopprocessbtn = new Button();
            label3 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            myMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(20, 108);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(206, 44);
            refreshbtn.TabIndex = 0;
            refreshbtn.Text = "Refresh Background";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // downloadimagebtn
            // 
            downloadimagebtn.Location = new Point(13, 276);
            downloadimagebtn.Name = "downloadimagebtn";
            downloadimagebtn.Size = new Size(206, 44);
            downloadimagebtn.TabIndex = 1;
            downloadimagebtn.Text = "Manual Download";
            downloadimagebtn.UseVisualStyleBackColor = true;
            downloadimagebtn.Click += downloadimagebtn_Click;
            // 
            // image1
            // 
            image1.BackgroundImageLayout = ImageLayout.None;
            image1.ImageLocation = @"E:\BackGroundImage\10000x6000.jpg";
            image1.Location = new Point(550, 30);
            image1.Name = "image1";
            image1.Size = new Size(397, 237);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 3;
            image1.TabStop = false;
            // 
            // icon
            // 
            icon.BalloonTipIcon = ToolTipIcon.Info;
            icon.BalloonTipText = "Background Image\r\n";
            icon.ContextMenuStrip = myMenu;
            icon.Icon = (Icon)resources.GetObject("icon.Icon");
            icon.Text = "BackGround Image";
            icon.Visible = true;
            // 
            // myMenu
            // 
            myMenu.ImageScalingSize = new Size(24, 24);
            myMenu.Items.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, FetchImage });
            myMenu.Name = "contextMenuStrip1";
            myMenu.Size = new Size(182, 68);
            myMenu.Text = "Options";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.DoubleClickEnabled = true;
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(181, 32);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.ToolTipText = "Refresh Background";
            refreshToolStripMenuItem.Click += refreshbtn_Click;
            refreshToolStripMenuItem.DoubleClick += refreshbtn_Click;
            // 
            // FetchImage
            // 
            FetchImage.DoubleClickEnabled = true;
            FetchImage.Name = "FetchImage";
            FetchImage.Size = new Size(181, 32);
            FetchImage.Text = "Fetch Image";
            FetchImage.ToolTipText = "Download updated image";
            FetchImage.Click += downloadimagebtn_Click;
            FetchImage.DoubleClick += downloadimagebtn_Click;
            // 
            // downloaddirlbl
            // 
            downloaddirlbl.AutoSize = true;
            downloaddirlbl.Location = new Point(7, 44);
            downloaddirlbl.Name = "downloaddirlbl";
            downloaddirlbl.Size = new Size(226, 25);
            downloaddirlbl.TabIndex = 6;
            downloaddirlbl.Text = "Image Download Directory";
            // 
            // lastwritetimelbl
            // 
            lastwritetimelbl.AutoSize = true;
            lastwritetimelbl.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lastwritetimelbl.Location = new Point(7, 190);
            lastwritetimelbl.Name = "lastwritetimelbl";
            lastwritetimelbl.Size = new Size(133, 25);
            lastwritetimelbl.TabIndex = 7;
            lastwritetimelbl.Text = "Last Write Time";
            // 
            // lwrtlbl
            // 
            lwrtlbl.AutoSize = true;
            lwrtlbl.Location = new Point(7, 140);
            lwrtlbl.Name = "lwrtlbl";
            lwrtlbl.Size = new Size(133, 25);
            lwrtlbl.TabIndex = 9;
            lwrtlbl.Text = "Last Write Time";
            // 
            // idldlbl
            // 
            idldlbl.AutoSize = true;
            idldlbl.Location = new Point(7, 92);
            idldlbl.Name = "idldlbl";
            idldlbl.Size = new Size(141, 25);
            idldlbl.TabIndex = 10;
            idldlbl.Text = "imagedownload";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 19);
            label1.Name = "label1";
            label1.Size = new Size(499, 50);
            label1.TabIndex = 11;
            label1.Text = "Every 5 minutes a new image is downloaded from NOAA.gov\r\nand is displayed as your desktop background.";
            // 
            // URLlbl
            // 
            URLlbl.AutoSize = true;
            URLlbl.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            URLlbl.Location = new Point(301, 286);
            URLlbl.Name = "URLlbl";
            URLlbl.Size = new Size(43, 25);
            URLlbl.TabIndex = 12;
            URLlbl.Text = "URL";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(URLlbl);
            groupBox1.Controls.Add(downloaddirlbl);
            groupBox1.Controls.Add(idldlbl);
            groupBox1.Controls.Add(lastwritetimelbl);
            groupBox1.Controls.Add(image1);
            groupBox1.Controls.Add(lwrtlbl);
            groupBox1.Controls.Add(downloadimagebtn);
            groupBox1.Location = new Point(28, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1021, 367);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Refresh Image";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(refreshbtn);
            groupBox2.Location = new Point(28, 474);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 165);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Background";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(285, 25);
            label2.TabIndex = 1;
            label2.Text = "Refresh current background image";
            // 
            // stopprocessbtn
            // 
            stopprocessbtn.Location = new Point(31, 111);
            stopprocessbtn.Name = "stopprocessbtn";
            stopprocessbtn.Size = new Size(130, 41);
            stopprocessbtn.TabIndex = 5;
            stopprocessbtn.Text = "Stop";
            stopprocessbtn.UseVisualStyleBackColor = true;
            stopprocessbtn.Click += stopprocessbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 36);
            label3.Name = "label3";
            label3.Size = new Size(482, 50);
            label3.TabIndex = 6;
            label3.Text = "Close the form but allows the background processes to run\r\nKill the process and closes the app.";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(stopprocessbtn);
            groupBox3.Location = new Point(399, 474);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(543, 165);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "EXIT";
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1068, 662);
            ContextMenuStrip = myMenu;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Items";
            Text = " ";
            TopMost = true;
            WindowState = FormWindowState.Minimized;
            FormClosing += Items_FormClosing;
            //Items_FormCloseing;
            Load += Items_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            myMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button refreshbtn;
        private Button downloadimagebtn;
        private PictureBox image1;
        public NotifyIcon icon;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem FetchImage;
        public ContextMenuStrip myMenu;
        private Label downloaddirlbl;
        private Label lwrtlbl;
        private Label label1;
        private Label URLlbl;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Button stopprocessbtn;
        private Label label3;
        private GroupBox groupBox3;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        public Label lastwritetimelbl;
        public Label idldlbl;
    }
}