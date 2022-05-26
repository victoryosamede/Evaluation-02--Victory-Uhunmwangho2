using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Patients : Person
    {
        public virtual int Age { get; set; }
        public virtual string? Weight { get; set; }
        public virtual string? Height { get; set; }
        public virtual string? BloodGroup { get; set; }
        public virtual string? Genotype { get; set; }
        public virtual Hospital? Hospital { get; set; }
    }
}
