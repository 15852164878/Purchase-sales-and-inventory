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
   public class DStatistics
    {
        public DataSet ShowAII()
        {
            string sql = "SELECT s.kcmc,c.spmc,c.splx,c.spjg,s.kcsl,s.kcbj,m.cjmc,m.cjdz,m.cjdh,cjfzr FROM Stock s JOIN  Commodity c  ON c.spid=s.spid JOIN Manufactor m on s.cjid=m.cjid ";
            return SqlHelp.Query(sql);
        }
        /// <summary>
        /// 库存名查询
        /// </summary>
        /// <param name="sId"></param>
        /// <returns></returns>
        public DataSet StockName(string sId)
        {
            string sql = "SELECT s.kcmc,c.spmc,c.splx,c.spjg,s.kcsl,s.kcbj,m.cjmc,m.cjdz,m.cjdh,cjfzr FROM Stock s JOIN  Commodity c  ON c.spid=s.spid JOIN Manufactor m on s.cjid=m.cjid WHERE s.kcmc='" + sId + "'";
           return  SqlHelp.Query(sql);
        }
        public DataSet CommodityName(string cName)
        {
            string sql = "SELECT s.kcmc,c.spmc,c.splx,c.spjg,s.kcsl,s.kcbj,m.cjmc,m.cjdz,m.cjdh,cjfzr FROM Stock s JOIN  Commodity c  ON c.spid=s.spid JOIN Manufactor m on s.cjid=m.cjid WHERE c.spmc='" + cName + "'";
            return SqlHelp.Query(sql);
        }
        public SqlDataReader StockAlarm()
        {
            string sql = "SELECT spmc FROM Stock WHERE kcsl<kcbj ";
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
