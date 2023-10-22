using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class BPurchase
    {
        DPurchase d = new DPurchase();
        /// <summary>
        /// 厂家编号查询
        /// </summary>
        /// <param name="mId"></param>
        /// <returns></returns>
        public DataTable ManufacturerId(string mId)
        {
            return d.ManufacturerId(mId).Tables[0];
        }
        public void Inventoryaddition(string pWarehouse,string cName,int pNumber,int cId,int mId)
        {
            d.Inventoryaddition(pWarehouse, cName, pNumber,cId,mId);
        }
        public bool InventoryItemName(string cName)
        {
           if(d.InventoryItemName(cName).Tables[0].Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 查询商品名称
        /// </summary>
        /// <param name="cName"></param>
        /// <returns></returns>
        public int CommodityNumber(string cName)
        {
            int n=0;
            SqlDataReader s= d.CommodityNumber(cName);
            if(s.Read())
            {
              n = int.Parse(s[0].ToString());

            }
            return n;
        }
        public void InventoryModification(string cName, int commodityNumber)
        {
            d.InventoryModification(cName, commodityNumber);
        }
        public DataTable CommodityShowAll()
        {
            return d.CommodityShowAll().Tables[0];
        }
        public DataTable ManufacturerDisplayAll()
        {
            DataTable B = d.ManufacturerDisplayAll().Tables[0];
            return B;
        }
        public void PurchaseAdd(string Purchaser, int pNumber, string pPrice, string pTime, int sId, int mId)
        {
            d.PurchaseAdd(Purchaser, pNumber, pPrice, pTime, sId, mId);
        }

        public DataTable Query(string mName)
        {
            return d.Query(mName).Tables[0];
        }

    }
}
