using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Mappings
{
    public class DepartmentsMap:ClassMap<Departments>
    {
        public DepartmentsMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
