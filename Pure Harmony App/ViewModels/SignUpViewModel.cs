using Microsoft.Maui;
using Pure_Harmony_App.Models;
using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Service;
using Pure_Harmony_App.Views;
using Pure_Harmony_App.Views.Template;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Pure_Harmony_App.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        private readonly Localdatabase _localdatabase;
        private readonly List<UserType> _userTypes;

        public ICommand SignupCommand { get; set; }

        private string _userType;
        public string UserType
        {
            get { return _userType; }
            set { _userType = value; OnPropertyChanged(); }
        }

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; OnPropertyChanged(); }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; OnPropertyChanged(); }
        }

        private string _physicalAddress;
        public string PhysicalAddress
        {
            get { return _physicalAddress; }
            set { _physicalAddress = value; OnPropertyChanged(); }
        }

        // Properties for medical professional
        private string _specialty;
        public string Specialty
        {
            get { return _specialty; }
            set { _specialty = value; OnPropertyChanged(); }
        }

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; OnPropertyChanged(); }
        }

        private DateTime _createdDate;
        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; OnPropertyChanged(); }
        }

        // Constructor for SignUpViewModel
        public SignUpViewModel(Localdatabase localdatabase)
        {
            SignupCommand = new Command(SignUp);
            _localdatabase = localdatabase;

            // Retrieve user types from the local database
            _userTypes = _localdatabase.GetUserTypes();
        }

        // Method for handling sign-up button click event
        public async void SignUp()
        {
            // Find the selected user type
            var userType = _userTypes.FirstOrDefault(ut => ut.TypeName == UserType);

            if (userType == null)
            {
                // Display alert or handle UI interactions for invalid user type selection
                return;
            }

            if (userType.UserTypeId == 1)
            {
                // Ensure all fields are filled for regular user
                if (string.IsNullOrEmpty(UserName) ||
                    string.IsNullOrEmpty(Password) ||
                    string.IsNullOrEmpty(Email) ||
                    string.IsNullOrEmpty(PhoneNumber) ||
                    string.IsNullOrEmpty(Gender) ||
                    string.IsNullOrEmpty(PhysicalAddress) ||
                    string.IsNullOrEmpty(UserType))
                {
                    // Display alert or handle UI interactions indicating missing fields
                    return;
                }
            }
            else if (userType.UserTypeId == 2)
            {
                // Ensure all fields are filled for medical professional
                if (string.IsNullOrEmpty(UserName) ||
                    string.IsNullOrEmpty(Password) ||
                    string.IsNullOrEmpty(Email) ||
                    string.IsNullOrEmpty(PhoneNumber) ||
                    string.IsNullOrEmpty(Gender) ||
                    string.IsNullOrEmpty(PhysicalAddress) ||
                    string.IsNullOrEmpty(Specialty) ||
                    DateOfBirth == default(DateTime) ||
                    CreatedDate == default(DateTime))
                {
                    // Display alert or handle UI interactions indicating missing fields
                    return;
                }
            }

            // Create a new user object
            var newUser = new User()
            {
                Name = UserName,
                Password = Password, // Hash passwords in a real application!
                Email = Email,
                PhoneNumber = PhoneNumber,
                Gender = Gender,
                PhysicalAddress = PhysicalAddress,
                Specialty = userType.UserTypeId == 2 ? Specialty : null,
                DateOfBirth = userType.UserTypeId == 2 ? DateOfBirth : default(DateTime),
                CreatedDate = DateTime.Now,
                UserType = userType.TypeName
            };

            // Insert the new user into the local database
            _localdatabase.InsertUser(newUser);

            // Navigate to the appropriate page based on user type
            if (userType.UserTypeId == 1)
            {
                await App.Current.MainPage.Navigation.PushAsync(new PatientHomeView());
            }
            else if (userType.UserTypeId == 2)
            {
                await App.Current.MainPage.Navigation.PushAsync(new MedicalHomeView());
            }

            // Display alert or handle UI interactions for successful sign-up (implementation not provided)
        }
    }
}
