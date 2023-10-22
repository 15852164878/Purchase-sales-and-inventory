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
   public class DEmployee_registration
    {
        public void EmployeeAddition(string sName, string sSex, string sAge, int sAccount, string sPass)
        {
            string sql = "INSERT INTO Einformation(name,sex,age,account,pass)  VALUES('" + sName + "','" + sSex + "','" + sAge + "','" + sAccount + "','" + sPass + "')";
            SqlHelp.ExecuteSql(sql);
        }
    }
}
