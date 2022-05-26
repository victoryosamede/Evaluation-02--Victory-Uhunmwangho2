using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Mappings
{
    public class DoctorsMap:ClassMap<Doctors>
    {
        public DoctorsMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x=>x.Gender);
            References(x=>x.Departments);
        }
    }
}
