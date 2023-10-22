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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        BPurchase b = new BPurchase();
        public string Purchaser;

        int mId;
        string mName;
        string mPeople;
        int mAddress;
        string mTelephone;

        string cId;
        string cName;
        string cType;
        string cPrice;
        string cManufacturer;


        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvjh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvCommodity.Columns[e.ColumnIndex].Name;
            if (o == "商品信息")
            {
                cId = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品编号"].Value.ToString());
                cName = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品名称"].Value.ToString());
                cType = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品类型"].Value.ToString());
                cPrice = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品价格"].Value.ToString());
                cManufacturer = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品厂家"].Value.ToString());
                if (lblManufactorId.Text != cManufacturer)
                {
                    MessageBox.Show("改厂家没有此商品");
                    return;
                }
                lblCommodityId.Text = cId;
                lblCommodityName.Text = cName;
                lblCommodityType.Text = cType;
                txtPurchasePrice.Text = cPrice;
               
            }
        }
        private void btntj_Click(object sender, EventArgs e)
        {
            int cId = int.Parse(lblCommodityId.Text);
            if(cId.ToString()=="")
            {
                MessageBox.Show("请选择商品");
                return;
            }
            string cName = lblCommodityName.Text;
            string cType = lblCommodityType.Text;

            int mId = int.Parse(lblManufactorId.Text);
            if (mId.ToString() == "")
            {
                MessageBox.Show("请选择厂家");
                return;
            }
            string cPrice = txtPurchasePrice.Text;
            string Purchaser = txtPurchaser.Text;
            int pNumber = int.Parse(txtPurchaseNumber.Text);
            if(pNumber.ToString()=="")
            {
                MessageBox.Show("请填写进货数量！");
                return;
            }
            string pPrice = txtPurchasePrice.Text;
            string pTime = txtPurchaseTime.Text;
         
            //  int mId = int.Parse(lblCommodityId.Text);
            b.PurchaseAdd(Purchaser, pNumber, pPrice, pTime, cId,mId);
            MessageBox.Show("进货成功");

            string pWarehouse=txtWarehouse.Text;
        
       
                if (b.InventoryItemName(cName) == true)
               { 

             
                int commodityNumber = pNumber + b.CommodityNumber(cName);
                b.InventoryModification(cName, commodityNumber);
            }
                else
                {
           
              b.Inventoryaddition(pWarehouse, cName, pNumber, cId, mId);
            }

          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            String str; //获取系统时间
            str = Convert.ToString(DateTime.Now);
            txtPurchaseTime.Text = str;
        }
        private void Purchase_Load(object sender, EventArgs e)
        {
            txtPurchaser.Text = Purchaser;
            txtPurchaser.Enabled = false;
            txtPurchasePrice.Enabled = false;
            txtPurchaseTime.Enabled = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblmc_Click(object sender, EventArgs e)
        {

        }

        private void dgvcj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvManufactor.Columns[e.ColumnIndex].Name;
            if (o == "厂家信息")
            {
                mId = int.Parse(dgvManufactor.Rows[e.RowIndex].Cells["厂家编号"].Value.ToString());
                mName = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家名称"].Value.ToString());
                mPeople = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家负责人"].Value.ToString());
                mAddress = int.Parse(dgvManufactor.Rows[e.RowIndex].Cells["厂家电话"].Value.ToString());
                mTelephone = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家地址"].Value.ToString());
               lblManufactorId.Text= mId.ToString();
                lblManufactorName.Text= mName;
                lblManufactorPeople.Text= mPeople;
                lblManufacturerTelephone.Text= mAddress.ToString();
                lblManufactorAddress.Text= mTelephone;
            }
        }

        private void btncj_Click(object sender, EventArgs e)
        {
         string FactoryConditions= txtFactoryConditions.Text.Trim();
           dgvManufactor.DataSource = b.Query(FactoryConditions).DefaultView;
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            if (txtManufacturerId.Text == "")
            {
                MessageBox.Show("请输入厂家编号");
                return;
            }
            string mId = txtManufacturerId.Text;
            dgvCommodity.DataSource = b.ManufacturerId(mId).DefaultView;
        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }

        private void lblCommodityType_Click(object sender, EventArgs e)
        {

        }
    }
}
