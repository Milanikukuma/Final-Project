using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Pure_Harmony_App.Models
{
    public class Alert

    {

        [PrimaryKey, AutoIncrement]
        public int AlertID { get; set; }
        public int PatientID { get; set; }

        public int MedicalProfessionalID { get; set; }

        public DateTime AlertDate { get; set; }

        public string AlertType { get; set; } // "Missed medication", etc. 



        // Navigation properties 

        public Patient Patient { get; set; }

        public MedicalProfessional MedicalProfessional { get; set; }

    }
}
