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
  public  class BDiscount
    {
        DDiscount d = new DAL.DDiscount();
        /// <summary>
        /// 商品名称，和商品类型查询到的数据
        /// </summary>
        /// <param name="cName">商品名称</param>
        /// <param name="cType">商品类型</param>
        /// <returns>存按商品名称，商品类型查询到的数据的表</returns>
        public DataTable Query(string cName, string cType)
        {
            return d.Query(cName, cType).Tables[0];
        }
      /// <summary>
      /// 调用修改折扣方法
      /// </summary>
      /// <param name="cName">商品名称</param>
      /// <param name="Discount">折扣率</param>
      /// <param name="DiscountTime">折扣时间</param>
        public void Update(string cName, double Discount, string DiscountTime)
        {
            d.Update(cName, Discount, DiscountTime);
        }
        /// <summary>
        /// 超时的折扣
        /// </summary>
        /// <param name="nowTime"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 更新折扣率
        /// </summary>
        /// <param name="Expiration"></param>
        public void UpdateDiscount(string Expiration)
        {
            d.UpdateDiscount(Expiration);
        }
    }
}
