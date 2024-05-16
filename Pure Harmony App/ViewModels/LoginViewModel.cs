using Pure_Harmony_App.Pages;
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
        private string _username;
        private string _password;
        private UserType _selectedUserType;

        public enum UserType
        {
            Patient,
            MedicalProfessional
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
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

        public LoginViewModel()
        {
            // Initialize default user type (e.g., Patient)
            SelectedUserType = UserType.Patient;

            // Initialize commands
            LoginCommand = new Command(Login);
            SignupCommand = new Command(Signup);
        }

        private async void Login()
        {
            // Implement login logic here using Username, Password, SelectedUserType
            // For example:
            // bool loginSuccessful = await SomeLoginService.LoginAsync(Username, Password, SelectedUserType);
            // if (loginSuccessful)
            // {
            //     await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            // }
        }

      private async void Signup()
{
    // Show a message box for user type selection
    string userType = await App.Current.MainPage.DisplayActionSheet("Choose User Type", "Cancel", null, "Patient", "Medical Professional");
    
    if (userType == "Patient")
    {
        // Navigate to patient sign-up page
        await App.Current.MainPage.Navigation.PushAsync(new PatientSignupPage());
    }
    else if (userType == "Medical Professional")
    {
        // Navigate to medical professional sign-up page
        await App.Current.MainPage.Navigation.PushAsync(new MedicalProfessionalSignupPage());
    }
}


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

