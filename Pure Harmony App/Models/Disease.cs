using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Pure_Harmony_App.Models
{
    public class Disease
    {
        [PrimaryKey, AutoIncrement]
        public int DiseaseID { get; set; }

        public string? Description { get; set; }

       // [OneToMany(CascadeOperations = CascadeOperation.All)]
       // public List<PatientTreatment> PatientTreatments { get; set; } = new List<PatientTreatment>();
    }
}
