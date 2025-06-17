using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SberQ.ViewModel
{
    public partial class Page4VM : ObservableObject
    {
        private readonly Frame frame;
        public Page4VM(Frame frame) 
        {
            this.frame = frame;
        }

        [RelayCommand]
        private void NavigateStart()
        {
            frame.Navigate(new Page1());
        }

    }
}
