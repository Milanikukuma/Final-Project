using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Pages.MedicalFolder;

namespace Pure_Harmony_App.Views.Template;

public partial class MedicalHomeView : ContentPage
{
	public MedicalHomeView()
	{
		InitializeComponent();
	}

    private void PatientsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Patients());
    }

    

    private void AlertsButton_Clicked(object sender, EventArgs e)
    {

    }

    private void OnProfileButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfilePage());
    }

    private void AboutUsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AboutUs());

    }


    async void OnVistWebsiteClicked(object sender, EventArgs e)
    {
        string websiteURI = "https://pubmed.ncbi.nlm.nih.gov/";


        await Launcher. OpenAsync(websiteURI);
    }

    async void OnVisttheWebsiteClicked(object sender, EventArgs e)
    {
        string websiteURI = "https://www.cdc.gov/tb/default.htm";
        

        await Launcher.OpenAsync(websiteURI);
    }

    async void OnVistaWebsiteClicked(object sender, EventArgs e)
    {
        string websiteURI = "https://www.who.int/health-topics/tuberculosis#tab=tab_1";

        await Launcher.OpenAsync(websiteURI);
    }
}