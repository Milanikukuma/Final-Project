using System;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Pure_Harmony_App.Models
{
    public class MedicalProfessional
    {
        [PrimaryKey, AutoIncrement]

        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string PhysicalAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MedicalProfessionalID { get; internal set; }
        public string Specialty { get; internal set; }
    }
}
