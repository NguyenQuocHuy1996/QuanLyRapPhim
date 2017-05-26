using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class ResetIndexDAL
    {
        private DataProvider dp;

        public ResetIndexDAL()
        {
            dp = new DataProvider();
        }

        public void ResetSTTDAL()
        {
            string sql = "DBCC CHECKIDENT ('dbo.ThucAn_Tam', RESEED, 0)";
            SqlCommand cmd = new SqlCommand(sql,dp.cn);
            dp.Connect();
            cmd.ExecuteNonQuery();
            dp.DisConnect();
        }

        public void ResetSTTDKDAL(int so)
        {
            string sql = "DBCC CHECKIDENT ('dbo.ThucAn_Tam', RESEED,"+so+")";
            SqlCommand cmd = new SqlCommand(sql, dp.cn);
            dp.Connect();
            cmd.ExecuteNonQuery();
            dp.DisConnect();
        }
    }
}
