using System.Diagnostics;
using System.Security.Cryptography;

namespace RefreshBackGround
{
    public partial class Items : Form
    {
        string myPath = @"C:\BackGroundImage\latest.jpg";
        public string imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/latest.jpg".Trim();//10000x6000
        public bool state = true;
        //icon.DoubleClick += nIcon_DoubleClick;
        //icon.Click += nIcon_DoubleClick;
        public double howlong;
        public int count;
        public string simage = "ContinentalUS";
        //Items frm = new Items();



        public void fillinlabels()
        {
            //
            // pathtxtbx.Text = myPath;
            //lastwritetimetxt.Text = File.GetLastWriteTime(myPath).ToString();
            //CheckForIllegalCrossThreadCalls();
            lastwritetimelbl.Text = File.GetLastWriteTime(myPath).ToString();
            idldlbl.Text = myPath;
            URLlbl.Text = imageLocation;
            namelbl.Text = simage;
            refreshbtn.Enabled = false;
            countlbl.Text = count.ToString();

        }

        public void ImageThumbnails()
        {
            //needs to be read from JSON file into array or something
            //needs to be called Async
            //
            pictureBox1.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/thumbnail.jpg";
            pictureBox2.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/FD/GEOCOLOR/thumbnail.jpg ";
            pictureBox3.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/FD/GEOCOLOR/thumbnail.jpg";
            pictureBox4.ImageLocation = "http://rammb.cira.colostate.edu/ramsdis/online/images/thumb/himawari-8/full_disk_ahi_true_color.jpg";
            pictureBox5.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/taw/GEOCOLOR/thumbnail.jpg";
        }


        public Items()
        {
            MessageBox.Show("Items");
            InitializeComponent();
            Show();
            fillinlabels();
            //ImageThumbnails();
            refreshbtn.Enabled = true;
            //frm.Activate();
            //fillinlabels();
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
            // fillinlabels();
        }

        private void downloadimagebtn_Click(object sender, EventArgs e)
        {
            ImageDownloader.DownloadImage(imageLocation);
            fillinlabels();
            refreshbtn.Enabled = true;
        }


        public void Items_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Items_Load");


            //Items activeForm = this;
            //fillinlabels();
            //refreshbtn.Enabled = true;

        }

        private void Items_FormCloseing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
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

                foreach (var process in Process.GetProcessesByName("RefreshBackGround"))
                {
                    process.Kill();
                }
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

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton? button = sender as RadioButton;
            string imagename = button.Name;
            simage = imagename;
            switchImage(simage);
        }


        private void switchImage(string simage)
        {

            switch (simage)
            {
                case "ContinentalUS":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "TropicalAtlantic":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/taw/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "TropicalPacific":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/tpw/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "USWestCoast":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/CONUS/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "NorthernSouthAmerica":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/ssa/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "SouthernSouthAmerica":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/ssa/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "Himawari8FullDisk":
                    imageLocation = "http://rammb.cira.colostate.edu/ramsdis/online/images/latest_hi_res/himawari-8/full_disk_ahi_true_color.jpg".Trim();
                    break;
                case "NorthernPacific":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/np/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "GOESEastFullDisk":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/FD/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "GOESWestFullDisk":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/FD/GEOCOLOR/latest.jpg".Trim();
                    break;
                default:
                    break;
            }

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //do nothing until button is clicked
        }

        private void setbtn(object sender, EventArgs e)
        {
            // howlong = ((double)numericUpDown1.Value);
        }



        private void icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Items_Load();
            //Form form = new Form();
            //Form.Activate();
            Show(Form.ActiveForm);
        }



        private void open_Click(object sender, EventArgs e)
        {
            Show(Form.ActiveForm);

        }


    }
}
