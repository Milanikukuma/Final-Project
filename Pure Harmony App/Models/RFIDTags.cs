using System;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Pure_Harmony_App.Models
{
    public class RFIDTags
    {
        [PrimaryKey, AutoIncrement]
        public int RFIDTagID { get; set; }

        public int PatientID { get; set; }

        public string TagType { get; set; } // "pill", "bottle", "package" 

        public bool TagStatus { get; set; } // "active", "inactive" 

        public string RFIDCode { get; set; }



        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<MedicationAdherence> MedicationAdherenceRecords { get; set; } = new List<MedicationAdherence>();
    }
}
