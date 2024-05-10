namespace Pure_Harmony_App.Pages.PatientPages;

public partial class PatientLandingPage : ContentPage
{
	public PatientLandingPage()
	{
		InitializeComponent();
	}
    private void OnLoginClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PatientLogin());
    }

    private void OnSignUpClicked(object sender, EventArgs en)
    {
        Navigation.PushAsync(new SignUpPageOfPatient());
    }
}