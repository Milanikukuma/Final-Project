using Pure_Harmony_App.Service;
using Pure_Harmony_App.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pure_Harmony_App.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _email;
        private string _password;
        private UserType _selectedUserType;

        private Localdatabase _database;


        public enum UserType
        {
            Patient,
            MedicalProfessional
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public UserType SelectedUserType
        {
            get { return _selectedUserType; }
            set
            {
                _selectedUserType = value;
                OnPropertyChanged();
            }
        }

        public Command LoginCommand { get; internal set; }
        public Command SignupCommand { get; internal set; }

        public LoginViewModel(Localdatabase database)
        {
            _database = database;

            // Initialize default user type (e.g., Patient)
            SelectedUserType = UserType.Patient;

            // Initialize commands
            LoginCommand = new Command(Login);
           SignupCommand = new Command(Signup);
        }

        private async void Login()
        {
            // Validate if email and password are provided
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Please provide email and password.", "OK");
                return;
            }

            // Validate the credentials against the database
            var user = _database.ValidateUserNameAndPassword(Email, Password);

            if (user != null)
            {

                if (user.UserTypeId == 1)
                {
                    // Successful login, navigate to the main page
                    var parameters = new ShellNavigationQueryParameters();
                    parameters["UserType"] = user.UserTypeId.ToString();

                    await Shell.Current.GoToAsync("patienthomeview", false, parameters);



                    //await App.Current.MainPage.Navigation.PushAsync(new PatientHomeView());
                }
                else if (user.UserTypeId == 2)

                {
                    var parameters = new ShellNavigationQueryParameters();
                    parameters["UserType"] = user.UserTypeId.ToString();

                    await Shell.Current.GoToAsync("medicalhomeview",false,parameters);

                    //await App.Current.MainPage.Navigation.PushAsync(new MedicalHomeView());
                }
            }
            else
            {
                // Invalid credentials, display an error message
                await App.Current.MainPage.DisplayAlert("Error", "Invalid email or password.", "OK");
            }
        }



        private async void Signup()
 {
     // Show a message box for user type selection
     string userType = await App.Current.MainPage.DisplayActionSheet("Choose User Type", "Cancel", null, "Patient", "Medical Professional");

     if (userType == "Patient")
     {
                // Navigate to patient sign-up pageawait Shell.Current.GoToAsync("patientsignuppage")
                await Shell.Current.GoToAsync("patientsignuppage");
                //await App.Current.MainPage.Navigation.PushAsync(new MedicalSignUp());

                var parameters = new ShellNavigationQueryParameters();
                parameters["UserType"] = "Patient";

                await Shell.Current.GoToAsync("patientsignuppage", parameters);

            }
            else if (userType == "Medical Professional")
     {
                // Navigate to medical professional sign-up page
                var parameters = new ShellNavigationQueryParameters();
                parameters["UserType"] = "MedicalProfessional";


                await Shell.Current.GoToAsync("medicalsignupview", parameters);
         //await App.Current.MainPage.Navigation.PushAsync(new PatientSignUpPage());
     }
 }


         public event PropertyChangedEventHandler PropertyChanged;

         protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
         {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
         }
     }
    }

