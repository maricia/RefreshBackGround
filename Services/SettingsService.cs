using System.Text.Json;

namespace RefreshBackGroundV3;

public static class SettingsService
{
    private static readonly string settingsFolder =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "RefreshBackGroundV3");

    private static readonly string settingsPath =
        Path.Combine(settingsFolder, "settings.json");

    public static void Save(AppSettings settings)
    {
        Directory.CreateDirectory(settingsFolder);

        string json = JsonSerializer.Serialize(
            settings,
            new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(settingsPath, json);
    }

    public static AppSettings Load()
    {
        if (!File.Exists(settingsPath))
        {
            return new AppSettings();
        }

        string json = File.ReadAllText(settingsPath);

        return JsonSerializer.Deserialize<AppSettings>(json)
            ?? new AppSettings();
    }
}