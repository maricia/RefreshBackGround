using RefreshBackGroundV3.Services;
using System.Windows.Forms;

namespace RefreshBackGroundV3
{
    public partial class MainForm : Form
    {
        private string currentDownloadedImage = "";
        private string? previousWallpaperPath;
        private AppSettings appSettings = new AppSettings();
        public MainForm()
        {
            InitializeComponent();
            FormatPictureBoxes();
            appSettings = SettingsService.Load();
            LoadMonitors();
            LoadWallpaperSources();

            lblresolution2.Text = "1200 x 1200";   // GeoColor
            lblresolution3.Text = "1200 x 1200";   // Dust
            lblresolution4.Text = "10000 x 6000";  // CONUS / GeoColor
            lblresolution5.Text = "1000 x 1000";   // Gulf of America

            rbConusGeoColor.Checked = true;

            rbGeoColor.CheckedChanged += WallpaperSource_CheckedChanged;
            rbDust.CheckedChanged += WallpaperSource_CheckedChanged;
            rbConusGeoColor.CheckedChanged += WallpaperSource_CheckedChanged;
            rbGulfAmerica.CheckedChanged += WallpaperSource_CheckedChanged;


            numRefreshMinutes.Value = appSettings.RefreshMinutes;

            if (appSettings.SelectedMonitorIndex >= 0 &&
                appSettings.SelectedMonitorIndex < cmbMonitors.Items.Count)
            {
                cmbMonitors.SelectedIndex = appSettings.SelectedMonitorIndex;
            }


            previousWallpaperPath = appSettings.PreviousWallpaperPath;
        }
        private async Task DownloadLatestImageAsync()
        {
            /*             * This method is responsible for downloading the latest image from the specified URL and updating the UI with the download status, file name, resolution, and preview of the image.
             * The method is marked as async to allow for asynchronous operations, ensuring that the UI remains responsive during the download process.
             * It uses a try-finally block to ensure that the lblStatus and progressDownload controls are updated appropriately regardless of whether the download succeeds or fails.
             * During the download process, lblStatus is updated to indicate that the download is in progress, and progressDownload is made visible. Once the download is complete, lblStatus is updated again to reflect the completion status, and progressDownload is hidden.
             * The downloaded image's file name and resolution are displayed in the respective labels, and a preview of the image is shown in the picPreview PictureBox.
             */
            try
            {

                btnDownloadNow.Text = " ☁ Download Now";
                lblStatusIcon.Text = "⟳";
                lblStatusIcon.ForeColor = Color.DodgerBlue;
                lblStatus.Text = "Downloading...";
                progressDownload.Visible = true;
                string selectedUrl = GetSelectedWallpaperUrl();
                string savedPath =
                                await ImageDownloader.DownloadImage(selectedUrl);

                currentDownloadedImage = savedPath;
                SetPictureBoxImage(picPreview, savedPath);

                lblStatus.Text = "Download complete";
                lblFileNameValue.Text = Path.GetFileName(savedPath);
                lblLastDownloadValue.Text = DateTime.Now.ToString("g");
                lblLastDownloadedAgain.Text = DateTime.Now.ToString("g");
                lblLastDownload.Text = DateTime.Now.ToString("g");

                using Image img = Image.FromFile(savedPath);
                lblResolutionValue.Text = $"{img.Width} x {img.Height}";


            }
            catch (Exception ex)
            {
                lblStatusIcon.Text = "!";
                lblStatusIcon.ForeColor = Color.Firebrick;
                lblStatus.Text = "Download failed";
                MessageBox.Show($"Error downloading image: {ex.Message}");
                return;
            }

            finally
            {
                lblStatusIcon.Text = "✓";
                lblStatusIcon.ForeColor = Color.Green;
                //lblStatus.Text = "Ready";
                progressDownload.Visible = false;
            }
        }
        private void SetPictureBoxImage(PictureBox pictureBox, string imagePath)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }

            byte[] imageBytes = File.ReadAllBytes(imagePath);

            using MemoryStream ms = new MemoryStream(imageBytes);
            pictureBox.Image = Image.FromStream(ms);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void lblFileName_Click(object sender, EventArgs e)
        {

        }

        private async void btnDownloadNow_Click(object sender, EventArgs e)
        {
            /*             * When the "Download Now" button is clicked, this event handler is triggered. It initiates the process of downloading the latest image from the specified URL.
             * The method is marked as async to allow for asynchronous operations, ensuring that the UI remains responsive during the download process.
             * The lblStatus label is updated to indicate that the download is in progress. Once the download is complete, the label is updated again to reflect the completion status.
             * The downloaded image's file name and resolution are displayed in the respective labels, and a preview of the image is shown in the picPreview PictureBox.
             */
            await DownloadLatestImageAsync();

            /*
            lblStatus.Text = "Downloading...";
            String savedPath = await ImageDownloader.DownloadImage(ImageDownloader.ImageLocation);
            lblStatus.Text = "Download complete";
            lblFileNameValue.Text = Path.GetFileName(savedPath);
            lblLastDownloadValue.Text = DateTime.Now.ToString("g");
            picPreview.ImageLocation = savedPath;
            using Image img = Image.FromFile(savedPath);
            lblResolutionValue.Text = $"{img.Width} x {img.Height}";
            lblLastDownload.Text = DateTime.Now.ToString("g");
            lblLastDownloadedAgain.Text = DateTime.Now.ToString("g");
            */

        }

