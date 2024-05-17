using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Pure_Harmony_App.Models
{
    internal class PatientTreatment
    {
        [PrimaryKey, AutoIncrement]
        public int PatientTreatmentID { get; set; }

        [ForeignKey(typeof(Patient))]
        public int PatientID { get; set; }

        [ForeignKey(typeof(Disease))]
        public int DiseaseID { get; set; }

        [ForeignKey(typeof(Treatment))]
        public int TreatmentID { get; set; }

        public DateTime TreatmentStartDate { get; set; }

        public DateTime? TreatmentEndDate { get; set; } // Nullable for ongoing treatments

        [ManyToOne]
        public Patient Patient { get; set; }

        [ManyToOne]
        public Disease Disease { get; set; }

        [ManyToOne]
        public Treatment Treatment { get; set; }
    }
}
