﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Doctors:Person
    {
        public virtual Departments? Departments { get; set; }
    }
}
