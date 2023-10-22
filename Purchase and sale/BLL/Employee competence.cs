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
  public class BEmployee_competence
    {
        DEmployee_competence D = new DEmployee_competence();
       /// <summary>
       /// 修改未分配权限
       /// </summary>
       /// <param name="sUnallocated">未分配</param>
       /// <param name="sId">员工编号</param>
       /// <param name="sName">员工姓名</param>
        public void ModifyUnassigned(string sUnallocated, string sId, string sName)
        {
            D.ModifyUnassigned(sUnallocated, sId, sName);
        }
     /// <summary>
     /// 修改已分配的权限
     /// </summary>
     /// <param name="sAssigned">已分配</param>
     /// <param name="sId">员工编号</param>
     /// <param name="sName">员工姓名</param>
        public void ModifyAssigned(string sAssigned, string sId, string sName)
        {
            D.ModifyAssigned(sAssigned, sId, sName);
        }
     /// <summary>
     /// 查询未分配权限
     /// </summary>
     /// <param name="sId">员工编号</param>
     /// <returns>查询到的未分配权限</returns>
        public string QueryUnassigned(string sId)
        {
            string jh = "";
            SqlDataReader jhj = D.QueryUnassigned(sId);
            if (jhj.Read())
            {
                jh = (jhj[0].ToString());
            }
            return jh;
        }
      /// <summary>
      /// 查询已分配权限
      /// </summary>
      /// <param name="sId">员工编号</param>
      /// <returns>查询到的已分配权限</returns>
        public string QueryAssigned(string sId)
        {
             string jh = "";
            SqlDataReader jhj = D.QueryAssigned(sId);
            if (jhj.Read())
            {
                jh = (jhj[0].ToString());
            }
            return jh;
        }
    }
}
