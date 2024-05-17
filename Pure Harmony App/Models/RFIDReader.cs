using System;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Pure_Harmony_App.Models
{
    public class RFIDReader
    {


        [PrimaryKey, AutoIncrement]
        public int RFIDReaderID { get; set; }


        public int PatientID { get; set; }



            // Navigation property 

            public Patient Patient { get; set; }

        }
    }

