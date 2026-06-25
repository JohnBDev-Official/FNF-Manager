using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FNF_Manager.Models;
using FNF_Manager.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FNF_Manager.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        private readonly SettingsService _settingsService;

        [ObservableProperty]
        private string baseGameDir = "";

        [ObservableProperty]
        private string modsDir = "";

        [ObservableProperty]
        private string savesDir = "";

        [ObservableProperty]
        private string coversDir = "";

        [ObservableProperty]
        private bool checkForUpdatesOnStartup = true;

        public SettingsViewModel()
        {
            _settingsService = new SettingsService();
        }

        public async Task LoadSettingsAsync()
        {
            Settings settings = await _settingsService.LoadAsync();

            BaseGameDir = settings.BaseGameDir;
            ModsDir = settings.ModsDir;
            SavesDir = settings.SavesDir;
            CoversDir = settings.CoversDir;
            CheckForUpdatesOnStartup = settings.CheckForUpdatesOnStartup;
        }

        [RelayCommand]
        private async Task SaveSettingsAsync()
        {
            Settings settings = new Settings
            {
                BaseGameDir = BaseGameDir,
                ModsDir = ModsDir,
                SavesDir = SavesDir,
                CoversDir = CoversDir,
                CheckForUpdatesOnStartup = CheckForUpdatesOnStartup
            };

            await _settingsService.SaveAsync(settings);
        }
    }
}
