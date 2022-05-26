using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Mappings
{
    public class RegisteredPatientMap:ClassMap<RegisteredPatient>
    {
        public RegisteredPatientMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Age);
            Map(x => x.Weight);
            Map(x => x.Height);
            Map(x => x.BloodGroup);
            Map(x => x.Genotype);
            References(x => x.Hospital);
            Map(x => x.HospitalNumber);
            HasMany(x => x.Appointment);
        }
    }
}
