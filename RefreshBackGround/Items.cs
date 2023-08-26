using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace RefreshBackGround
{
    public partial class Items : Form
    {
        private readonly string myPath = @"C:\BackGroundImage\10000x6000.jpg";
        private readonly string imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/10000x6000.jpg".Trim();
        public bool state = true;
        //icon.DoubleClick += nIcon_DoubleClick;
        //icon.Click += nIcon_DoubleClick;
        public Items frm;


        public void fillinlabels()
        {
            //
            // pathtxtbx.Text = myPath;
            //lastwritetimetxt.Text = File.GetLastWriteTime(myPath).ToString();

            lastwritetimelbl.Text = File.GetLastWriteTime(myPath).ToString();
            idldlbl.Text = myPath;
            URLlbl.Text = imageLocation;

        }


        public Items()
        {
            InitializeComponent();
            fillinlabels();

        }


        /*
        private void lastwritentime()
        {
            //DateTime lasttime = DateTime.Now;
            DateTime lastright = File.GetLastWriteTime(myPath);

        }
        */

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            Wallpaper.Set(myPath);

        }

        private void downloadimagebtn_Click(object sender, EventArgs e)
        {
            ImageDownloader.DownloadImage(imageLocation);
            fillinlabels();
        }


        private void Items_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            fillinlabels();
        }

        private void Items_FormCloseing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (result == DialogResult.Yes)
                {
                    foreach (var process in Process.GetProcessesByName("RefreshBackGround"))
                    {
                        process.Kill();
                    }
                    Environment.Exit(0);
                    state = false;
                }
                else
                {
                    e.Cancel = true;

                    state = true;
                }
            }
            else
            {
                e.Cancel = true;
                state = true;
            }
            //WindowState = FormWindowState.Minimized;

        }



        private void stopprocessbtn_Click(object sender, EventArgs e)
        {

            foreach (var process in Process.GetProcessesByName("RefreshBackGround"))
            {
                process.Kill();
            }

        }

    }
}
