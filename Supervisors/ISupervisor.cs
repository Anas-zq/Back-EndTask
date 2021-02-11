using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskForSteadyPoint.Models;

namespace TaskForSteadyPoint.Supervisors
{
    public interface ISupervisor
    {
        #region Employee
        Task<List<EmployeeModel>> GetAllEmployee();

        Task<EmployeeModel> GetEmployeeByID(int id);

        Task<EmployeeModel> AddEmployee(EmployeeModel EmployeeModel);

        Task<bool> UpdateEmployee(EmployeeModel EmployeeModel);

        Task<bool> DeleteEmployeeById(int id);
        #endregion
    }
}
