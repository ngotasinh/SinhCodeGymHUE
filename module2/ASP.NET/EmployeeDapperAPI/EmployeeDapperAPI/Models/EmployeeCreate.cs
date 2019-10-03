using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDapperAPI.Models
{
    public class EmployeeCreate
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public int YearsExperience { get; set; }
        public int SkillID { get; set; }
    }
}
