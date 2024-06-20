using Pure_Harmony_App.Pages;

namespace Pure_Harmony_App.Views.Template;

public partial class MedicalHomeView : ContentPage
{
	public MedicalHomeView()
	{
		InitializeComponent();
	}

    private async void PatientsButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("patients");
    }

    

    private async void AlertsButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("alerts");
    }

    private  async void OnProfileButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("profilepage");
    }

    private async void AboutUsButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("aboutus");

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