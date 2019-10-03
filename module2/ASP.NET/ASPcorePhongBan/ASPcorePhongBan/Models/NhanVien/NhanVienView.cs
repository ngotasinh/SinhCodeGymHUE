using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPcorePhongBan.Models.NhanVien
{
    public class NhanVienView
    {
        public int NVID { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public int PhongID { get; set; }
    }
}
