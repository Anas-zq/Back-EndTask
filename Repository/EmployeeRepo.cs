using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskForSteadyPoint.Entities;
using TaskForSteadyPoint.IRepository;

namespace TaskForSteadyPoint.Repository
{
    public class EmployeeRepo : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepo(Context context)
        {
            _context = context;
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            var Employees = await _context.Employees.ToListAsync();
            return Employees;
        }

        public async Task<Employee> GetEmployeeByID(int id)
        {
            var Employee = await _context.Employees.Where(e => e.ID == id)
                                            .FirstOrDefaultAsync();
            return Employee;

        }

        public async Task<Employee> Add(Employee Employee)
        {
            _context.Add(Employee); 
            await _context.SaveChangesAsync();
            return Employee;
        }

        public async Task<bool> Update(Employee Employee)
        {
            _context.Update(Employee);
            var success = await _context.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }
        public async Task<bool> DeleteByID(int id)
        {
            var Employee = await GetEmployeeByID(id);
            _context.Remove(Employee);
            var success = await _context.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }
    }
}
