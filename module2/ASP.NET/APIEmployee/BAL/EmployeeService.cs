using BAL.Interface;
using DAL.Interface;
using Domain;
using System;
using System.Collections.Generic;

namespace BAL
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public bool AddEmployee(Employee employee)
        {
            return _employeeRepository.AddEmployee(employee);
        }

        public bool DeleteEmployee(int EmployeeID)
        {
            return _employeeRepository.DeleteEmployee(EmployeeID);
        }

        public IList<Employee> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();
        }

        public Employee GetByIdEmployee(int EmployeeID)
        {
            return _employeeRepository.GetByIdEmployee(EmployeeID);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return _employeeRepository.UpdateEmployee(employee);
        }
    }
}
