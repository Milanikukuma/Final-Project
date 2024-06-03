using Pure_Harmony_App.Service;
using Pure_Harmony_App.ViewModels;

namespace Pure_Harmony_App.Pages;

public partial class PatientHomePage : ContentPage
{
    private Localdatabase _localdatabase;

    private PatientViewModel _patientViewModel;

    public PatientViewModel PatientViewModel
    {
        get { return _patientViewModel; }
        set
        {
            _patientViewModel = value;
            OnPropertyChanged();
        }
    }
    public PatientHomePage(Localdatabase database)
    {
        InitializeComponent();

        //  _patientService = patientService;

        //   PatientViewModel = new PatientViewModel(_patientService);

        BindingContext = this;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await LoadData();
    }

    private async void ReloadButton_Clicked(object sender, EventArgs e)
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        try
        {
            // Load patient data here
            // Example:
            // var patient = await _patientService.GetPatientById(1);
            // PatientViewModel.Patient = patient;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Cancel");
        }
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Save patient data here
            // Example:
            // await _patientService.UpdatePatient(PatientViewModel.Patient);

            await DisplayAlert("Success", "Patient Saved", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Cancel");
        }
    }

    private void OneNameButton_Clicked(object sender, EventArgs e)
    {

    }

    private void MedRemindersButton_Clicked(object sender, EventArgs e)
    {

    }

    private void AlertsButton_Clicked(object sender, EventArgs e)
    {

    }

    private void EducationalResourcesButton_Clicked(object sender, EventArgs e)
    {

    }
}
