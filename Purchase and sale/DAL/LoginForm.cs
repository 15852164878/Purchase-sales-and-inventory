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
  public  class DLogin
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber">管理员账号</param>
        /// <param name="passWord">管理员密码</param>
        /// <returns></returns>
        public DataSet UserAdministrator(string accountNumber, string passWord)
        {
            string sql = " SELECT pass  FROM Administrators WHERE account='" + accountNumber + "' AND  pass='" + passWord + "'";
            return SqlHelp.Query(sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber">员工账号</param>
        /// <param name="passWord">员工密码</param>
        /// <returns></returns>
        public DataSet UserStaff(string accountNumber, string passWord)
        {
            string sql = " SELECT pass  FROM  Einformation  WHERE account='" + accountNumber + "' AND  pass='" + passWord + "'";
            return SqlHelp.Query(sql);
        }

    }
}
