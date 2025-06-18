using SberQ.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Navigation;

namespace SberQ
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            var frame = ((MainWindow)Application.Current.MainWindow).toPage1;
            DataContext = new Page2VM(frame);
        }
    }
}
