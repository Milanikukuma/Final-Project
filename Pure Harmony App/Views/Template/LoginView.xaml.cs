using Pure_Harmony_App.Pages;
using Pure_Harmony_App.ViewModels;
using System.Windows.Input;

namespace Pure_Harmony_App.Views.Template;

public partial class LoginView : ContentPage
{
    private LoginViewModel _viewModel;

    public LoginView(LoginViewModel vm)
    {
        InitializeComponent();
        _viewModel = vm;
      //  _viewModel = new LoginViewModel();
        BindingContext = vm;

      
    }

   

   
}
