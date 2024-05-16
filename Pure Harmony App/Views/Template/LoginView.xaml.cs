using Pure_Harmony_App.Pages;
using Pure_Harmony_App.ViewModels;
using System.Windows.Input;

namespace Pure_Harmony_App.Views.Template;

public partial class LoginView : ContentPage
{
    private LoginViewModel _viewModel;
    


    public LoginView()
    {
        InitializeComponent();
        _viewModel = new LoginViewModel();
        BindingContext = _viewModel;

        // Example: Add a command for Login button (replace with your login logic)
       // _viewModel.LoginCommand = new Command(Login);
        // Add a command for Sign Up button
        //_viewModel.SignupCommand = new Command(Signup);

    }
   /* private async void Login(object parameter)
    {
        // Implement login logic here using _viewModel.Username, _viewModel.Password, _viewModel.SelectedUserType
        // ...

        // Example navigation to another page after successful login

    }*/
    /*private async void Signup(object parameter)
    {
        // Implement sign-up logic here
        // For example:
        // await Navigation.PushAsync(new SignupPage());

        // Show a message box for user type selection
        string userType = await DisplayActionSheet("Choose User Type", "Cancel", null, "Patient", "Medical Professional");
        if (userType == "Patient")
        {
            await Navigation.PushAsync(new PatientSignupPage());

        }
        else if (userType == "Medical Professional")
        {
            await Navigation.PushAsync(new MedicalProfessionalSignupPage());

        }
    }*/
}
