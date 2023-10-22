using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbUtility;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DDiscount
    {
        public DataSet Query(string cName, string cType)
        {
            string sql = "SELECT spmc,splx,zkl,zksj  FROM Commodity WHERE spmc LIKE '%" + cName + "%' OR splx LIKE '%" + cType + "%'";
            return SqlHelp.Query(sql);
        }
        public void Update(string cName, double Discount, string DiscountTime)
        {
            string sql = " UPDATE Commodity SET  zkl='"+ Discount + "',zksj= '"+ DiscountTime + "'  WHERE spmc= '" + cName + "'";
            SqlHelp.ExecuteSql(sql);
        }
        public SqlDataReader Now(string nowTime)
        {
            string sql = "SELECT spmc FROM [Purchase and sale].[dbo].[Commodity] WHERE zksj <= '" + nowTime + "'";
            return SqlHelp.ExecuteReader(sql);
        }
        public void UpdateDiscount(string Expiration)
        {
            string sql = "UPDATE  Commodity SET  zkl = NULL,zksj=NULL WHERE spmc='" + Expiration + "'";
            SqlHelp.ExecuteSql(sql);
        }
    }
}
