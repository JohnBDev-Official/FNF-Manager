using Avalonia;
using FNF_Manager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FNF_Manager.Services
{
    public class SettingsService
    {
        private readonly string _settingsFilePath;
        private readonly string _settingsFileName = "settings.json";

        public SettingsService()
        {
            string appDataDir = GetAppDataDirectory();
            Directory.CreateDirectory(appDataDir);
            _settingsFilePath = Path.Combine(appDataDir, _settingsFileName);
        }

        public async Task<Settings> LoadAsync()
        {
            if (!File.Exists(_settingsFilePath))
                return new Settings();

            try
            {
                string json = await File.ReadAllTextAsync(_settingsFilePath);
                Settings? settings = JsonSerializer.Deserialize<Settings>(json);
                return settings ?? new Settings();
            }
            catch
            {
                return new Settings();
            }
        }

        public async Task SaveAsync(Settings settings)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(settings, options);
            await File.WriteAllTextAsync(_settingsFilePath, json);
        }

        private static string GetAppDataDirectory()
        {
            string baseDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (string.IsNullOrWhiteSpace(baseDir))
                throw new InvalidOperationException("Application data folder is missing.");

            string appName = Application.Current?.Resources["AppName"] as string ?? "FNF Manager";

            return Path.Combine(baseDir, appName);
        }
    }
}
