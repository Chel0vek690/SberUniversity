using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace SberQ.ViewModel
{
    public partial class MainWindowVM: ObservableObject
    {
        IServiceProvider ServiceProvider;
        [ObservableProperty]
        private ImageBrush backgroundBrush;
        public MainWindowVM(IServiceProvider ServiceProvider)
        {
            this.ServiceProvider = ServiceProvider;
        }
    }
}