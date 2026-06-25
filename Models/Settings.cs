using Avalonia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FNF_Manager.Models
{
    public class Settings
    {
        private static string GetAppDataDirectory()
        {
            string baseDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (string.IsNullOrWhiteSpace(baseDir))
                throw new InvalidOperationException("Application data folder is missing.");

            string appName = Application.Current?.Resources["AppName"] as string ?? "FNF Manager";

            return Path.Combine(baseDir, appName);
        }
        private static string _appDataDir = GetAppDataDirectory();

        /// <summary>
        /// Where to store FNF base game
        /// </summary>
        public string BaseGameDir { get; set; } = Path.Combine(_appDataDir, "BaseGameInstall");
        /// <summary>
        /// Where to store FNF mods
        /// </summary>
        public string ModsDir { get; set; } = Path.Combine(_appDataDir, "Mods");
        /// <summary>
        /// Where to store FNF save files
        /// </summary>
        public string SavesDir { get; set; } = Path.Combine(_appDataDir, "Saves");
        /// <summary>
        /// Where to store FNF covers.
        /// </summary>
        public string CoversDir { get; set; } = Path.Combine(_appDataDir, "Covers");
        /// <summary>
        /// If FNF Manager should check for updates on startup
        /// </summary>
        public bool CheckForUpdatesOnStartup { get; set; } = true;
    }
}
