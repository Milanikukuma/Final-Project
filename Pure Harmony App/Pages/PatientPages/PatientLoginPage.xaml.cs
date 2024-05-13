namespace Pure_Harmony_App.Pages.PatientPages;

public partial class PatientLoginPage : ContentPage
{
	public PatientLoginPage()
	{
		InitializeComponent();
	}

    private void OnLoginClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new());
    }
}