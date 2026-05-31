using System.Runtime.InteropServices;

namespace RefreshBackGroundV3.Services;

public static class WallpaperService
{
    public static void SetWallpaperForMonitor(int monitorIndex, string imagePath)
    {
        /*
         * This method is responsible for setting the wallpaper for a specific monitor. It takes the index of the monitor and the path to the wallpaper image as parameters.
         * The method first checks if the specified image file exists. If it does not, it throws a FileNotFoundException.
         * It then creates an instance of the IDesktopWallpaper interface, which provides methods for managing desktop wallpapers.
         * The method retrieves the total number of monitors and checks if the specified monitor index is valid. If it is not, it throws an exception.
         * Finally, it retrieves the monitor ID for the specified monitor index and sets the wallpaper for that monitor using the SetWallpaper method of the IDesktopWallpaper interface.
         */

        if (!File.Exists(imagePath))
        {
            throw new FileNotFoundException("Wallpaper image was not found.", imagePath);
        }

        IDesktopWallpaper wallpaper =
            (IDesktopWallpaper)new DesktopWallpaperClass();

        uint monitorCount = wallpaper.GetMonitorDevicePathCount();

        if (monitorIndex < 0 || monitorIndex >= monitorCount)
        {
            throw new Exception("Selected monitor was not found.");
        }

        string monitorId = wallpaper.GetMonitorDevicePathAt((uint)monitorIndex);

        wallpaper.SetWallpaper(monitorId, imagePath);
    }

    public static string GetWallpaperForMonitor(int monitorIndex)
    {
        /*
         * This method retrieves the current wallpaper path for a specific monitor. It takes the index of the monitor as a parameter.
         * The method creates an instance of the IDesktopWallpaper interface and retrieves the total number of monitors.
         * It checks if the specified monitor index is valid, and if it is not, it throws an exception.
         * Finally, it retrieves the monitor ID for the specified monitor index and returns the current wallpaper path for that monitor using the GetWallpaper method of the IDesktopWallpaper interface.
         */

        IDesktopWallpaper wallpaper =
            (IDesktopWallpaper)new DesktopWallpaperClass();

        uint monitorCount = wallpaper.GetMonitorDevicePathCount();

        if (monitorIndex < 0 || monitorIndex >= monitorCount)
        {
            throw new Exception("Selected monitor was not found.");
        }

        string monitorId = wallpaper.GetMonitorDevicePathAt((uint)monitorIndex);

        return wallpaper.GetWallpaper(monitorId);
    }



}


[ComImport]
[Guid("C2CF3110-460E-4FC1-B9D0-8A1C0C9CC4BD")]
public class DesktopWallpaperClass
{
}

[ComImport]
[Guid("B92B56A9-8B55-4E14-9A89-0199BBB6F93B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IDesktopWallpaper
{
    void SetWallpaper(
        [MarshalAs(UnmanagedType.LPWStr)] string monitorID,
        [MarshalAs(UnmanagedType.LPWStr)] string wallpaper);

    [return: MarshalAs(UnmanagedType.LPWStr)]
    string GetWallpaper(
        [MarshalAs(UnmanagedType.LPWStr)] string monitorID);

    [return: MarshalAs(UnmanagedType.LPWStr)]
    string GetMonitorDevicePathAt(uint monitorIndex);

    uint GetMonitorDevicePathCount();
}
