using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstCode.Models;

namespace FirstCode.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<tblSkill> tblSkills { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<FirstCode.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
        public DbSet<FirstCode.Models.EmployeeCreateModel> EmployeeCreateModel { get; set; }
        public DbSet<FirstCode.Models.EmployeeEditModel> EmployeeEditModel { get; set; }
    }
}