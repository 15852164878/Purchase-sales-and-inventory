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
   public class BSalequery
    {
      
        DSalequery d = new DSalequery();
        /// <summary>
        /// 按销售编号查询
        /// </summary>
        /// <param name="id">销售编号</param>
        public void sc(int id)
        {
            d.sc(id);
        }
        /// <summary>
        /// 修改表里内容
        /// </summary>
        /// <param name="xsid">销售编号</param>
        /// <param name="xsr">销售人</param>
        /// <param name="xsdj">销售单价</param>
        /// <param name="xssl">销售数量</param>
        /// <param name="xsrq">销售日期</param>
        /// <param name="xsyl">盈利</param>
        /// <param name="spid">商品编号</param>
        public void Update(int sId, string sPeople, string sPrice, string sNumber, string sTime, double Profit, int cId)
        {
            d.Update(sId, sPeople, sPrice, sNumber, sTime, Profit, cId);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable ShowAll()
        {
            return d.ShowAll().Tables[0];
            
        }
        /// <summary>
        ///销售经理表 多条件查询
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="sPeople"></param>
        /// <param name="sPrice"></param>
        /// <param name="sNumber"></param>
        /// <param name="sTime"></param>
        /// <param name="sProfit"></param>
        /// <param name="cId"></param>
        /// <returns></returns>
        public  DataTable Query( string sId,string sPeople,string sPrice,string sNumber,string sTime,string sProfit,string cId)
        {
          return d.Query(sId, sPeople, sPrice, sNumber, sTime, sProfit, cId).Tables[0];
        }
   
    }
}
