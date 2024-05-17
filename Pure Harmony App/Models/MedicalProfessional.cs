using System;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Pure_Harmony_App.Models
{
    public class MedicalProfessional
    {
        [PrimaryKey, AutoIncrement]

        public int MedicalProfessionalID { get; set; }



        public string Name { get; set; }



        public string Specialty { get; set; }



        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<Alert> Alerts { get; set; } = new List<Alert>();
    }
}
