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

        _viewModel.LoginCommand = new Command(Login);
        _viewModel.SignupCommand = new Command(Signup);

        // Initially hide the signup container, forms, and the picker
        //SignupContainer.IsVisible = false;
        //PatientSignupForm.IsVisible = false;
       // MedicalProfessionalSignupForm.IsVisible = false;
        //UserTypePicker.IsVisible = false;
    }

    private async void Login(object parameter)
    {
        // Implement login logic here using _viewModel.Username, _viewModel.Password, _viewModel.SelectedUserType
        // ...

        // Example navigation to another page after successful login

    }

    private void Signup(object parameter)
    {
        // Show the user type picker
        SignupContainer.IsVisible = true;
        UserTypePicker.IsVisible = true;
    }

    private void UserTypePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Get the selected user type from the picker
        string selectedUserType = UserTypePicker.Items[UserTypePicker.SelectedIndex];

        // Show the appropriate signup form and hide the other
        if (selectedUserType == "Patient")
        {
            PatientSignupForm.IsVisible = true;
            MedicalProfessionalSignupForm.IsVisible = false;
            UserTypePicker.IsVisible = false;
        }
        else if (selectedUserType == "Medical Professional")
        {
            PatientSignupForm.IsVisible = false;
            MedicalProfessionalSignupForm.IsVisible = true;
            UserTypePicker.IsVisible = false;
        }
    }
}
