using SberQ.Assets.Text;
using SberQ.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SberQ
{
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            var frame = ((MainWindow)Application.Current.MainWindow).toPage1;
            DataContext = new Page4VM(frame);
        }

        //private void ReturnToMainPage(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Page1());
        //}
    }
}
