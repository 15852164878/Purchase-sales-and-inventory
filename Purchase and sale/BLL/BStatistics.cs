using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
   public class BStatistics
    {
        DStatistics d = new DStatistics();
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns>返回表</returns>
        public DataTable ShowAII()
        {
            return d.ShowAII().Tables[0];
        }
        /// <summary>
        /// 按库存编号查询
        /// </summary>
        /// <returns>返回表</returns>
        public DataTable StockName(string  sId)
        {
           return  d.StockName(sId).Tables[0];
        }
        /// <summary>
        /// 按商品名称查询
        /// </summary>
        /// <returns>返回表/returns>
        public DataTable CommodityName(string cName)
        {
          return    d.CommodityName(cName).Tables[0];
        }
 
        /// <summary>
        /// 按进货价格查询
        /// </summary>
        /// <returns>返回表</returns>
        public string StockAlarm()
        {
            string sql = "";
            SqlDataReader a = d.StockAlarm();
            if (a.Read())
            {
                sql = a[0].ToString();
            }
            return sql;
        }
        public string Now(string nowTime)
        {
            string sql = "";
            SqlDataReader a = d.Now(nowTime);
            if (a.Read())
            {
                sql = a[0].ToString();

            }
            return sql;

        }
        public void UpdateDiscount(string Expiration)
        {
            d.UpdateDiscount(Expiration);
        }

    }
}
