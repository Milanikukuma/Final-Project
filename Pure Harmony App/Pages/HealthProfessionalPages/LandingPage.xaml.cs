namespace Pure_Harmony_App.Pages.HealthProfessionalPages;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}
    private void OnLoginClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }

    private void OnSignUpClicked(object sender, EventArgs en)
    {
        Navigation.PushAsync(new SignUpPageOfHealthProfessional());
    }
}