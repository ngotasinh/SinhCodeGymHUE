using DAL.Interface;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class NhanVienRepository : BaseRepository, INhanVienRepository
    {
        public bool AddNhanVien(NhanVien nhanVien)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenNV", nhanVien.TenNV);
                parameters.Add("@NgaySinh", nhanVien.NgaySinh);
                parameters.Add("@PhongID", nhanVien.PhongID);
                SqlMapper.Execute(con, "AddNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteNhanVien(int NVID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@NVID", NVID);
                SqlMapper.Execute(con, "DeleteNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<NhanVien> GetAllNhanVien(int PhongID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PhongID", PhongID);
            IList<NhanVien> customerList = SqlMapper.Query<NhanVien>(con, "GetNhanVienByPhongID", param:parameters,commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }

        public NhanVien GetNhanVienById(int NVID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@NVID", NVID);
                return SqlMapper.Query<NhanVien>((SqlConnection)con, "GetNhanVienByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenNV", nhanVien.TenNV);
                parameters.Add("@NgaySinh", nhanVien.NgaySinh);
                parameters.Add("@PhongID", nhanVien.PhongID);
                SqlMapper.Execute(con, "UpdatePhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
