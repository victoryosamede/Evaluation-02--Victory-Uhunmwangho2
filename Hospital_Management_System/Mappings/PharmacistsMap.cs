using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Mappings
{
    public class PharmacistsMap:ClassMap<Pharmacists>
    {
        public PharmacistsMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Gender);
            
        }
    }
}
