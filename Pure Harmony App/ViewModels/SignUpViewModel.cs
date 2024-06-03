using Microsoft.Maui;
using Pure_Harmony_App.Models;
using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Service;

using Pure_Harmony_App.Views;
using Pure_Harmony_App.Views.Template;



namespace Pure_Harmony_App.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        private readonly Localdatabase _localdatabase;
        private readonly List<UserType> _userTypes;

        public Command SignupCommand { get; set; }


        private string _userType;

        public string UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value;

                OnPropertyChanged();
            }
        }


    private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;

                OnPropertyChanged();
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;

                OnPropertyChanged();
            }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;

                OnPropertyChanged();
            }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;

                OnPropertyChanged();
            }
        }

        private string _physicalAddress;

        public string PhysicalAddress
        {
            get { return _physicalAddress; }
            set
            {
                _physicalAddress = value;

                OnPropertyChanged();
            }
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
                // Ensure all fields are filled
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
            else
            {
                //Other check
            }


            // Create a new user object
            var newUser = new User()
            {
                UserName = UserName,
                Password = Password, // Hash passwords in a real application!
                Email = Email,
                PhoneNumber = PhoneNumber,
                Gender = Gender,
                PhysicalAddress = PhysicalAddress,
                //   DateOfBirth = DateOfBirth,
                CreatedDate = DateTime.Now,
                UserTypeId = userType.UserTypeId
            };

            // Insert the new user into the local database
            _localdatabase.InsertUser(newUser);

            // Navigate to the appropriate page based on user type
            if (userType.UserTypeId == 1)
            {
                // Navigate to the PatientHomeView page if the user is a patient
                await App.Current.MainPage.Navigation.PushAsync(new PatientHomeView());
            }
            else if (userType.UserTypeId == 2)
            {
                // Navigate to the MedicalHomeView page if the user is a medical professional
                await App.Current.MainPage.Navigation.PushAsync(new MedicalHomeView());
            }
            // Display alert or handle UI interactions for successful sign-up (implementation not provided)

        }

    }
}
