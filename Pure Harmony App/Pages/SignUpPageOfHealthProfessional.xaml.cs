namespace Pure_Harmony_App.Pages;

public partial class SignUpPageOfHealthProfessional : ContentPage
{
	public SignUpPageOfHealthProfessional()
	{
		InitializeComponent();
	}

    private void OnSignUpClicked(object sender, EventArgs e)
    {
        // Perform validation before signup
        if (!ValidateForm())
        {
            DisplayAlert("Error", "Please fill in all required fields and agree to the terms and conditions.", "OK");
            return;
        }

        // Perform signup logic here
        // You can access form fields using their x:Name
        var name = NameEntry.Text;
        var licenseNumber = LicenseNumberEntry.Text;
        var specialty = SpecialtyEntry.Text;
        var organization = OrganizationEntry.Text;
        var username = UsernameEntry.Text;
        var password = PasswordEntry.Text;
        var confirmPassword = ConfirmPasswordEntry.Text;
        var email = EmailEntry.Text;
        var phone = PhoneEntry.Text;
        var bio = BioEditor.Text;
        var consent1 = ConsentSwitch1.IsToggled;
        var consent2 = ConsentSwitch2.IsToggled;
        var termsAgreed = TermsSwitch.IsToggled;

        // Example: Validate passwords match
        if (password != confirmPassword)
        {
            DisplayAlert("Error", "Passwords do not match.", "OK");
            return;
        }

        // Proceed with signup...
    }

    private bool ValidateForm()
    {
        // Validate that all required fields are filled and terms are agreed
        if (string.IsNullOrWhiteSpace(NameEntry.Text) ||
            string.IsNullOrWhiteSpace(LicenseNumberEntry.Text) ||
            string.IsNullOrWhiteSpace(SpecialtyEntry.Text) ||
            string.IsNullOrWhiteSpace(OrganizationEntry.Text) ||
            string.IsNullOrWhiteSpace(UsernameEntry.Text) ||
            string.IsNullOrWhiteSpace(PasswordEntry.Text) ||
            string.IsNullOrWhiteSpace(ConfirmPasswordEntry.Text) ||
            string.IsNullOrWhiteSpace(EmailEntry.Text) ||
            string.IsNullOrWhiteSpace(PhoneEntry.Text) ||
            !ConsentSwitch1.IsToggled ||
            !ConsentSwitch2.IsToggled ||
            !TermsSwitch.IsToggled)
        {
            return false;
        }

        return true;
    }
}
