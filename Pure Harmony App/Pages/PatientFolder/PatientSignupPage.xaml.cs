using Pure_Harmony_App.Service;
using Pure_Harmony_App.Models;
using Pure_Harmony_App.ViewModels;

namespace Pure_Harmony_App.Pages
{
    public partial class PatientSignUpPage : ContentPage
    {
        private Localdatabase _localdatabase;

        public PatientSignUpPage(SignUpViewModel vm, Localdatabase database)
        {
            InitializeComponent();
            BindingContext = vm;
            _localdatabase = database;

            vm.UserType = "Patient";

            //_localdatabase = new Localdatabase(); // Initialize Localdatabase
        }

        // Event handler for signup button click
    

/*        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            // Ensure all fields are filled
            if (string.IsNullOrEmpty(UserNameEntry.Text) ||
                string.IsNullOrEmpty(PasswordEntry.Text) ||
                string.IsNullOrEmpty(EmailEntry.Text) ||
                string.IsNullOrEmpty(PhoneNumberEntry.Text) ||
                string.IsNullOrEmpty(GenderEntry.Text) ||
                string.IsNullOrEmpty(PhysicalAddressEntry.Text))
            {
                // Display an alert indicating that all fields must be filled
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }

            // Create a new user without user type
            var newUser = new User()
            {
                UserName = UserNameEntry.Text,
                Password = PasswordEntry.Text, // Hash passwords in a real application!
                Email = EmailEntry.Text,
                PhoneNumber = PhoneNumberEntry.Text,
                Gender = GenderEntry.Text,
                PhysicalAddress = PhysicalAddressEntry.Text,
                DateOfBirth = DateOfBirthPicker.Date,
                CreatedDate = DateTime.Now,
            };

            _localdatabase.InsertUser(newUser);

            // Navigate to the home page
            await Navigation.PushAsync(new PatientHomePage());
        }
*/
    }
}
