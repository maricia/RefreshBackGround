namespace RefreshBackGround
{
    public class TimerService : IHostedService, IAsyncDisposable
    {
        private readonly Task _completedTask = Task.CompletedTask;
        private readonly ILogger<TimerService> _logger;
        private int _executionCount = 0;
        private System.Threading.Timer? _timer;
        private string myPath = @"C:\BackGroundImage\latest.jpg";//10000x6000.jpg
        //private readonly string myFilename = @"C:\BackGroundImage";
        private readonly HttpClient client = new HttpClient();
        private string url = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/latest.jpg";//10000x6000
        public bool state = true;
        public string simage = "ContinentalUS";
        double howlong = 300;
        //int count=0;

        public TimerService(ILogger<TimerService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("{Service} is running at: {time}.", nameof(RefreshBackGround), DateTimeOffset.Now);
            _timer = new System.Threading.Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(howlong));//300
            return _completedTask;
        }
        private void DoWork(object? state)
        {
            ImageDownloader.DownloadImage(url);
            Wallpaper.Set(myPath);
            int count = Interlocked.Increment(ref _executionCount);
            _logger.LogInformation(
                "{Service} is working at {time} , execution count: {Count:#,0}", nameof(RefreshBackGround), DateTimeOffset.Now, count);
            MessageBox.Show("Dowork end");
        }

        private void CheckForIllegalCrossThreadCalls()
        {
            _logger.LogInformation("CheckForIllegalCrossThreadCalls");
           //throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
            "{Service} is stopping at {time}.", nameof(RefreshBackGround), DateTimeOffset.Now);
            _timer?.Change(Timeout.Infinite, 0);
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