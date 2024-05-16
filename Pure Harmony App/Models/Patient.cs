namespace Pure_Harmony_App.Models
{
    public class Patient
    {
       
            public int PatientID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public Gender Gender { get; set; } // Enum for gender
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string ContactInformation { get; set; }

            // Navigation properties (relationships)
            public List<Treatment> treatments { get; set; } = new List<Treatment>();
            public List<MedicationAdherence> MedicationAdherenceRecords { get; set; } = new List<MedicationAdherence>();
            public List<RFIDTags> RFIDTags { get; set; } = new List<RFIDTags>();
            public List<RFIDReader> RFIDReaders { get; set; } = new List<RFIDReader>();
            public List<Alert> Alerts { get; set; } = new List<Alert>();

        }

        // Gender Enum
        public enum Gender
        {
            Male,
            Female,
            Other
        }
    }

