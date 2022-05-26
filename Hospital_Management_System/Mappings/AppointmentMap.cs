using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Mappings
{
    public class AppointmentMap:ClassMap<Appointment>
    {
        public AppointmentMap()
        {
            Id(x => x.Id);
            Map(x=>x.Name);
            HasMany(x => x.MedicalConditions);
            Map(x=>x.TimeOfAppointment);
            HasOne(x=>x.Patient);
            Map(x=>x.PatientsDrugs);
            HasOne(x => x.CostOfAppoinment);
        }
    }
}
