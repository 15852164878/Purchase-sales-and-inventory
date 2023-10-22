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
  public  class DMainForm
    {
        /// <summary>
        /// 按照员工的账号查找员工没有的权限
        /// </summary>
        /// <param name="a">员工账号</param>
        /// <returns>返回执行</returns>
        public SqlDataReader NoEmpowerment(string Jurisdiction)
        {
            string sql = "SELECT wq FROM Einformation WHERE account='" + Jurisdiction + "'";
            return SqlHelp.ExecuteReader(sql);
        }
        public SqlDataReader aOperator(string aNumber,string aPassword)
        {
            string sql = "SELECT name FROM Administrators WHERE account='" + aNumber + "'AND pass='"+ aPassword + "'";
            return SqlHelp.ExecuteReader(sql);
        }
        public SqlDataReader eOperator(string eNumber, string ePassword)
        {
            string sql = "SELECT name FROM Einformation WHERE account='" + eNumber + "'AND pass='" + ePassword + "'";
            return SqlHelp.ExecuteReader(sql);
        }
        public SqlDataReader StockAlarm()
        {
            string sql = "SELECT spmc FROM Stock WHERE kcsl<bjsl ";
            return SqlHelp.ExecuteReader(sql);
        }
        public SqlDataReader Now(string nowTime)
        {
            string sql = "SELECT spmc FROM [Purchase and sale].[dbo].[Commodity] WHERE zksj <= '" + nowTime + "'";
            return SqlHelp.ExecuteReader(sql);
        }
        public void UpdateDiscount(string Expiration)
        {
            string sql = "UPDATE  Commodity SET  zkl = NULL, zksj=NULL WHERE spmc='" + Expiration + "'";
            SqlHelp.ExecuteSql(sql);
        }
    }
}
