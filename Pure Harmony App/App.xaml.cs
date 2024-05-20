using Pure_Harmony_App.Views.Template;

namespace Pure_Harmony_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginView());

            MainPage = new AppShell();
        }

        
    }
}
