using BAL.Interface;
using DAL.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL
{
    public class NhanVienService : INhanVienService
    {
        INhanVienRepository _NhanVienRepository;
        public NhanVienService(INhanVienRepository NhanVienRepository)
        {
            _NhanVienRepository = NhanVienRepository;
        }
        public bool AddNhanVien(NhanVien nhanVien)
        {
            return _NhanVienRepository.AddNhanVien(nhanVien);
        }

        public bool DeleteNhanVien(int NVID)
        {
            return _NhanVienRepository.DeleteNhanVien(NVID);
        }

        public IList<NhanVien> GetAllNhanVien(int PhongID)
        {
            return _NhanVienRepository.GetAllNhanVien(PhongID);
        }

        public NhanVien GetNhanVienById(int NVID)
        {
            return _NhanVienRepository.GetNhanVienById(NVID);
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            return _NhanVienRepository.UpdateNhanVien(nhanVien);
        }
    }
}
