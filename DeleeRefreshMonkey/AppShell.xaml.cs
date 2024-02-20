using DeleeRefreshMonkey.Views;

namespace DeleeRefreshMonkey
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        void RegisterRoutes()
        {
            Routing.RegisterRoute("monkeytDetails", typeof(MonkeyDetailsViewView));

        }


    }
}