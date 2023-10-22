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
  public  class DSalequery
    {
        /// <summary>
        ///销售记录表 删除
        /// </summary>
        /// <param name="id">销售编号</param>
        public void sc(int id)
        {
            string sql = "DELETE FROM sales WHERE xsid=" + id + " ";
            SqlHelp.ExecuteSql(sql);
        }
        /// <summary>
        /// 销售记录表更新
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="sPeople">销售人</param>
        /// <param name="sPrice">商品价格</param>
        /// <param name="sNumber">显示数量</param>
        /// <param name="sTime">销售时间</param>
        /// <param name="Profit">盈利</param>
        /// <param name="cId">商品编号</param>
        public void Update(int sId, string sPeople, string sPrice, string sNumber, string sTime, double Profit, int cId)
        {
            string sql = "UPDATE sales SET xsr ='" + sPeople + "' ,xsdj = '" + sPrice + "', xssl = '" + sNumber + "', xsrq ='" + sTime + "',xsyl='"+ Profit + "',spid ='" + cId + "' WHERE xsid=" + sId + "";
            SqlHelp.ExecuteSql(sql);

        }
        /// <summary>
        /// 查询所有销售记录
        /// </summary>
        /// <returns></returns>
        public DataSet ShowAll()
        {
            string sql = "SELECT * FROM   sales";
            return SqlHelp.Query(sql);
        }
        /// <summary>
        /// 多条件查询
        /// </summary>
        /// <param name="sId">销售编号</param>
        /// <param name="sPeople">销售人</param>
        /// <param name="sPrice">销售价格</param>
        /// <param name="sNumber">销售数量</param>
        /// <param name="sTime">销售时间</param>
        /// <param name="sProfit">盈利</param>
        /// <param name="cId">商品编号</param>
        /// <returns></returns>
     
        public DataSet Query(string sId, string sPeople, string sPrice, string sNumber, string sTime, string sProfit,string cId)
        {
            string sql = "SELECT * FROM  sales WHERE xsid LIKE '%" + sId + "%' AND xsr LIKE '%"+sPeople+"%' AND xsdj LIKE '%"+sPrice+"%' AND xssl LIKE '%"+sNumber+"%' AND xsrq LIKE '%"+sTime+"%' AND xsyl LIKE '%"+sProfit+"%' AND spid LIKE '%"+cId+"%' ";
            return SqlHelp.Query(sql);
        }
        
        }
}
