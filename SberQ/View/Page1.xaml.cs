using SberQ.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SberQ
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            var frame = ((MainWindow)Application.Current.MainWindow).toPage1;
            DataContext = new Page1VM(frame);
        }
    }
}
