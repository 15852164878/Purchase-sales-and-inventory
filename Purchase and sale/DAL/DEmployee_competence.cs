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
   public class DEmployee_competence
    {
        public int ModifyUnassigned(string sUnallocated, string sId, string sName)
        {
            string x = " UPDATE Einformation SET  wq = '" + sUnallocated + " '  WHERE id='" + sId + "' AND name='" + sName + "'";
           return SqlHelp.ExecuteSql(x);
        }
        public void ModifyAssigned(string sAllocated, string sId, string sName)
        {
            string x = " UPDATE Einformation  SET  yq = '" + sAllocated + "'  WHERE id='" + sId + "'AND name='" + sName + "'";
            SqlHelp.ExecuteSql(x);
        }
        public SqlDataReader QueryUnassigned(string sId)
        {
            string sql = "SELECT wq FROM Einformation WHERE id='" + sId + "'";
            return SqlHelp.ExecuteReader(sql);
        }
        public SqlDataReader QueryAssigned(string sId)
        {
            string sql = "SELECT yq FROM Einformation WHERE id='" + sId + "'";
            return SqlHelp.ExecuteReader(sql);
        }
    }
}
