using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Hospital_Management_System.Models;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Hospital_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public static class FluentNHibernateHelper
    {
        private static ISessionFactory? _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitialiseSessionFactory();
                }
                return _sessionFactory;
            }
        }
        public static void InitialiseSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\GroupOneSchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Hospital>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();//Initialise Session Factory
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public static void AddModel<T>(T Model)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(Model);
                transaction.Commit();
            }

        }

        public static void ScheduleAppointment(Appointment Appointment)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(Appointment);
                transaction.Commit();
            }

        }
        public static void PatientBill(Bill Bill)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(Bill);
                transaction.Commit();
            }

        }
        public static void UpdateModel<T>(T Model)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Update(Model);
                transaction.Commit();
            }
        }
        public static void DeleteModel<T>(T Model)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(Model);
                transaction.Commit();
            }
        }
        public static T ReadModel<T>(int Id)
        {
            var session = OpenSession();
            var model = session.Get<T>(Id);
            return model;
        }
        public static List<T> ReadAllModel<T>()
        {
            var session = OpenSession();
            var model = session.Query<T>().ToList();
            return model;
        }
        public static Hospital? FindById(int Id)
        {
            var session = OpenSession();
            var model = session.Query<Hospital>().Where(h => h.Id == Id).FirstOrDefault();
            return model;


        }

    }
    }
