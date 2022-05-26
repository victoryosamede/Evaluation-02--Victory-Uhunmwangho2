using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Bill:EntityBase
    {
        public virtual string? AppointmentCost { get; set; }
        public virtual string? CostOfDrugs { get; set; }

    }
}
