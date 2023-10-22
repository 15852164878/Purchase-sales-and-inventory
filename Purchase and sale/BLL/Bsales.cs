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
   public class Bsales
    {
        Dsales d = new Dsales();
        /// <summary>
        ///查询 库存数量
        /// </summary>
        /// <param name="nowStockNumber"></param>
        /// <param name="cName"></param>
        public void NowStockNumber(int nowStockNumber, string cName)
        {
            d.NowStockNumber(nowStockNumber, cName);
        }
   
     
        /// <summary>
        /// 添加销售记录
        /// </summary>
        /// <param name="salesPerson"></param>
        /// <param name="salesPrice"></param>
        /// <param name="salesNumber"></param>
        /// <param name="salesTime"></param>
        /// <param name="Profit"></param>
        /// <param name="commodityId"></param>
        public void AddTo(string salesPerson, string salesPrice, int salesNumber, string salesTime, double Profit, string commodityId)
        {
            d.AddTo(salesPerson, salesPrice, salesNumber, salesTime, Profit, commodityId);
        }
    
    
        /// <summary>
        /// 商品表查询
        /// </summary>
        /// <param name="cName">条件</param>
        /// <returns></returns>
        public DataTable CommodityName(string cName)
        {
            return d.CommodityName(cName).Tables[0];
        }
        public string StockAlarm()
        {
            string sql ="";
            SqlDataReader a = d.StockAlarm();
            if (a.Read())
            {
                sql =a[0].ToString();
            }
            return sql;
        }
        /// <summary>
        /// 折扣率查询
        /// </summary>
        /// <param name="cName"></param>
        /// <returns></returns>
        public string Discount(string cName)
        {
            string sql ="";
            SqlDataReader a = d.Discount(cName);
            if (a.Read())
            {
                sql = a[0].ToString();
             
            }
           return sql;

        }
        /// <summary>
        /// 订单表添加
        /// </summary>
        /// <param name="cName"></param>
        /// <param name="salesNumber"></param>
        /// <param name="salesPrice"></param>
        public void OrderAdd(string cName, int salesNumber, string salesPrice)
        {
            d.OrderAdd(cName, salesNumber, salesPrice);
        }
        /// <summary>
        /// 查询订单表
        /// </summary>
        /// <returns></returns>
        public DataTable OrderAll()
        {
          return  d.OrderAll().Tables[0];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string OrderSettlement()
        {
            string sql = "";
            SqlDataReader a = d.OrderSettlement();
            if (a.Read())
            {
                sql = a[0].ToString();

            }
            return sql;
        }
        public void Delete()
        {
            d.Delete();
        }
        /// <summary>
        /// 折扣时间
        /// </summary>
        /// <param name="nowTime"></param>
        /// <returns></returns>
     public string  Now(string nowTime)
        {
            string sql = "";
            SqlDataReader a = d.Now(nowTime);
            if (a.Read())
            {
                sql = a[0].ToString();

            }
            return sql;

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Expiration"></param>
        public void UpdateDiscount(string Expiration)
        {
            d.UpdateDiscount(Expiration);
        }
        }
}