        private void numRefreshMinutes_ValueChanged(object sender, EventArgs e)
        {
            //refreshTimer.Interval = 10000;
            refreshTimer.Interval = (int)numRefreshMinutes.Value * 60 * 1000;
        }

        private void cmbMonitors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadMonitors()
        {
            /*             * This method is responsible for loading the available monitors into the cmbMonitors ComboBox. It retrieves the list of all screens using Screen.AllScreens and populates the ComboBox with the monitor names and their respective resolutions.
             * The method first clears any existing items in the ComboBox to ensure that it is updated with the current list of monitors. It then iterates through each screen, adding an entry for each monitor in the format "Monitor X (Width x Height)".
             * Finally, if there are any monitors available, it sets the selected index of the ComboBox to 0, which selects the first monitor by default.
             */

            cmbMonitors.Items.Clear();

            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                var screen = Screen.AllScreens[i];

                cmbMonitors.Items.Add(
                    $"Monitor {i + 1} ({screen.Bounds.Width}x{screen.Bounds.Height})");
            }

            if (cmbMonitors.Items.Count > 0)
            {
                cmbMonitors.SelectedIndex = 0;
            }
        }

        private void lblMonitor_Click(object sender, EventArgs e)
        {

        }



        private void btnSetWallpaper_Click(object sender, EventArgs e)
        {
            /*             * When the "Set Wallpaper" button is clicked, this event handler is triggered. It sets the downloaded image as the wallpaper for the selected monitor.
             * The method retrieves the index of the selected monitor from cmbMonitors and saves the current wallpaper path for that monitor before setting the new wallpaper.
             * The WallpaperService is used to set the new wallpaper for the selected monitor, and lblStatus is updated to confirm that the wallpaper has been set.
             */

            int monitorIndex = cmbMonitors.SelectedIndex;

            //string imagePath = @"E:\BackGroundImage\10000x6000.jpg";
            if (string.IsNullOrEmpty(currentDownloadedImage))
            {
                MessageBox.Show("No image has been downloaded yet.");
                return;
            }

            string imagePath = currentDownloadedImage;

            previousWallpaperPath = WallpaperService.GetWallpaperForMonitor(monitorIndex);

            WallpaperService.SetWallpaperForMonitor(monitorIndex, imagePath);

            lblStatus.Text = $"Wallpaper set on Monitor {monitorIndex + 1}";
        }

        private void picPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnRestoreWallpaper_Click(object sender, EventArgs e)
        {
            /*             * When the "Restore Wallpaper" button is clicked, this event handler is triggered. It restores the previous wallpaper for the selected monitor.
             * The method retrieves the index of the selected monitor from cmbMonitors and checks if there is a saved path for the previous wallpaper. If there is no saved path or if the file does not exist, it updates lblStatus to indicate the issue.
             * If the previous wallpaper file exists, it uses the WallpaperService to set it as the wallpaper for the selected monitor and updates lblStatus to confirm that the previous wallpaper has been restored.
             */

            int monitorIndex = cmbMonitors.SelectedIndex;

            if (string.IsNullOrWhiteSpace(previousWallpaperPath))
            {
                lblStatus.Text = "No previous wallpaper saved.";
                return;
            }

            if (!File.Exists(previousWallpaperPath))
            {
                lblStatus.Text = "Previous wallpaper file was not found.";
                return;
            }

            WallpaperService.SetWallpaperForMonitor(monitorIndex, previousWallpaperPath);

            lblStatus.Text = $"Previous wallpaper restored on Monitor {monitorIndex + 1}";
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            /*             * When the MainForm is shown, this event handler is triggered. It initiates the process of downloading the latest image immediately upon the form being displayed.
             * The method is marked as async to allow for asynchronous operations, ensuring that the UI remains responsive during the download process.
             * After downloading the latest image, the refresh timer's interval is set based on the value specified in numRefreshMinutes, and the timer is started to enable automatic refreshing of the wallpaper at regular intervals.
             */
            await DownloadLatestImageAsync();

            refreshTimer.Interval =
            (int)numRefreshMinutes.Value * 60 * 1000;

            refreshTimer.Start();
            await LoadSourcePreviewsAsync();

        }

        private async void refreshTimer_Tick(object sender, EventArgs e)
        {
            /*             * This event handler is triggered each time the refresh timer ticks, which occurs at intervals defined by the numRefreshMinutes control. It initiates the process of downloading the latest image and setting it as the wallpaper for the selected monitor.
             * The method is marked as async to allow for asynchronous operations, ensuring that the UI remains responsive during the download process.
             * After downloading the latest image, it retrieves the index of the selected monitor from cmbMonitors and sets the downloaded image as the wallpaper for that monitor using the WallpaperService.
             */

            await DownloadLatestImageAsync();

            int monitorIndex = cmbMonitors.SelectedIndex;

            //string imagePath = @"E:\BackGroundImage\10000x6000.jpg";
            string imagePath = currentDownloadedImage;

            WallpaperService.SetWallpaperForMonitor(
                monitorIndex,
                imagePath);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            numRefreshMinutes.Value = appSettings.RefreshMinutes;

            if (appSettings.SelectedMonitorIndex >= 0 &&
                appSettings.SelectedMonitorIndex < cmbMonitors.Items.Count)
            {
                cmbMonitors.SelectedIndex = appSettings.SelectedMonitorIndex;
            }

            previousWallpaperPath = appSettings.PreviousWallpaperPath;
            appSettings.PreviousWallpaperPath = previousWallpaperPath;
        }

        private void lblLastDownloadedAgain_Click(object sender, EventArgs e)
        {

        }

        private readonly Dictionary<RadioButton, string> wallpaperSources = new();

        private void LoadWallpaperSources()
        {
            wallpaperSources.Clear();

            wallpaperSources.Add(rbGeoColor,
                "https://cdn.star.nesdis.noaa.gov/GOES19/ABI/SECTOR/sp/GEOCOLOR/1200x1200.jpg");

            wallpaperSources.Add(rbDust,
                "https://cdn.star.nesdis.noaa.gov/GOES19/ABI/SECTOR/sp/Dust/1200x1200.jpg");

            wallpaperSources.Add(rbConusGeoColor,
                "https://cdn.star.nesdis.noaa.gov/GOES19/ABI/CONUS/GEOCOLOR/10000x6000.jpg");

            wallpaperSources.Add(rbGulfAmerica,
                "https://cdn.star.nesdis.noaa.gov/GOES19/ABI/SECTOR/ga/GEOCOLOR/1000x1000.jpg");
        }

        private async Task LoadSourcePreviewsAsync()
        {
            await LoadPreviewAsync(
                wallpaperSources[rbGeoColor],
                pbGeoColor);

            await LoadPreviewAsync(
                wallpaperSources[rbDust],
                pbDust);

            await LoadPreviewAsync(
                wallpaperSources[rbConusGeoColor],
                pbConusGeoColor);

            await LoadPreviewAsync(
                wallpaperSources[rbGulfAmerica],
                pbGulfAmerica);
        }
        private async Task LoadPreviewAsync(string url, PictureBox pictureBox)
        {
            try
            {
                using HttpClient client = new HttpClient();

                byte[] bytes = await client.GetByteArrayAsync(url);

                using MemoryStream ms = new MemoryStream(bytes);

                pictureBox.Image = Image.FromStream(ms);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetSelectedWallpaperUrl()
        {
            foreach (var source in wallpaperSources)
            {
                if (source.Key.Checked)
                {
                    return source.Value;
                }
            }

            return wallpaperSources[rbGeoColor];
        }

        private void lblInfoIcon_Click(object sender, EventArgs e)
        {

        }

        private void WallpaperSource_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is not RadioButton selectedRadio || !selectedRadio.Checked)
                return;

            foreach (var source in wallpaperSources.Keys)
            {
                if (source != selectedRadio)
                {
                    source.Checked = false;
                }
            }
            UpdateSelectedCard();

            _ = DownloadLatestImageAsync();
        }

        private void lblNoaaCredit_Click(object sender, EventArgs e)
        {

        }
        private void FormatPictureBoxes()
        {
            pbGeoColor.Size = new Size(160, 160);
            pbDust.Size = new Size(160, 160);
            pbConusGeoColor.Size = new Size(220, 132);
            pbGulfAmerica.Size = new Size(160, 160);

            pbGeoColor.SizeMode = PictureBoxSizeMode.Zoom;
            pbDust.SizeMode = PictureBoxSizeMode.Zoom;
            pbConusGeoColor.SizeMode = PictureBoxSizeMode.Zoom;
            pbGulfAmerica.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void UpdateSelectedCard()
        {
            Color selectedBorder = Color.FromArgb(240, 246, 255);
            Color normalBorder = Color.LightGray;
            Color selectedColor = Color.FromArgb(180, 210, 250);
            Color normalColor = SystemColors.Control;

            pnlGeoColor.BackColor =
                rbGeoColor.Checked ? selectedColor : normalColor;

            pnlGeoColor.BackColor =
                rbGeoColor.Checked ? selectedBorder : normalBorder;

            pnlDust.BackColor =
                rbDust.Checked ? selectedBorder : normalBorder;

            pnlConus.BackColor =
                rbConusGeoColor.Checked ? selectedBorder : normalBorder;

            pnlGulf.BackColor =
                rbGulfAmerica.Checked ? selectedBorder : normalBorder;

            ;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}
