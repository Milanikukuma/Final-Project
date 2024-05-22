










using Pure_Harmony_App.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pure_Harmony_App.ViewModels
{
    public class PatientViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Patient> _patients;

        public ObservableCollection<Patient> Patients
        {
            get { return _patients; }
            set
            {
                _patients = value;
                OnPropertyChanged();
            }
        }

        public PatientViewModel()
        {
            // Initialize the collection of patients
            Patients = new ObservableCollection<Patient>();
            // You can add sample patients here, or retrieve them from a database
            // For example:
            // Patients.Add(new Patient { FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1990, 5, 10), Gender = Gender.Male, Email = "john@example.com", PhoneNumber = "1234567890", Address = "123 Street" });
            // Patients.Add(new Patient { FirstName = "Jane", LastName = "Doe", DateOfBirth = new DateTime(1995, 8, 20), Gender = Gender.Female, Email = "jane@example.com", PhoneNumber = "9876543210", Address = "456 Avenue" });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}