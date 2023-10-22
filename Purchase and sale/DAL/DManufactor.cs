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
    public class DManufactor
    {
        public void AddTo(string mName, string mPeople, long mTelephone, string mAddress)
        {
            string sql = "INSERT INTO Manufactor(cjmc,cjfzr,cjdh,cjdz)VALUES ('" + mName + "','" + mPeople + "','" + mTelephone + "','" + mAddress + "')";
            SqlHelp.ExecuteSql(sql);
        }
        public DataSet ShowAll()
        {
            string sql = " SELECT cjid,cjmc,cjfzr,cjdh,cjdz FROM Manufactor";
            return SqlHelp.Query(sql);
        }
        public void Update(int cjid, string cjmc, string cjfzr, long cjdh, string cjdz)
        {
            string sql = "UPDATE Manufactor SET cjmc = '" + cjmc + "',cjfzr = '" + cjfzr + "',cjdh = '" + cjdh + "',cjdz = '" + cjdz + "' WHERE cjid='" + cjid + "'";
            SqlHelp.ExecuteSql(sql);

        }
        public void Delete(int cjid)
        {
            string sql = "DELETE FROM[Purchase and sale].[dbo].[Manufactor]  WHERE cjid=" + cjid + "";
            SqlHelp.ExecuteSql(sql);
        }

        public DataSet Query(string mName, string mPeople, string mTelephone, string mAddress)
        {
            string sql = "SELECT cjid,cjmc,cjfzr,cjdh,cjdz FROM Manufactor WHERE cjmc LIKE '%"+ mName + "%' AND cjfzr LIKE '%"+ mPeople + "%' AND cjdh LIKE '%"+ mTelephone + "%' AND cjdz LIKE '%"+ mAddress + "%'";
            return SqlHelp.Query(sql);
        }

        }
}
