using ASPNetCoreWebDapper.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWebDapper.DAL
{
    public class RomSever: DBSever
    {
        public RomSever(): base() { }
        public IEnumerable<Rom> GetRoms()
        {
            List<Rom> romsList = new List<Rom>();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                romsList = con.Query<Rom>("GetRomDetails").ToList();
            }
            return romsList;
        }
    }
}
