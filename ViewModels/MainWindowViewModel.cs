using Avalonia;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FNF_Manager.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isDarkMode;

        partial void OnIsDarkModeChanged(bool value)
        {
            if (Application.Current is { } app)
            {
                app.RequestedThemeVariant = value ? ThemeVariant.Dark : ThemeVariant.Light;
            }
        }
    }
}
