//using RefreshBackGround;


//HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

//builder.Services.AddHostedService<TimerService>();

//IHost host = builder.Build();
//host.Run();

using System;
using System.Windows.Forms;

namespace RefreshBackGround
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Items());
        }
    }
}