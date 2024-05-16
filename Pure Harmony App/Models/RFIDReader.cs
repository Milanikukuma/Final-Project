using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class RFIDReader
    {
        

            public int RFIDReaderID { get; set; }

            public int PatientID { get; set; }



            // Navigation property 

            public Patient Patient { get; set; }

        }
    }

