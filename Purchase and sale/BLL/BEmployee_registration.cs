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
   public  class BEmployee_registration
    {
        DEmployee_registration d = new DEmployee_registration();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string sex(bool result, bool n)
        {
            string ssex = "";
            if (result == true)
            {
                ssex = "男";
            }
            if (n == true)
            {
                ssex = "女";
            }
            return ssex;
        }
        /// <summary>
        /// 员工添加
        /// </summary>
        /// <param name="sName"></param>
        /// <param name="sSex"></param>
        /// <param name="sAge"></param>
        /// <param name="sAccount"></param>
        /// <param name="sPass"></param>
        public void EmployeeAddition(string sName, string sSex, string sAge, int sAccount, string sPass)
        {
            d.EmployeeAddition(sName, sSex, sAge, sAccount, sPass);
        }

    }
}
