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
    public class BMainForm
    {
        
        DMainForm d = new DMainForm();
        /// <summary>
        ///  读取员工没有的权限
        /// </summary>
        /// <param name="Jurisdiction">员工账号</param>
        /// <returns>返回员工没有的权限</returns>
        public string NoEmpowerment(string Jurisdiction)
        {
            string jh = "";
            SqlDataReader jhj = d.NoEmpowerment(Jurisdiction);
            if (jhj.Read())
            {
                jh = (jhj[0].ToString());
            }
            return jh;
        }
        /// <summary>
        /// 管理员
        /// </summary>
        /// <param name="aNumber"></param>
        /// <param name="aPassword"></param>
        /// <returns></returns>
        public string aOperator(string aNumber, string aPassword)
        {
            string jh = "";
            SqlDataReader jhj = d.aOperator(aNumber,aPassword);
            if (jhj.Read())
            {
                jh = (jhj[0].ToString());
            }
            return jh;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eNumber"></param>
        /// <param name="ePassword"></param>
        /// <returns></returns>
        public string eOperator(string eNumber, string ePassword)
        {
            string jh = "";
            SqlDataReader jhj = d.eOperator(eNumber, ePassword);
            if (jhj.Read())
            {
                jh = (jhj[0].ToString());
            }
            return jh;
        }
        public string StockAlarm()
        {
            string sql = "";
            SqlDataReader a = d.StockAlarm();
            if (a.Read())
            {
                sql = a[0].ToString();
            }
            return sql;
        }
        /// <summary>
        /// 现在的时间
        /// </summary>
        /// <param name="nowTime"></param>
        /// <returns>现在的时间</returns>
        public string Now(string nowTime)
        {
            string sql = "";
            SqlDataReader a = d.Now(nowTime);
            if (a.Read())
            {
                sql = a[0].ToString();

            }
            return sql;

        }
        /// <summary>
        /// 折扣率与折扣时间改为null
        /// </summary>
        /// <param name="Expiration"></param>
        public void UpdateDiscount(string Expiration)
        {
            d.UpdateDiscount(Expiration);
        }
    }
}
