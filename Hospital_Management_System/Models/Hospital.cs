using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Hospital:EntityBase
    {
        public virtual string? Address { get; set; }
        public virtual List<Doctors>? Doctors { get; set; }  
        public virtual List<Nurses>? Nurses { get; set; }    
        public virtual List<Pharmacists>? Pharmacists { get; set; }
        public virtual Receptionist? Receptionist { get; set; }
        public virtual Accountant? Accountant { get; set; }
        public virtual List <HospitalWards>? HospitalWards { get; set; }
        public virtual Lab? Lab { get; set; }
        public virtual List<Departments>? Departments { get; set; }
        public virtual List<RegisteredPatient>? RegsiteredPatient { get; set; }
        public virtual List<UnregisteredPatient>? UnregisteredPatient { get; set; }


    }
}
