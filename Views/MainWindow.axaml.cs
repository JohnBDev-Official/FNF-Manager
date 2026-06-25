using Avalonia.Controls;
using System.Diagnostics;

namespace FNF_Manager.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Opened += (_, _) =>
            {
                Debug.WriteLine($"Window Bounds: {Bounds.Width} x {Bounds.Height}");
                Debug.WriteLine($"ClientSize: {ClientSize.Width} x {ClientSize.Height}");
                Debug.WriteLine($"RenderScaling: {RenderScaling}");
            };
        }
    }
}