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
  public  class BEmployee_inforrmation
    {
        DEmployee_inforrmation d = new DEmployee_inforrmation();
        /// <summary>
        /// 查询所有员工的信息
        /// </summary>
        /// <returns>返回所有员工的信息</returns>
        public DataTable ShowAll()
        {
            return d.ShowAll().Tables[0];
        }
        /// <summary>
        /// 按员工姓名查询
        /// </summary>
        /// <param name="sName">员工姓名</param>
        /// <returns></returns>
        public DataTable EmployeeName(string sName)
        {
            return d.EmployeeName(sName).Tables[0];
        }
        /// <summary>
        /// 按员工性别查询
        /// </summary>
        /// <param name="sSex">员工性别</param>
        /// <returns></returns>
        public DataTable EmployeeGender(string sSex)
        {
           return d.EmployeeGender(sSex).Tables[0];
        }
        /// <summary>
        /// 按员工年龄查询
        /// </summary>
        /// <param name="sAge">员工年龄</param>
        /// <returns></returns>
        public DataTable EmployeeAge(string sAge)
        {
           return d.EmployeeAge(sAge).Tables[0];
        }
        /// <summary>
        /// 修改表中数据
        /// </summary>
        /// <param name="sId">员工编号</param>
        /// <param name="sName">员工姓名</param>
        /// <param name="sSex">员工性别</param>
        /// <param name="sAge">员工年龄</param>
        /// <param name="sCount">员工账号</param>
        /// <param name="sPass">员工密码</param>
        public void Modify(int sId, string sName, string sSex, string sAge, int sCount, string sPass)
        {
            d.Modify(sId, sName, sSex, sAge, sCount, sPass);
        }
        /// <summary>
        /// 删除表中数据
        /// </summary>
        /// <param name="sId">员工编号</param>
        public void Delete(int sId)
        {
            d.Delete(sId);
        }
        public DataTable Query(string  eName,string  eSex,string  eAge,int  aNumber,string  Pass)
        {
          return  d.Query( eName, eSex, eAge, aNumber, Pass).Tables[0];
        }

    }
}
