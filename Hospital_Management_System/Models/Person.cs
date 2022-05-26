using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Person:EntityBase
    {
        public virtual string? Gender { get; set; }
    }
}
