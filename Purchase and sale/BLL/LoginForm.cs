using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
  public  class BLogin
    {
        DLogin d = new DLogin();
        /// <summary>
        ///  是否从管理员表里查到记录
        /// </summary>
        /// <param name="zh">账号</param>
        /// <param name="pass">密码</param>
        /// <returns>有记录返回true 否则,返回false</returns>
        public bool UserAdministrator(string accountNumber, string passWord)
        {
        if(d.UserAdministrator(accountNumber, passWord).Tables[0].Rows.Count>0)
        {
                return true;
         }
        else
        {
                return false;
         }

        }
        /// <summary>
        /// 是否从员工表里查到记录
        /// </summary>
        /// <param name="zh">账号</param>
        /// <param name="pass">密码</param>
        /// <returns>有记录返回true 否则,返回false</returns>
        public bool UserStaff(string accountNumber, string passWord)
        {
            if (d.UserStaff(accountNumber, passWord).Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        
    }
}
