using System;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Pure_Harmony_App.Models
{
    public class MedicationAdherence
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }



        [ForeignKey(typeof(Patient))]

        public int PatientID { get; set; }



        [ForeignKey(typeof(RFIDTags))]

        public int RFIDTagID { get; set; }



        public DateTime Date { get; set; }



        public bool MedicationTaken { get; set; }



        [ManyToOne]

        public Patient Patient { get; set; }



        [ManyToOne]

        public RFIDTags RFIDTag { get; set; }

    }
}
