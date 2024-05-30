using Pure_Harmony_App.Service;
using Pure_Harmony_App.ViewModels;

namespace Pure_Harmony_App.Pages;

public partial class MedicalSignUp : ContentPage
{
    private Localdatabase _localdatabase;

    public MedicalSignUp(SignUpViewModel vm, Localdatabase database)
    {
        InitializeComponent();
        BindingContext = vm;
        _localdatabase = database;

        vm.UserType = "MedicalProfessional";

        //_localdatabase = new Localdatabase(); // Initialize Localdatabase
    }
}