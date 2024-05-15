namespace Pure_Harmony_App.Models
{
    public class Patient
    {
        public  string? FirstName { get; set; }
        public  string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public  string? Email { get; set; }
        public  string? PhoneNumber { get; set; } // Add PhoneNumber property
        public  string? Address { get; set; }
        public int PatientId { get;  set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
