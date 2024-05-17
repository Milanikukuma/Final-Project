using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Pure_Harmony_App.Models
{
    public class Treatment
    {
        [PrimaryKey, AutoIncrement]
        public int TreatmentID { get; set; }

        public string TreatmentName { get; set; }

        public string Description { get; set; }

        [ForeignKey(typeof(Disease))]
        public int DiseaseID { get; set; } // Foreign key to Disease 

        public string Schedule { get; set; } // "Daily", "Twice a day", etc.

        [ForeignKey(typeof(MedicalProfessional))]
        public int MedicalProfessionalID { get; set; } // Foreign key to MedicalProfessional 

        // Navigation properties
        [ManyToOne]
        public Disease Disease { get; set; }

        [ManyToOne]
        public MedicalProfessional MedicalProfessional { get; set; }

       // [OneToMany(CascadeOperations = CascadeOperation.All)]
       // public List<PatientTreatment> PatientTreatments { get; set; } = new List<PatientTreatment>();

    }
}
