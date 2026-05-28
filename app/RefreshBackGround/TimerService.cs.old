
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace RefreshBackGround
{
    public class TimerService : IHostedService, IAsyncDisposable
    {
        private readonly Task _completedTask = Task.CompletedTask;
        private readonly ILogger<TimerService> _logger;
        private int _executionCount = 0;
        private System.Threading.Timer? _timer;
        private readonly string myPath = @"C:\BackGroundImage\10000x6000.jpg";
        private readonly string myFilename = @"C:\BackGroundImage";
        private readonly HttpClient client = new HttpClient();
        private string url = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/10000x6000.jpg";
        Items frm = new Items();
        public bool state = true;


        public TimerService(ILogger<TimerService> logger)
        {
            _logger = logger;
            //frm.ShowDialog();
            
        }
        
        public void nIcon_DoubleClick(object? sender, EventArgs e)
        {
            frm.ShowDialog();
            /*
            if (state)
            {
                frm.Visible = true;
                //this.Show();
                frm.WindowState = FormWindowState.Normal;
                state = false;
            }
            else
            {
                frm.Visible = false;
                frm.WindowState = FormWindowState.Minimized;
                state = true;
            }
          */
        }

        private void fillinlabels()
        {
            //refresh form
            frm.lastwritetimelbl.Text = File.GetLastWriteTime(myPath).ToString();
            frm.idldlbl.Text = myPath;
            //frm.URLlbl.Text = imageLocation;

        }
       



        public Task StartAsync(CancellationToken stoppingToken)
        {  
            
            _logger.LogInformation("{Service} is running at: {time}.", nameof(RefreshBackGround),DateTimeOffset.Now);
            _timer = new System.Threading.Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(300));
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Minimized;
            return _completedTask;
        }
        private void DoWork(object? state)
        {
            ImageDownloader.DownloadImage(url);
            Wallpaper.Set(myPath);
            fillinlabels();
            int count = Interlocked.Increment(ref _executionCount);
            _logger.LogInformation(
                "{Service} is working at {time} , execution count: {Count:#,0}",
                nameof(RefreshBackGround), DateTimeOffset.Now, count);
                
        }
        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
            "{Service} is stopping at {time}.", nameof(RefreshBackGround),DateTimeOffset.Now);
            _timer?.Change(Timeout.Infinite, 0);
            frm.Close();
            return _completedTask;
        }
        
        public async ValueTask DisposeAsync()
        {
            if (_timer is IAsyncDisposable timer)
            {
                await timer.DisposeAsync();
                
            }

            _timer = null;

        }
        /*
        Task IHostedService.StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("{Service} is running at: {time}.", nameof(RefreshBackGround), DateTimeOffset.Now);
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(300));

            return _completedTask;
        }
        */
        
    }
}