namespace Pure_Harmony_App.Pages.PatientFolder;

public partial class MedicationStrength : ContentPage
{
	public MedicationStrength()
	{
		InitializeComponent();
	}

    private void OnUnitButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            string unit = button.Text;
            // Handle unit selection, possibly store the selected unit
            DisplayAlert("Unit Selected", $"You selected: {unit}", "OK");
        }
    }

    private void OnNextButtonClicked(object sender, EventArgs e)
    {
        // Handle next button click, possibly navigate to the next page
        string strength = StrengthEntry.Text;
        string frequency = FrequencyEntry.Text;
        TimeSpan time = TimePicker.Time;

        DisplayAlert("Medication Info", $"Strength: {strength}\nFrequency: {frequency}\nTime: {time}", "OK");
    }

    private string selectedUnit; // to store the selected unit

    // Additional methods to handle other events can be added here

}

