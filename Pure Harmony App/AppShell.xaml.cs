using Pure_Harmony_App.Views;
using Pure_Harmony_App.Views.Template;

namespace Pure_Harmony_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        public void RegisterRoutes()
        {
            Routing.RegisterRoute("loginview", typeof(LoginView));
            Routing.RegisterRoute("patienthomeview", typeof(PatientHomeView));
        }

    }
}
