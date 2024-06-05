using System.ComponentModel;
using System.Windows.Input;
using Pure_Harmony_App.Models;
using Pure_Harmony_App.Service;

namespace Pure_Harmony_App.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private readonly Localdatabase _database;
        private User _currentUser;

        
        private string _Name;
        private string _email;
        private string _phoneNumber;
        private string _specialty;
        private string _gender;
        private string _physicalAddress;
        private DateTime _dateOfBirth;

        

        public string Name
        {
            get => Name;
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Specialty
        {
            get => _specialty;
            set
            {
                _specialty = value;
                OnPropertyChanged(nameof(Specialty));
            }
        }

        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        public string PhysicalAddress
        {
            get => _physicalAddress;
            set
            {
                _physicalAddress = value;
                OnPropertyChanged(nameof(PhysicalAddress));
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged(nameof(DateOfBirth));
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand SignUpCommand { get; }

        public ProfileViewModel()
        {
            _database = new Localdatabase();
            SaveCommand = new Command(OnSave);
            SignUpCommand = new Command(OnSignUp);

            // For this example, we assume the current user is already known and fetched by email.
            LoadProfileData("doctor@example.com"); // replace with actual logged-in user's email
        }

        private void LoadProfileData(string email)
        {
            _currentUser = _database.GetUserByEmail(email);
            if (_currentUser != null)
            {
                
                Name = _currentUser.Name;
                Email = _currentUser.Email;
                PhoneNumber = _currentUser.PhoneNumber;
                Specialty = _currentUser.Specialty;
                Gender = _currentUser.Gender;
                PhysicalAddress = _currentUser.PhysicalAddress;
                DateOfBirth = _currentUser.DateOfBirth;
            }
        }

        private void OnSave()
        {
            if (_currentUser != null)
            {
                
                _currentUser.Name = Name;
                _currentUser.Email = Email;
                _currentUser.PhoneNumber = PhoneNumber;
                _currentUser.Specialty = Specialty;
                _currentUser.Gender = Gender;
                _currentUser.PhysicalAddress = PhysicalAddress;
                _currentUser.DateOfBirth = DateOfBirth;

                _database.UpdateUser(_currentUser);

                Application.Current.MainPage.DisplayAlert("Success", "Profile saved successfully", "OK");
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Failed to save profile", "OK");
            }
        }

        private void OnSignUp()
        {
            var newUser = new User
            {
               
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Specialty = Specialty,
                Gender = Gender,
                PhysicalAddress = PhysicalAddress,
                DateOfBirth = DateOfBirth
            };

            _database.InsertUser(newUser);

            Application.Current.MainPage.DisplayAlert("Success", "Signup successful", "OK");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

