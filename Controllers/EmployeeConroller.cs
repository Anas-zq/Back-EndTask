using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskForSteadyPoint.Models;
using TaskForSteadyPoint.Supervisors;

namespace TaskForSteadyPoint.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly ISupervisor _ISupervisor;
        public EmployeeController(ISupervisor ISupervisor)
        {
            _ISupervisor = ISupervisor;
        }

        [HttpGet("GetAllEmployee")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var result = await _ISupervisor.GetAllEmployee();
            return Ok(result);
        }

        [HttpGet("GetEmployeeById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var result = await _ISupervisor.GetEmployeeByID(id);
            return Ok(result);
        }

        [HttpPost("AddEmployee")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> AddEmployee([FromBody]EmployeeModel Employee)
        {
            try
            {
                var result = await _ISupervisor.AddEmployee(Employee);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw  ex;
            }
        }

        [HttpPut("UpdateEmployee")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeModel Employee)
        {
            try
            {
                var result = await _ISupervisor.UpdateEmployee(Employee);
                return Ok(result);
            }
            catch (Exception ex)
            {
                    throw ex;
            }
        }

        [HttpDelete("DeleteEmployeeById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> DeleteEmployeeById(int id)
        {
            var result = await _ISupervisor.DeleteEmployeeById(id);
            return Ok(result);
        }
    }

}

