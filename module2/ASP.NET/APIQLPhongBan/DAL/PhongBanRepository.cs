using DAL.Interface;
using Domain;
using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Linq;
using System.Data.SqlClient;

namespace DAL
{
    public class PhongBanRepository : BaseRepository, IPhongBanRepository
    {
        public bool AddPhongBan(PhongBan phongBan)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenPhong", phongBan.TenPhong);
                SqlMapper.Execute(con, "AddPhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeletePhongBan(int PhongID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PhongID", PhongID);
                SqlMapper.Execute(con, "DeletePhongban", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<PhongBanView> GetAllPhongBan()
        {


            IList<PhongBanView> customerList = SqlMapper.Query<PhongBanView>(con, "GetAllPhongBan", commandType: CommandType.StoredProcedure).ToList();
            return customerList;


        }

        public PhongBanView GetPhongBanById(int PhongID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PhongID", PhongID);
                return SqlMapper.Query<PhongBanView>((SqlConnection)con, "GetByPhongBanId", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdatePhongBan(PhongBan phongBan)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PhongID", phongBan.PhongID);
                parameters.Add("@TenPhong", phongBan.TenPhong);
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
