using RefreshBackGround;

internal static class Program { 

    static void Main(string[] args)
    {
        MessageBox.Show("Main Method");
        Items items = new Items();
        items.Show();
        StartService();

    }
    private static void StartService()
    {
    HostApplicationBuilder builder = Host.CreateApplicationBuilder();

    builder.Services.AddHostedService<TimerService>();

    IHost host = builder.Build();
    host.Run();

    }

    


}
 