using AppListaCompras.Maui.Views;

namespace AppListaCompras.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = (VersionTracking.IsFirstLaunchEver) ? new FirstPage() : MainPage = new AppShell();
        }
    }
}
