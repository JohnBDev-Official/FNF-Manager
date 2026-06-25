using Avalonia;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace FNF_Manager.ViewModels
{
    public partial class BaseGameViewModel : ViewModelBase
    {
        [ObservableProperty]
        private IBrush difficultyTextColor = new SolidColorBrush(Color.Parse("#2fdd29"));
        [ObservableProperty]
        private String difficultyText = "New (V-Slice)";
        [ObservableProperty]
        private Thickness arrowMargin = new Thickness(0,0,340,98);

        private IBrush newTextColor { get; } = new SolidColorBrush(Color.Parse("#2fdd29"));
        private IBrush oldTextColor { get; } = new SolidColorBrush(Color.Parse("#f1f232"));

        private Thickness newTextArrowMargin { get; } = new Thickness(0,0,340,98);
        private Thickness oldTextArrowMargin { get; } = new Thickness(0,0,405,98);

        private int difficultyValue = 1;

        [RelayCommand]
        public void changeDifficultyText()
        {
            if (difficultyValue == 1)
            {
                difficultyValue++;
                DifficultyTextColor = oldTextColor;
                ArrowMargin = oldTextArrowMargin;
                DifficultyText = "Old (Pre V-Slice)";
            }
            else if (difficultyValue == 2)
            {
                difficultyValue--;
                DifficultyTextColor = newTextColor;
                ArrowMargin = newTextArrowMargin;
                DifficultyText = "New (V-Slice)";
            }
        }
    }
}
