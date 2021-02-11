using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskForSteadyPoint.Entities;

namespace TaskForSteadyPoint.IRepository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeByID(int id);
        Task<Employee> Add(Employee Employee);
        Task<bool> Update(Employee Employee);
        Task<bool> DeleteByID(int id);
    }
}
