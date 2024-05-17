using System;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace Pure_Harmony_App.Models
{
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int PatientID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

       
        // [OneToMany(CascadeOperations = CascadeOperation.All)]

        // public List<PatientTreatment> PatientTreatments { get; set; } = new List<PatientTreatment>();



        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<MedicationAdherence> MedicationAdherenceRecords { get; set; } = new List<MedicationAdherence>();



        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<RFIDTags> RFIDTags { get; set; } = new List<RFIDTags>();



        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<RFIDReader> RFIDReaders { get; set; } = new List<RFIDReader>();



        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<Alert> Alerts { get; set; } = new List<Alert>();



        //[OneToOne(CascadeOperations = CascadeOperation.All)]

      // public User User { get; set; } // One-to-one relationship with User 



    }

        // Gender Enum
        public enum Gender
        {
            Male,
            Female,
            Other
        }
    }

