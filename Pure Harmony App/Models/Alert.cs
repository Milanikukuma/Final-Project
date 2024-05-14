using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class Alert
    {
        public int AlertID { get; set; }
        public int PatientID { get; set; }
        public int MedicalProfessionalID { get; set; }
        public DateTime AlertDate { get; set; }
        public string? AlertType { get; set; }
    }
}
