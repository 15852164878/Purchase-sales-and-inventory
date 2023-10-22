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
   public class Dsales
    {
        public void  NowStockNumber(int nowStockNumber, string cName)
        {
            string sql = " UPDATE Stock SET  kcsl = '" + nowStockNumber + "' WHERE spmc='"+ cName + "'";
            SqlHelp.ExecuteSql(sql);
        }
        public void AddTo(string salesPerson, string salesPrice, int salesNumber, string salesTime, double Profit, string commodityId)
        {
            string sql = "INSERT INTO  sales(xsr,xsdj ,xssl,xsrq ,xsyl,spid)  VALUES ('" + salesPerson + "', '" + salesPrice + "','" + salesNumber + "','" + salesTime + "','"+ Profit + "','" + commodityId + "')";
            SqlHelp.ExecuteSql(sql);
        }
        public DataSet CommodityName(string cName)
        {
            string sql = "SELECT  Commodity.spid,Commodity.spmc,Commodity.splx,Commodity.spjg,Commodity.zkl,Stock.kcsl FROM Commodity  JOIN Stock  ON Commodity.spmc= Commodity.spmc WHERE  Stock.spmc ='" + cName + "' AND Commodity.spmc= '" + cName + "'";
            return SqlHelp.Query(sql);
        }
        public SqlDataReader StockAlarm()
        {
            string sql = "SELECT spmc FROM Stock WHERE kcsl<kcbj ";
            return SqlHelp.ExecuteReader(sql);
        }
        public SqlDataReader Discount(string cName)
        {
            string sql = "SELECT zkl FROM Commodity WHERE spmc='"+cName+"'";
            return SqlHelp.ExecuteReader(sql);
        }
        public void OrderAdd(string cName,int salesNumber,string salesPrice)
        {
            string sql = "INSERT INTO [Purchase and sale].[dbo].[Order]([sppm],[sl],[je])   VALUES('"+ cName + "','"+ salesNumber + "','"+ salesPrice + "')";
            SqlHelp.ExecuteSql(sql);
        }
        public DataSet OrderAll()
        {
            string sql = "SELECT sppm,sl,je FROM [Purchase and sale].[dbo].[Order] ";
            return SqlHelp.Query(sql);
        }
        public SqlDataReader OrderSettlement()
        {
            string sql = "SELECT sum(je) FROM [Purchase and sale].[dbo].[Order]";
            return SqlHelp.ExecuteReader(sql);
        }
        public void Delete()
        {
            string sql = "DELETE  FROM[Purchase and sale].[dbo].[Order]";
            SqlHelp.ExecuteSql(sql);
        }
        public SqlDataReader Now(string nowTime )
        {
            string sql = "SELECT spmc FROM [Purchase and sale].[dbo].[Commodity] WHERE zksj <= '"+ nowTime + "'";
           return SqlHelp.ExecuteReader(sql);
        }
       public void UpdateDiscount(string Expiration)
        {
            string sql = "UPDATE  Commodity SET  zkl = '1' WHERE spmc='" + Expiration + "'";
            SqlHelp.ExecuteSql(sql);
        }
    }
}
