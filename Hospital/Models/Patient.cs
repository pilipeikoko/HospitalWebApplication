using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Patient
    {
        public string FullName { get; set; }
        public string PlaceOfResidence { get; set; }
        public DateTime Birthday { get; set; }
        
        public DateTime DateOfReceipt { get; set; }
        public string DoctrosFullName { get; set; }
        public string Colnclusion { get; set; }


    }
}
