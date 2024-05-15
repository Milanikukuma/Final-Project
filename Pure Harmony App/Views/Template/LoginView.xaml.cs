using Pure_Harmony_App.ViewModels;

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
        _viewModel.LoginCommand = new RelayCommand(Login);
    }
    private async void Login(object parameter)
    {
        // Implement login logic here using _viewModel.Username, _viewModel.Password, _viewModel.SelectedUserType
        // ...

        // Example navigation to another page after successful login
        
    }
}
