using Avalonia;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FNF_Manager.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isDarkMode;

        [ObservableProperty]
        public ViewModelBase currentPage = new BaseGameViewModel();

        [RelayCommand]
        public void ShowBaseGameCommand()
        {
            if (CurrentPage is not BaseGameViewModel)
                CurrentPage = new BaseGameViewModel();
        }

        [RelayCommand]
        public void ShowModsCommand()
        {
            if (CurrentPage is not ModsViewModel)
                CurrentPage = new ModsViewModel();
        }

        [RelayCommand]
        public void ShowSettingsCommand()
        {
            if (CurrentPage is not SettingsViewModel)
                CurrentPage = new SettingsViewModel();
        }
        
        [RelayCommand]
        public void ShowAboutCommand()
        {
            if (CurrentPage is not AboutViewModel)
                CurrentPage = new AboutViewModel();
        }
        
        // Changing between the dark and light mode was abandoned very early, I wanted to build a UI that reminds you of FNF. -JohnB
        //
        //partial void OnIsDarkModeChanged(bool value)
        //{
        //    if (Application.Current is { } app)
        //    {
        //        app.RequestedThemeVariant = value ? ThemeVariant.Dark : ThemeVariant.Light;
        //    }
        //}
    }
}
