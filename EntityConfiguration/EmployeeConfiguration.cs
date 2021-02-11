using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskForSteadyPoint.Entities;

namespace TaskForSteadyPoint.EntityConfiguration
{
    public class EmployeeConfiguration
    {
        public EmployeeConfiguration(EntityTypeBuilder<Employee> entity)
        {
            entity.HasIndex(e => new { e.OfficialID }).IsUnique();
            entity.HasData(
            new Employee
            {
                ID = 1,
                CreationDate = DateTime.Now,
                DateOfBirth = new DateTime(1998, 3, 2),
                OfficialID = 1,
                EmployeeName = "Ahmad",
                EmailAddress = "Ahmad@steady"
            },
             new Employee
             {
                 ID = 2,
                 CreationDate = DateTime.Now,
                 DateOfBirth = new DateTime(1998, 2, 1),
                 OfficialID = 2,
                 EmployeeName = "Anas",
                 EmailAddress = "Anas@steady"
             },
              new Employee
              {
                  ID = 3,
                  CreationDate = DateTime.Now,
                  DateOfBirth = new DateTime(2001, 3, 1),
                  OfficialID = 3,
                  EmployeeName = "ihab",
                  EmailAddress = "ihab@steady"
              },
               new Employee
               {
                   ID = 4,
                   CreationDate = DateTime.Now,
                   DateOfBirth = new DateTime(2002, 1, 3),
                   OfficialID = 4,
                   EmployeeName = "majd",
                   EmailAddress = "majd@steady"
               }
            );
        }
    }
}
