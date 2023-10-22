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
    public class BPquery
    {
        DPquery d = new DPquery();
        public void Update(int pId, string pPeople, string pNumber, string pPrice, string pTime, int cId, int mId)
        {
           d.Update(pId, pPeople, pNumber, pPrice, pTime, cId, mId);
        }
        public DataTable ShowAll()
        {
          return d.ShowAll().Tables[0];
            
        }
        public void Delete(int pId)
        {
            d.Delete(pId);
        }
        public DataTable PurchaseId(int pId)
        {
           return d.PurchaseId(pId).Tables[0];
        }
        public DataTable PurchasePeople( string pPeople)
        {
            DataTable B = d.PurchasePeople(pPeople).Tables[0];
            return B;
        }
        public DataTable purchaseNumber(string pNumber)
        {
            return d.purchaseNumber(pNumber).Tables[0];
        }
        public DataTable PurchasePrice( string pPrice)
        {
            DataTable B = d.PurchasePrice(pPrice).Tables[0];
            return B;
        }
        public DataTable Query(string pId,string pPeople,string pNumber,string pPrice,string pTime,string cId,string mId)
        {
           return d.Query(pId, pPeople, pNumber, pPrice, pTime, cId, mId).Tables[0];
        }

        }
}
