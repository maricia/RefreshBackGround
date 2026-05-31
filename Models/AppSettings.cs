namespace RefreshBackGroundV3;

public class AppSettings
{
    public int SelectedMonitorIndex { get; set; } = 0;
    public int RefreshMinutes { get; set; } = 5;
    public string? PreviousWallpaperPath { get; set; }
}