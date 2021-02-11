using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskForSteadyPoint.Entities
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int OfficialID { get; set; }

        [MaxLength(100)]
        [Required]
        public string EmployeeName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
