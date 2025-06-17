using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;

namespace SberQ.ViewModel
{
    public partial class Page2VM : ObservableObject
    {

        private readonly Frame frame;

        [ObservableProperty]
        private int sliderValue1;

        [ObservableProperty]
        private int sliderValue2;

        [ObservableProperty]
        private int sliderValue3;

        [ObservableProperty]
        private int sliderValue4;

        [ObservableProperty]
        private int sliderValue5;

        public Page2VM(Frame frame)
        {
            this.frame = frame;
        }

        [RelayCommand]
        private void NavigateToPage3()
        {
            int sum = SliderValue1 + SliderValue2 + SliderValue3 + SliderValue4 + SliderValue5;
            string answer = sum.ToString();
            frame.Navigate(new Page3(answer));
        }

        [RelayCommand]
        private void ReturnToPage1()
        {
            frame.Navigate(new Page1());
        }
    }
}
