using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Mappings
{
    public class PharmacyMap:ClassMap<Pharmacy>
    {
        public PharmacyMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Pharmacists);
            HasMany(x => x.Drugs);
        }
    }
}
