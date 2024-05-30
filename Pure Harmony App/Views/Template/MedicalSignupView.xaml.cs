using Pure_Harmony_App.ViewModels;

namespace Pure_Harmony_App.Views;

public partial class MedicalSignupView : ContentPage
{
    private SignUpViewModel  _viewModels;
    public MedicalSignupView(SignUpViewModel vm)
    {
        InitializeComponent();
        _viewModels = vm;
        //  _viewModel = new LoginViewModel();
        BindingContext = vm;
    }

}