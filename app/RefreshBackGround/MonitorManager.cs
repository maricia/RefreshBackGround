using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RefreshBackGround
{
    public class MonitorInfo
    {
        public string DeviceName { get; set; } = string.Empty;
        public int MonitorNumber { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsPrimary { get; set; }
        public string Orientation { get; set; } = string.Empty;
    }

    public static class MonitorManager
    {
        public static List<MonitorInfo> GetMonitors()
        {
            List<MonitorInfo> monitors = new List<MonitorInfo>();

            Screen[] screens = Screen.AllScreens;

            for (int i = 0; i < screens.Length; i++)
            {
                Screen screen = screens[i];

                int width = screen.Bounds.Width;
                int height = screen.Bounds.Height;

                string orientation = width >= height
                    ? "Landscape"
                    : "Portrait";

                monitors.Add(new MonitorInfo
                {
                    MonitorNumber = i + 1,
                    DeviceName = screen.DeviceName,
                    Width = width,
                    Height = height,
                    IsPrimary = screen.Primary,
                    Orientation = orientation
                });
            }

            return monitors;
        }
    }
}