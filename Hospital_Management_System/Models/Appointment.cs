using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Appointment:EntityBase
    {
        public virtual List<MedicalConditions>? MedicalConditions { get; set; }
        public virtual DateTime? TimeOfAppointment { get; set; }
        public virtual RegisteredPatient? Patient { get; set; }
        public virtual Drugs? PatientsDrugs { get; set; }    
        public virtual Bill? CostOfAppoinment { get; set; }
    }
}
