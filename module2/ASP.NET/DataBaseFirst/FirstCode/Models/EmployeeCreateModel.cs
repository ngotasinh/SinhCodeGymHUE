using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace FirstCode.Models
{
    public class EmployeeCreateModel
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage ="Bạn phải nhập tên")]
        [StringLength(maximumLength:50, MinimumLength =10,ErrorMessage ="Nhập tên từ 10 đến 50 kí tự")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage ="Bạn phải nhập số điện thoại")]
        [RegularExpression(pattern: "(09|01[2|6|8|9])+([0-9]{8})", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string PhoneNumber { get; set; }
        
        public int SkillID { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập số năm kinh nghiệm")]
        [Range(minimum: 1, maximum: 30, ErrorMessage = "Bạn Nhập số năm kinh nghiệm từ 1 đến 30")]
        public int YearsExperience { get; set; }
    }
}
