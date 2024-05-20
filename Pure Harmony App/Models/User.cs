using System;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Pure_Harmony_App.Models
{
    public class User
    {

        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }

        public string UserType { get; set; } // "Patient", "Medical" 

        public string Username { get; set; }

        public string Password { get; set; }

        // Navigation properties
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Patient Patient { get; set; } // If UserType is "Patient" 

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public MedicalProfessional MedicalProfessional { get; set; } // If UserType is "Medical" 


    }

    }

