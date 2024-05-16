using Pure_Harmony_App.Models;
using System.Collections.ObjectModel;
using Pure_Harmony_App.Service;

namespace Pure_Harmony_App.ViewModels
{
    public partial class PatientViewModel : BaseViewModel
    {
        private Localdatabase _database;

        private Patient _currentPatient;
        public Patient CurrentPatient
        {
            get { return _currentPatient; }
            set
            {
                _currentPatient = value;
                OnPropertyChanged();
            }
        }

       

        public PatientViewModel()
        {
            _database = new Localdatabase();
            LoadData();
        }

        private void LoadData()
        {
            // Assuming patient ID 1 for demonstration
            Patient patient = _database.GetPatientById(1);
            CurrentPatient = patient;
            
        }

        public void ReloadData()
        {
            LoadData();
        }

        public void SavePatient()
        {
            _database.UpdatePatient(CurrentPatient);
        }
    }
}
