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
   public  class DPquery
    {
        public void Update(int pId, string pPeople, string pNumber, string pPrice, string jhpTimes, int cId, int mId)
        {
            string sql = "UPDATE Purchases SET jhr='" + pPeople + "', jhsl='" + pNumber + "', jhjg='" + pPrice + "', jhsj='" + jhpTimes + "',spid='"+ cId + "',cjid='" + mId + "'  WHERE jhid='"+ pId + "'"; 
              SqlHelp.ExecuteSql(sql);
        }
        public DataSet ShowAll()
        {
            string sql = "SELECT * FROM Purchases";
            return SqlHelp.Query(sql);
        }
        public void Delete(int pId)
        {
            string sql = "DELETE FROM Purchases  WHERE jhid=" + pId + " ";
            SqlHelp.ExecuteSql(sql);
        }
        public DataSet PurchaseId(int pId)
        {
            string sql = "SELECT * FROM Purchases WHERE jhid='" + pId + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet PurchasePeople(string pPeople)
        {
            string sql = "SELECT * FROM Purchases WHERE jhr='" + pPeople + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet purchaseNumber(string pNumber)
        {
            string sql = "SELECT * FROM Purchases WHERE jhsl='" + pNumber + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet PurchasePrice(string pPrice)
        {
            string sql = "SELECT * FROM Purchases WHERE jhjg='" + pPrice + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet Query( string pId, string pPeople,string pNumber, string pPrice, string pTime,string cId, string mId)
        {
            string sql = "SELECT * FROM [Purchase and sale].[dbo].[Purchases] WHERE jhid LIKE '%" + pId+"%' AND jhr LIKE '%"+pPeople+"%' AND jhsl LIKE '%"+pNumber+"%' AND  jhjg LIKE  '%"+pPrice+"%' AND jhsj LIKE '%"+pTime+"%'AND spid LIKE '%"+cId+"%' AND cjid LIKE '%"+mId+"%' ";
            return SqlHelp.Query(sql);
        }
    }
}
