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
   public class DCommodity
    {
       
        public DataSet ShowAll( )
        {
            string sql = "SELECT  spid,spmc,splx,spjg,cjid FROM Commodity";
            return SqlHelp.Query(sql);
        }
         public void AddTo(string cName, string cType, string cPrice,int mid)
        {
            string sql = "INSERT INTO [Purchase and sale].[dbo].[Commodity] ([spmc],[splx],[spjg],[cjid])   VALUES('" + cName + "','"+ cType + "','"+ cPrice + "','"+ mid + "')";
            SqlHelp.ExecuteSql(sql);
         }
       
        public void ToUpdate(int cId, string cName, string cType, string cPrice ,int mId)
        {
            string sql = "UPDATE Commodity SET spmc='"+ cName + "',splx='"+ cType + "',spjg='"+ cPrice + "',cjid='"+mId+"' WHERE spid=" + cId + "";
            SqlHelp.ExecuteSql(sql);
        }
        public void Delete(int cId)
        {
            string sql = "DELETE FROM Commodity WHERE spid=" + cId + " ";
            SqlHelp.ExecuteSql(sql);
        }
        public DataSet CommodityNumber(int cId)
        {
            string sql = "SELECT  spid,spmc,splx,spjg FROM Commodity WHERE spid='" + cId + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet CommodityName(string cName)
        {
            string sql = "SELECT  spid,spmc,splx,spjg FROM Commodity WHERE spmc='" + cName + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet CommodityType(string cType)
        {
            string sql = "SELECT  spid,spmc,splx,spjg FROM Commodity WHERE splx='" + cType + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet CommodityPrice(string cPrice)
        {
            string sql = "SELECT  spid,spmc,splx,spjg FROM Commodity WHERE spjg='" + cPrice + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet Query(string cName, string cType, string cPrice, string mId)
        {
            string sql = "SELECT spid,spmc,splx,spjg,cjid FROM Commodity WHERE  spmc LIKE '%"+cName+"%' AND splx LIKE '%"+ cType + "%' AND  spjg LIKE '%" + cPrice+ "%'  AND cjid LIKE '%" + mId + "%'";
            return SqlHelp.Query(sql);
        }
        }
}
