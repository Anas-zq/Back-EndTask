using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskForSteadyPoint.Entities;
using TaskForSteadyPoint.Models;

namespace TaskForSteadyPoint.Supervisors
{
    public partial class Supervisor
    {
        public async Task<List<EmployeeModel>> GetAllEmployee()
        {
            var employees = await _IEmployeeRepository.GetAllEmployees();
            return _mapper.Map<List<EmployeeModel>>(employees);
        }
        public async Task<EmployeeModel> GetEmployeeByID(int id)
        {

            var Employee = await _IEmployeeRepository.GetEmployeeByID(id);
            return _mapper.Map<EmployeeModel>(Employee);
        }

        public async Task<EmployeeModel> AddEmployee(EmployeeModel EmployeeModel)
        {
            var EmployeeEntity = _mapper.Map<Employee>(EmployeeModel);
            return _mapper.Map<EmployeeModel>(await _IEmployeeRepository.Add(EmployeeEntity));
        }
        public async Task<bool> UpdateEmployee(EmployeeModel EmployeeModel)
        {
            var EmployeeEntity = _mapper.Map<Employee>(EmployeeModel);
            EmployeeEntity.CreationDate = DateTime.Now;
            return await _IEmployeeRepository.Update(EmployeeEntity);
        }

        public async Task<bool> DeleteEmployeeById(int id)
        {
            try
            {
                await _IEmployeeRepository.DeleteByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }



    }
}
