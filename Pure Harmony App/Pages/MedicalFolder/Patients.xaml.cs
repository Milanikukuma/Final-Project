namespace Pure_Harmony_App.Pages;

public partial class Patients : ContentPage
{
	public Patients()
	{
		InitializeComponent();
	}
    private async void OnPatientSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedPatient = e.SelectedItem as Patients;
        if (selectedPatient != null)
        {
            await Navigation.PushAsync(new PatientProfilePage(selectedPatient));
        }

            ((ListView)sender).SelectedItem = null; // Deselect item
    }
}