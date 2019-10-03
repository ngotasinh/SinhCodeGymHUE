using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPcorePhongBan.Models
{
    public class PhongBanView
    {
        public int PhongID { get; set; }
        public string TenPhong { get; set; }
        public bool IsDelete { get; set; }
        public string SoLuongNV { get; set; }

    }
}
