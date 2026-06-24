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
            CurrentPage = new BaseGameViewModel();
        }

        [RelayCommand]
        public void ShowSettingsCommand()
        {
            CurrentPage = new SettingsViewModel();
        }

        //partial void OnIsDarkModeChanged(bool value)
        //{
        //    if (Application.Current is { } app)
        //    {
        //        app.RequestedThemeVariant = value ? ThemeVariant.Dark : ThemeVariant.Light;
        //    }
        //}
    }
}
