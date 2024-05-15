using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class RFIDTags
    {
        public int RFIDTagsID { get; set; }
        public int PatientID { get; set; }
        public string? TagType { get; set; }
        public string? TagStatus { get; set; }
        public int RFIDCode { get; set; }
    }
}
