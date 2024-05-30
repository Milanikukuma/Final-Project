using System;
using System.ComponentModel.DataAnnotations.Schema;
using Pure_Harmony_App.Models;
using SQLite;
using SQLiteNetExtensions.Attributes;
using ForeignKeyAttribute = SQLiteNetExtensions.Attributes.ForeignKeyAttribute;


    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }

        [ForeignKey(typeof(UserType))]
        public int UserTypeId { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string PhysicalAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Patient Patient { get; set; } // If UserType is "Patient" 

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public MedicalProfessional MedicalProfessional { get; set; } // If UserType is "Medical" 
    }






    

