namespace Pure_Harmony_App.Views;

public partial class MedicalSignupView : ContentPage
{
    private MedicalSignupView _viewModels;
    public MedicalSignupView(MedicalSignupView vm)
    {
        InitializeComponent();
        _viewModels = vm;
        //  _viewModel = new LoginViewModel();
        BindingContext = vm;
    }

    private void SignUp_Clicked(object sender, EventArgs e)
    {

    }
}