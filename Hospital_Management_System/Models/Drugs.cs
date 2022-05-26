using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Drugs:EntityBase
    {
        public virtual string? Cost { get; set; }
        public virtual string? NumberOfDrugsRemaining { get; set; }
    }
}
