using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Pages.HealthProfessionalPages;

namespace Pure_Harmony_App
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPatientClicked(object sender, EventArgs e)
        {
           
        }

        private void OnHealthProfessionalClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LandingPage());
        }
    }


}


