using Pure_Harmony_App.Views.Template;

namespace Pure_Harmony_App.Pages;

public partial class PatientSignupPage : ContentPage
{
	public PatientSignupPage()
	{
		InitializeComponent();
	}

    private async void SignUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PatientHomeView());
    }
}