using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;

namespace SberQ.ViewModel
{
    public partial class Page1VM : ObservableObject
    {
        private readonly Frame frame;
        public Page1VM(Frame frame)
        {
            this.frame = frame;
        }

        [RelayCommand]
        private void NavigateToPage2()
        {
            frame.Navigate(new Page2());
        }
    }
}