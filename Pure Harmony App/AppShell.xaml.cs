using Pure_Harmony_App.Views;
using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Views.Template;
using Pure_Harmony_App.Pages.PatientFolder;

namespace Pure_Harmony_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        public void RegisterRoutes()
        {
            Routing.RegisterRoute("patientsignuppage", typeof(PatientSignUpPage));
            Routing.RegisterRoute("medicalhomeview", typeof(MedicalHomeView));
            Routing.RegisterRoute("patienthomeview", typeof(PatientHomeView));
            Routing.RegisterRoute("alertsview", typeof(AlertsView));
            Routing.RegisterRoute("medicationpage", typeof(MedicationPage));
            Routing.RegisterRoute("alerts", typeof(Alerts));
            Routing.RegisterRoute("reminders", typeof(Reminders));
            Routing.RegisterRoute("aboutus", typeof(AboutUs));
            Routing.RegisterRoute("patients", typeof(Patients));
            Routing.RegisterRoute("profilepage", typeof(ProfilePage));



            Routing.RegisterRoute("medicalsignupview", typeof(MedicalSignupView));

            
        }

    }
}

