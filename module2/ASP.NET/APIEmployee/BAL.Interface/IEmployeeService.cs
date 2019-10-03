﻿using Domain;
using System;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface IEmployeeService
    {
        bool AddEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        IList<Employee> GetAllEmployee();
        bool DeleteEmployee(int EmployeeID);
        Employee GetByIdEmployee(int EmployeeID);
    }
}
