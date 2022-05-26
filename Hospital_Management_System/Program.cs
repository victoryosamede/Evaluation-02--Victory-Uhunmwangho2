// See https://aka.ms/new-console-template for more information
using Hospital_Management_System;
using Hospital_Management_System.Models;

var PatientOne = new RegisteredPatient()

{
    Name = "Patient A",
    Id = 1,
    Age = 18,
    Weight = "78kg",
    Height = "165cm",
    BloodGroup = "O+",
    Genotype = "AA",
     
};
FluentNHibernateHelper.AddModel<RegisteredPatient>(PatientOne);