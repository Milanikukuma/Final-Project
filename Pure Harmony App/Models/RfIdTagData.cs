using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class RfIdTagData
    {
        public byte[]? RfIdTagUid { get; set; }
        public string? RfIdTagText { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
