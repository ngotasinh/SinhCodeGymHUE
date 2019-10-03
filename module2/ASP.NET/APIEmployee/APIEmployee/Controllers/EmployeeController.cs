using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Domain;
using Domain.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIEmployee.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET api/values
        [HttpGet]
        [Route("api/employee/gets")]
        public IList<Employee> Gets()
        {
            return _employeeService.GetAllEmployee();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/employee/get/{id}")]
        public Employee Get(int id)
        {
            return _employeeService.GetByIdEmployee(id);
        }
        // POST api/values
        [HttpPost]
        [Route("api/employee/create")]
        public bool Create([FromBody] Employee employee)
        {
            return _employeeService.AddEmployee(employee);
        }
        // PUT api/values/5
        [HttpPut]
        [Route("api/employee/update")]
        public bool Update([FromBody] Employee employee)
        {
            return _employeeService.UpdateEmployee(employee);
        }
        // DELETE api/values/5
        [HttpDelete]
        [Route("api/employee/delete")]
        public bool Delete([FromBody]EmployeeDeleteRequest request)
        {
            return _employeeService.DeleteEmployee(request.Id);
        }

    }
}