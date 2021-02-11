using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TaskForSteadyPoint.Entities;
using TaskForSteadyPoint.Models;

namespace TaskForSteadyPoint.Mapper
{
   
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Employee, EmployeeModel>();
            CreateMap<EmployeeModel, Employee>();
        }
    }
}
