using SberQ.ViewModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SberQ
{
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
                toPage1.Navigate(new Page1());
                ImageBrush brush = new()
                {
                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/SberQ;component/Assets/Images/background.png"))
                };
                    this.Background = brush;
            }
        }
}