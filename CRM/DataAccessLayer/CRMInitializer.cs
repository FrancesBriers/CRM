using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRM.Models;
using System.Data.Entity;

namespace CRM.DataAccessLayer
{
    public class CRMInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CRMContext>
    {
        protected override void Seed(CRMContext context)
        {
            var clients = new List<Client>
            {
                new Client{Forename = "Joe", Surname = "Bloggs", DateOfBirth = DateTime.Parse("1985-03-30"), AddressDetails = "1 Blog Lane"}
            };
            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee{Forename = "Alice", Surname = "Bloggs", DateOfBirth = DateTime.Parse("1990-03-01")}
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}