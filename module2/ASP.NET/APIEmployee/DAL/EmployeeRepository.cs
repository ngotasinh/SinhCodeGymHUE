using System;
using System.Collections.Generic;
using DAL.Interface;
using Domain;
using Dapper;
using System.Data;
using System.Linq;
using System.Data.SqlClient;

namespace DAL
{
    public class EmployeeRepository : BaseRepository,IEmployeeRepository
    {
        public bool AddEmployee(Employee employee)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EmployeeName", employee.EmployeeName);
                parameters.Add("@PhoneNumber", employee.PhoneNumber);
                parameters.Add("@YearsExperience", employee.YearsExperience);
                parameters.Add("@SkillID", employee.SkillID);
                SqlMapper.Execute(con, "sp_Add", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteEmployee(int EmployeeID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EmployeeID", EmployeeID);
                SqlMapper.Execute(con, "sp_Delete", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                throw;
            }        
        }

        public IList<Employee> GetAllEmployee()
        {
            IList<Employee> customerList = SqlMapper.Query<Employee>(con, "sp_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }

        public Employee GetByIdEmployee(int EmployeeID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EmployeeID", EmployeeID);
                return SqlMapper.Query<Employee>((SqlConnection)con, "sp_GetId", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EmployeeName", employee.EmployeeName);
                parameters.Add("@PhoneNumber", employee.PhoneNumber);
                parameters.Add("@YearsExperience", employee.YearsExperience);
                parameters.Add("@SkillID", employee.SkillID);
                SqlMapper.Execute(con, "sp_Update", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
