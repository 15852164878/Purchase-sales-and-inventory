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
    public class DEmployee_inforrmation
    {
        public DataSet ShowAll()
        {
            string sql = "SELECT * FROM   Einformation";
            return SqlHelp.Query(sql);

        }

        public DataSet EmployeeName(string sName)
        {
            string sql = "SELECT * FROM   Einformation WHERE name='" + sName + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet EmployeeGender(string sSex)
        {
            string sql = "SELECT * FROM   Einformation WHERE sex='" + sSex + "'";
            return SqlHelp.Query(sql);
        }
        public DataSet EmployeeAge(string sAge)
        {
            string sql = "SELECT * FROM   Einformation WHERE age='" + sAge + "'";
            return SqlHelp.Query(sql);
        }

        public void Modify(int sId, string sName, string sSex, string sAge, int sCount, string sPass)
        {
            string sql = "UPDATE Einformation SET name ='" + sName + "' ,sex = '" + sSex + "', age = '" + sAge + "',account ='" + sCount + "',pass ='" + sPass + "'  WHERE id=" + sId + "";
            SqlHelp.ExecuteSql(sql);
        }
        public void Delete(int sId)
        {
            string sql = "DELETE FROM  Einformation  WHERE id=" + sId + " ";
            SqlHelp.ExecuteSql(sql);
        }
        public DataSet Query(string eName, string eSex, string eAge, int aNumber, string Pass)
        {
            string sql = "SELECT * FROM   Einformation WHERE  name LIKE '%" + eName + "%' AND  sex LIKE '%" + eSex + "%' AND age LIKE '%" + eAge + "%'AND  account LIKE '%" + aNumber + "%' AND pass LIKE '%" + Pass + "%'";
            return SqlHelp.Query(sql);
        }
    }
}

