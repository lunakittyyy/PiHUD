namespace PiHUD.Core;

public class SettingsHelper
{
    public string LoadSettings(string fileName)
    {
        CreateFileIfNotExists(fileName);
        var SettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"PiHUD/{fileName}.json");
        return File.ReadAllText(SettingsPath);
    }

    public void SaveSettings(string fileName, string content)
    {
        CreateFileIfNotExists(fileName);
        var SettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"PiHUD/{fileName}.json");
        File.WriteAllText(SettingsPath, content);
    }

    public void CreateFileIfNotExists(string fileName)
    {
        if (!Path.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "PiHUD")))
        {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PiHUD"));
        }
        var SettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"PiHUD/{fileName}.json");
        if (!File.Exists(SettingsPath)) File.Create(SettingsPath).Close();
    }
}