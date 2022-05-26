using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Pharmacy:EntityBase
    {
        public virtual List<Pharmacists>? Pharmacists { get; set; }
        public virtual List<Drugs>? Drugs { get; set; }
    }
}
