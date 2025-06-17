using SberQ.Assets.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Extensions.DependencyInjection;
using SberQ.ViewModel;

namespace SberQ
{
    public partial class Page3 : Page
    {
        public Page3(string answer)
        {
            InitializeComponent();
            var frame = ((MainWindow)Application.Current.MainWindow).toPage1;
            DataContext = new Page3VM(answer, frame);
        }

        private void TextChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(toEmail1.Text))
            {
                CanvasText_Email.Visibility = Visibility.Visible;
            }
            else
            {
                CanvasText_Email.Visibility = Visibility.Collapsed;
            }
        }
    }
}