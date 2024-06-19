using Pure_Harmony_App.Pages.PatientFolder;

namespace Pure_Harmony_App.Pages;

public partial class MedicationPage : ContentPage
{
	public MedicationPage()
	{
		InitializeComponent();
	}

    private async void Next_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MedicationStrength());
    }
}