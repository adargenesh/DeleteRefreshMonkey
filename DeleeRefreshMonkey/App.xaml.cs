using DeleeRefreshMonkey.Views;

namespace DeleeRefreshMonkey
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}