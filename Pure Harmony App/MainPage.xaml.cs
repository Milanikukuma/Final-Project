
using Pure_Harmony_App.Pages.HealthProfessionalPages;
using Pure_Harmony_App.Pages.PatientPages;

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
            Navigation.PushAsync(new PatientLandingPage());
        }

        private void OnHealthProfessionalClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LandingPage());
        }
    }


}


