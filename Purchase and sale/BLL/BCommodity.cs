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
    public class BCommodity
    {
        DCommodity d = new DCommodity();
        /// <summary>
        /// 查询商品表所有商品信息
        /// </summary>
        /// <returns>返回商品表里所有信息</returns>
        public DataTable ShowAll()
        {
           return  d.ShowAll().Tables[0];
        }
        /// <summary>
        /// 在商品表里添加数据
        /// </summary>
        /// <param name="cName">商品名称</param>
        /// <param name="cType">商品类型</param>
        /// <param name="cPrice">商品价格</param>
        public void AddTo(string cName, string cType, string cPrice,int mid)
        {
            d.AddTo(cName, cType, cPrice, mid);
        }
        /// <summary>
        /// 修改商品表里数据
        /// </summary>
        /// <param name="cId">商品编号</param>
        /// <param name="cName">商品名称</param>
        /// <param name="cType">商品类型</param>
        /// <param name="cPrice">商品价格</param>
        public void ToUpdate(int cId, string cName, string cType, string cPrice, int cmId)
        {
            d.ToUpdate(cId, cName, cType, cPrice, cmId);
        }
        /// <summary>
        /// 删除商品表里数据
        /// </summary>
        /// <param name="cId">商品编号</param>
        public void Delete(int cId)
        {
            d.Delete(cId);
        }
        /// <summary>
        /// 按商品编号查询
        /// </summary>
        /// <param name="cId">商品编号</param>
        /// <returns></returns>
        public DataTable CommodityNumber(int cId)
        {
            return d.CommodityNumber(cId).Tables[0];
        }
        /// <summary>
        /// 按商品名称查询
        /// </summary>
        /// <param name="cName">商品名称</param>
        /// <returns></returns>
        public DataTable CommodityName(string cName)
        {
            return d.CommodityName(cName).Tables[0];
        }
        /// <summary>
        /// 按商品类型查询
        /// </summary>
        /// <param name="cType">商品类型</param>
        /// <returns></returns>
        public DataTable CommodityType(string cType)
        {
            return d.CommodityType(cType).Tables[0];
        }
        /// <summary>
        /// 按商品价格查询
        /// </summary>
        /// <param name="cPrice">商品价格</param>
        /// <returns></returns>
        public DataTable CommodityPrice(string cPrice)
        {
            return d.CommodityPrice(cPrice).Tables[0];
        }
        /// <summary>
        /// 返回查询到的表
        /// </summary>
        /// <param name="cName">商品名称</param>
        /// <param name="cType">商品类型</param>
        /// <param name="cPrice">商品价格</param>
        /// <param name="mId"><厂家编号/param>
        /// <returns>查询到的表</returns>
        public DataTable Query(string cName,string cType,string cPrice,string mId)
        {
            return d.Query(cName, cType, cPrice, mId).Tables[0];
        }
    }
}
