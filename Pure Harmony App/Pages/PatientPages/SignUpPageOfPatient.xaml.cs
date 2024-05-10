namespace Pure_Harmony_App.Pages.PatientPages;

public partial class SignUpPageOfPatient : ContentPage
{
	public SignUpPageOfPatient()
	{
		InitializeComponent();
	}

	

        private void OnSignupClicked(object sender, EventArgs e)
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
            var dateOfBirth = DateOfBirthPicker.Date;
            var gender = GenderPicker.SelectedItem.ToString();
            var address = AddressEntry.Text;
            var phoneNumber = PhoneEntry.Text;
            var email = EmailEntry.Text;
            var tbPatientID = TBPatientIDEntry.Text;
            var typeOfTB = TypeOfTBPicker.SelectedItem.ToString();
            var treatmentStatus = TreatmentStatusPicker.SelectedItem.ToString();
            var caregiverName = CaregiverNameEntry.Text;
            var relationshipToPatient = RelationshipToPatientEntry.Text;
            var caregiverEmail = CaregiverEmailEntry.Text;
            var caregiverPhoneNumber = CaregiverPhoneEntry.Text;
            var consent = ConsentSwitch.IsToggled;
            var password = PasswordEntry.Text;
            var confirmPassword = ConfirmPasswordEntry.Text;
            var phoneNumberFor2FA = PhoneNumberEntry.Text;
            var authenticationCode = AuthenticationCodeEntry.Text;
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
                DateOfBirthPicker.Date == DateTime.MinValue ||
                GenderPicker.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(AddressEntry.Text) ||
                string.IsNullOrWhiteSpace(PhoneEntry.Text) ||
                string.IsNullOrWhiteSpace(EmailEntry.Text) ||
                string.IsNullOrWhiteSpace(PasswordEntry.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordEntry.Text) ||
                ConsentSwitch.IsToggled == false ||
                TermsSwitch.IsToggled == false)
            {
                return false;
            }

            return true;
        }
    }
