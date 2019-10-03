using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface INhanVienRepository
    {
        bool AddNhanVien(NhanVien nhanVien);
        bool UpdateNhanVien(NhanVien nhanVien);
        bool DeleteNhanVien(int NVID);
        IList<NhanVien> GetAllNhanVien(int PhongID);
        NhanVien GetNhanVienById(int NVID);
    }
}
