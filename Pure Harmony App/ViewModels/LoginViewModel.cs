using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Service;
using Pure_Harmony_App.Views.Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
                    await App.Current.MainPage.Navigation.PushAsync(new PatientHomePage());
                }
                else if (user.UserTypeId == 2)

                {
                    await App.Current.MainPage.Navigation.PushAsync(new MedicalHomeView());
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
     }
     else if (userType == "Medical Professional")
     {
                // Navigate to medical professional sign-up page
                await Shell.Current.GoToAsync("patientsignuppage");
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

