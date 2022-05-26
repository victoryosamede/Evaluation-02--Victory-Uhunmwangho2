using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Mappings
{
    public class HospitalMap : ClassMap<Hospital>
    {
        public HospitalMap()
            {
            Id(x=>x.Id);
            Map(x => x.Name);
            Map(x=>x.Address);
            HasMany(x=>x.Doctors);
            HasMany(x=>x.Nurses);
            HasMany(x => x.Pharmacists);
            HasOne(x => x.Receptionist);
            HasOne(x => x.Accountant);
            HasMany(x=>x.HospitalWards);
            HasOne(x => x.Lab);
            HasMany(x => x.Departments);
            HasMany(x => x.RegsiteredPatient);
            HasMany(x => x.UnregisteredPatient);

            }
    }
}
