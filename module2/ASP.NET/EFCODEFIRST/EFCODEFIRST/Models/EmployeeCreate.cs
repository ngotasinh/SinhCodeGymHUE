using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCODEFIRST.Models
{
    public class EmployeeCreate
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập tên")]
        [StringLength(maximumLength: 50, MinimumLength = 10, ErrorMessage = "Nhập tên từ 10 đến 50 kí tự")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Bạn Phải Nhập Địa Chỉ")]
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public float Salary { get; set; }
    }
}
