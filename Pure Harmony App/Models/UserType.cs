using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Pure_Harmony_App.Models
{
   public class UserType
   {
        [PrimaryKey, AutoIncrement]
        public int UserTypeId { get; set; }
        public string TypeName { get; set; }

        /*public string Patient { get; set; }  

        public string Medical {get;set;}*/
    }
}
