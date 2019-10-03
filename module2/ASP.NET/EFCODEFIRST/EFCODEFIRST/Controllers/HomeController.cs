using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCODEFIRST.Models;
using EFCODEFIRST.Context;

namespace EFCODEFIRST.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext _dbContext;

        public HomeController(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var _employee = _dbContext.Employees.Select(a=> new EmployeeView()
            {
                EmployeeId = a.EmployeeId,
                Name = a.Name,
                Address = a.Address,
                CompanyName= a.CompanyName,
                Designation = a.Designation,
                Salary= a.Salary
            }).ToList();
            return View(_employee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreate model)
        {
            var employee = new Employee()
            {
                EmployeeId = model.EmployeeId,
                Name = model.Name,
                Address = model.Address,
                CompanyName = model.CompanyName,
                Designation = model.Designation,
                Salary = model.Salary
            };
            _dbContext.Employees.Add(employee);
            if (_dbContext.SaveChanges() > 0)
            {
                TempData["Message"] = "Employee has been added successfully.";
            }
            else
            {
                TempData["Message"] = "Something went wrong, please contact administrator.";
            }
            return View(new EmployeeCreate());
        }
    
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var _employees = _dbContext.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            var employeeEdit = new EmployeeEdit()
            {
                EmployeeId = _employees.EmployeeId,
                Name = _employees.Name,
                Address = _employees.Address,
                CompanyName = _employees.CompanyName,
                Designation = _employees.Designation,
                Salary = _employees.Salary
            };
            return View(employeeEdit);
        }
       

        [HttpPost]
        public IActionResult Edit(EmployeeEdit model)
        {
            var employee = _dbContext.Employees.Find(model.EmployeeId);
            employee.EmployeeId = model.EmployeeId;
            employee.Name = model.Name;
            employee.Address = model.Address;
            employee.CompanyName = model.CompanyName;
            employee.Designation = model.Designation;
            employee.Salary = model.Salary;
            if (_dbContext.SaveChanges() > 0)
            {
                TempData["Message"] = "Employee has been added successfully.";
            }
            else
            {
                TempData["Message"] = "Something went wrong, please contact administrator.";
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var _employee = _dbContext.Employees.Select(a => new EmployeeDetails()
            {
                EmployeeId = a.EmployeeId,
                Name = a.Name,
                Address = a.Address,
                CompanyName = a.CompanyName,
                Designation = a.Designation,
                Salary = a.Salary
            }).Where(a => a.EmployeeId == id).FirstOrDefault();
            return View(_employee);
        }
    }
}
