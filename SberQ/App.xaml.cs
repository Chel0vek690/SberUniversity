using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace SberQ
{

    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider1 { get; private set; }

        public App()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ISendMessage, Email>();
            services.AddSingleton<IData, ReadJson>();
            services.AddTransient<MainWindow>();

            ServiceProvider1 = services?.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainWindow = ServiceProvider1?.GetRequiredService<MainWindow>();
            mainWindow?.Show();
        }
    }
}
