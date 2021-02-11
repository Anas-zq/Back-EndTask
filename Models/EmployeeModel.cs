using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskForSteadyPoint.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }

        public int OfficialID { get; set; }

        public string EmployeeName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
