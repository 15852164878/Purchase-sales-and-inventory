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
    public class DStock_alarm
    {
        public DataSet Query(string cWarehouse, string cName)
        {
            string sql = "SELECT kcmc,spmc,kcsl,kcbj FROM Stock WHERE kcmc LIKE '%" + cWarehouse + "%' AND spmc LIKE '%" + cName + "%'";
            return SqlHelp.Query(sql);
        }
        public DataSet QueryAll()
        {
            string sql = "SELECT kcmc, spmc,kcsl,kcbj  FROM Stock  ";
            return SqlHelp.Query(sql);
        }
        public SqlDataReader StockAlarm()
        {
            string sql = "SELECT spmc FROM Stock WHERE kcsl<kcbj ";
            return SqlHelp.ExecuteReader(sql);
        }
        public void Update(string cWarehouse, string cName, int sNumber, int aQuantity)
        {
            string sql = " UPDATE Stock SET kcmc='"+ cWarehouse + "', kcsl='"+ sNumber + "', kcbj='"+ aQuantity + "'   WHERE spmc= '" + cName + "'";
            SqlHelp.ExecuteSql(sql);
        }
}
}
