using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Pages.PatientFolder;
using Pure_Harmony_App.Service;
using Pure_Harmony_App.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace Pure_Harmony_App.Views
{
    public partial class PatientHomeView : ContentPage
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

        public PatientHomeView()
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

       

        private void MedRemindersButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Reminders());
        }

        private void AlertsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Alerts());
        }

        

        private async void MedicationButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MedicationPage());
        }

        private void AboutUsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutUs());
        }
    }
}
