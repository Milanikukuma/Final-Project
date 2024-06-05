namespace Pure_Harmony_App.Pages;

public partial class PatientProfilePage : ContentPage
{
	public PatientProfilePage(Patients selectedPatient)
	{
		InitializeComponent();
        BindingContext = selectedPatient;
    }
}