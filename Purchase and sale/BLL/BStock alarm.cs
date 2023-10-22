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
    public class BStock_alarm
    {
        DStock_alarm d = new DStock_alarm();
        /// <summary>
        /// 库存查询 
        /// </summary>
        /// <param name="cWarehouse">仓库名</param>
        /// <param name="cName">商品名称</param>
        /// <returns>查到的表</returns>
        public DataTable Query(string cWarehouse, string cName)
        {
            return d.Query(cWarehouse, cName).Tables[0];
        }
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public DataTable QueryAll()
        {
            return d.QueryAll().Tables[0];
        }
        /// <summary>
        /// 修改库存报警
        /// </summary>
        /// <param name="cName"></param>
        /// <param name="cType"></param>
        /// <param name="sNumber"></param>
        /// <param name="aQuantity"></param>
        public void Update(string cName, string cType,int sNumber,int aQuantity)
        { 
         d.Update(cName, cType, sNumber, aQuantity);
         }
        /// <summary>
        /// 库存报警
        /// </summary>
        /// <returns></returns>
        public string StockAlarm()
        {
            string sql = "";
            SqlDataReader a = d.StockAlarm();
            if(a.Read())
            {
                sql = a[0].ToString();
            }
            return sql;
        }
    }
}
