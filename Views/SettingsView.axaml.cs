using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FNF_Manager.ViewModels;

namespace FNF_Manager.Views;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();

        SettingsViewModel vm = new SettingsViewModel();
        DataContext = vm;

        _ = vm.LoadSettingsAsync();
    }
}