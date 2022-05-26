using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class RegisteredPatient:Patients
    {
        public virtual string? HospitalNumber { get; set; }
        public virtual List<Appointment>? Appointment { get; set; }
    }
}
