using System;
using System.ComponentModel.DataAnnotations.Schema;
using SQLite;
using SQLiteNetExtensions.Attributes;
using ForeignKeyAttribute = SQLiteNetExtensions.Attributes.ForeignKeyAttribute;
namespace Pure_Harmony_App.Models
{
    public class User
    {

        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }

        [ForeignKey(typeof(UserType))]
        public int UserTypeId {get; set; } // "Patient", "Medical" 

        public string Email { get; set; }

        public string Password { get; set; }

        // Navigation properties
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Patient Patient { get; set; } // If UserType is "Patient" 

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public MedicalProfessional MedicalProfessional { get; set; } // If UserType is "Medical" 




    }

    }

