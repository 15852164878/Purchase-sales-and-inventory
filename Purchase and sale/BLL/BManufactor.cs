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
    public class BManufactor
    {
        DManufactor d = new DManufactor();

        public void AddTo(string mName, string mPeople, long mTelephone, string mAddress)
        {
            d.AddTo(mName, mPeople, mTelephone, mAddress);
        }
        public DataTable ShowAll()
        {
            return d.ShowAll().Tables[0];
        }
        public void Update(int mid, string mName, string mPeople, long mTelephone, string mAddress)
        {
            d.Update(mid, mName, mPeople, mTelephone, mAddress);
        }
        public void Delete(int cjid)
        {
            d.Delete(cjid);
        }
        public DataTable Query(string mName,string mPeople,string mTelephone,string mAddress)
        {
            return d.Query(mName, mPeople, mTelephone, mAddress).Tables[0];
          }
      
    }
}
