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
    public class DPurchase
    {
        public  DataSet ManufacturerId(string mId)
        {
            string sql = "SELECT spid,spmc,splx,spjg,cjid FROM  Commodity WHERE cjid LIKE '%" + mId + "%' OR spmc LIKE '%"+ mId+ "%' ";
            return SqlHelp.Query(sql);
        }
       public void Inventoryaddition(string pWarehouse, string cName, int pNumber, int cId, int mId)
        {
             string sql = "INSERT INTO Stock(kcmc,spmc,kcsl,spid,cjid) VALUES ('"+pWarehouse+"','" + cName + "','"+ pNumber + "','" + cId+ "','"+ mId + "')";
            SqlHelp.ExecuteSql(sql);
        }
           

        public SqlDataReader CommodityNumber(string cName)
        {
            string sql = "SELECT kcsl FROM  Stock WHERE spmc='" + cName + "' ";
            return SqlHelp.ExecuteReader(sql);
        }
        public void InventoryModification(string cName,int commodityNumber)
        {
            string sql = "UPDATE Stock SET  kcsl ="+ commodityNumber + " WHERE spmc='"+ cName + "'";
            SqlHelp.ExecuteSql(sql);
        }
            
        public DataSet InventoryItemName(string cName)
        {
            string sql = "SELECT  spmc FROM Stock WHERE spmc='"+ cName + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet CommodityShowAll()
        {
            string sql = "SELECT  spid,spmc,splx,spjg,cjid FROM Commodity";
            return SqlHelp.Query(sql);
        }

        public DataSet ManufacturerDisplayAll()
        {
            string sql = "SELECT  cjid,cjmc,cjfzr,cjdh,cjdz FROM  Manufactor";
            return SqlHelp.Query(sql);
        }
        public void PurchaseAdd(string Purchaser, int pNumber, string pPrice, string pTime, int sId, int mId)
        {
            string sql = "INSERT INTO Purchases (jhr,jhsl,jhjg,jhsj,spid,cjid) VALUES ('" + Purchaser + "','" + pNumber + "','" + pPrice + "','" + pTime + "','" + sId + "','" + mId + "') ";
            SqlHelp.ExecuteSql(sql);
        }
        public DataSet commodityId(int cId)
        {
            string sql = "SELECT  spid,spmc,splx,spjg FROM  Commodity WHERE spid='" + cId + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet commodityName( string cName)
        {
            string sql = "SELECT  spid,spmc,splx,spjg FROM  Commodity WHERE spmc='" + cName + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet CommodityType(string cType)
        {
            string sql = "SELECT  spid,spmc,splx,spjg FROM  Commodity WHERE splx='" + cType + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet CommodityPrice(string cPrice)
        {
            string sql = "SELECT spid,spmc,splx,spjg FROM  Commodity WHERE spjg='" + cPrice + "'";
            return SqlHelp.Query(sql);
        }
       
        public DataSet Query(string query)
        {
            string sql = "SELECT  cjid,cjmc,cjfzr,cjdh,cjdz FROM  Manufactor WHERE  cjmc LIKE '%" + query + "%' or cjdz LIKE '%" + query + "%' OR cjfzr LIKE '%" + query + "%'OR cjdh LIKE '%" + query + " %'OR cjid like  '%" + query + "%' ";
            return SqlHelp.Query(sql);
            
        }
       
      
    }
}

