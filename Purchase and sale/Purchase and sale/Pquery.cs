using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Purchase_and_sale
{
    public partial class Pquery : Form
    {
        public Pquery()
        {
            InitializeComponent();
        }
        BPquery b = new BPquery();
     
        int   pId;
        string pPeople;
        string pNumber;
        string pPrice;
        string pTime;
        int cId;
        int mId;

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvStockPurchase.Columns[e.ColumnIndex].Name;
            if (o == "修改")
            {
                pId = int.Parse(dgvStockPurchase.Rows[e.RowIndex].Cells["进货编号"].Value.ToString());
                pPeople = string.Concat(dgvStockPurchase.Rows[e.RowIndex].Cells["进货人"].Value.ToString());
                pNumber = string.Concat(dgvStockPurchase.Rows[e.RowIndex].Cells["进货数量"].Value.ToString());
                pPrice = string.Concat(dgvStockPurchase.Rows[e.RowIndex].Cells["进货价格"].Value.ToString());
                pTime = string.Concat(dgvStockPurchase.Rows[e.RowIndex].Cells["进货时间"].Value.ToString());
                cId = int.Parse(dgvStockPurchase.Rows[e.RowIndex].Cells["商品编号"].Value.ToString());
                mId = int.Parse(dgvStockPurchase.Rows[e.RowIndex].Cells["厂家编号"].Value.ToString());
                b.Update(pId, pPeople, pNumber, pPrice, pTime, cId, mId); 
                dgvStockPurchase.AutoGenerateColumns = false;
                dgvStockPurchase.DataSource = b.ShowAll().DefaultView;
                MessageBox.Show("修改成功");

            }
            if (o == "删除")
            {
                pId = int.Parse(dgvStockPurchase.Rows[e.RowIndex].Cells["进货编号"].Value.ToString());
                pPeople = string.Concat(dgvStockPurchase.Rows[e.RowIndex].Cells["进货人"].Value.ToString());
                pNumber = string.Concat(dgvStockPurchase.Rows[e.RowIndex].Cells["进货数量"].Value.ToString());
                pPrice = string.Concat(dgvStockPurchase.Rows[e.RowIndex].Cells["进货价格"].Value.ToString());
                pTime = string.Concat(dgvStockPurchase.Rows[e.RowIndex].Cells["进货时间"].Value.ToString());
                cId = int.Parse(dgvStockPurchase.Rows[e.RowIndex].Cells["商品编号"].Value.ToString());
                mId = int.Parse(dgvStockPurchase.Rows[e.RowIndex].Cells["厂家编号"].Value.ToString());

                if (MessageBox.Show("确定删除此条记录吗", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    b.Delete(pId);
                    MessageBox.Show("删除成功");
                    dgvStockPurchase.AutoGenerateColumns = false;
                    dgvStockPurchase.DataSource = b.ShowAll().DefaultView;
                }
                else
                {
                    return;
                }
            }
            
       }

        private void btn_Click(object sender, EventArgs e)
        {
        string pId=txtPurchaseId.Text;
          string pPeople=  txtPurchasePeople.Text;
          string pNumber=txtPurchaseNumber.Text;
           string pPrice= txtPurchasePrice.Text;
           string pTime= txtPurchaseTime.Text;
           string cId=txtCommodityId.Text;
           string mId=txtManufactorId.Text;
            dgvStockPurchase.DataSource = b.Query(pId, pPeople, pNumber, pPrice, pTime, cId, mId).DefaultView;



            //int PurchaseId= int.Parse(txtPurchaseId.Text);
            // string PurchasePeople = txtPurchasePeople.Text;
            // int PurchaseNumber = int.Parse(txtPurchaseNumber.Text);
            //  double     txtPurchasePrice.Text;
            // if (Condition == "")
            // {
            //     MessageBox.Show("请选择查询条件");
            // }
            // if (Condition == "查询所有")
            // {
            //     dgvStockPurchase.AutoGenerateColumns = false;
            //     //  dgvjh.DataSource = null;
            //     dgvStockPurchase.DataSource = b.ShowAll().DefaultView;
            // }
            // if (txtPurchaseId.Text! = "")
            // {
            //     dgvStockPurchase.DataSource = b.PurchaseId(int.Parse(inputCondition)).DefaultView;

            // }
            // if (Condition == "进货人")
            // {
            //     dgvStockPurchase.DataSource = b.PurchasePeople(inputCondition).DefaultView;

            // }
            // if (Condition == "进货数量")
            // {
            //     dgvStockPurchase.DataSource = b.purchaseNumber(inputCondition).DefaultView;
            // }
            // if (Condition == "进货价格")
            // {
            //     dgvStockPurchase.DataSource = b.PurchasePrice(inputCondition).DefaultView;
            // }
            // if (Condition == "进货时间")
            // {
            //     dgvStockPurchase.DataSource = b.PurchaseTime(inputCondition).DefaultView;
            // }
            // if (Condition == "商品编号")
            // {
            //     dgvStockPurchase.DataSource = b.CommodityId(int.Parse(inputCondition)).DefaultView;
            // }
            // if (Condition == "厂家编号")
            // {
            //     dgvStockPurchase.DataSource = b.ManufactorId(int.Parse(inputCondition)).DefaultView;
            // }

        }

        private void Pquery_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
