using Pure_Harmony_App.Pages;

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

    private void TreatmentPlansButton_Clicked(object sender, EventArgs e)
    {

    }

    private void AlertsButton_Clicked(object sender, EventArgs e)
    {

    }

    private void OnProfileButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfilePage());
    }
}