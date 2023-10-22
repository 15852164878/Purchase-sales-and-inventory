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
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        Bsales b = new Bsales();
        public string SalesPeople;
        int cId;
        string cName;
        string cType;
        double cPrice;
        double drate;
        int sNumber;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btntj_Click(object sender, EventArgs e)
        {
            string commodityId = lblspid.Text;
            string cName = lblCommodityName.Text;
            string salesPerson = txtSalesPerson.Text;
            string salesPrice = txtUnitPriceOfAles.Text;
            int salesNumber = int.Parse(txtSalesVolumes.Text);
            int stockNumber = int.Parse(lblStockNumber.Text);
            if (salesNumber > stockNumber)
            {
                MessageBox.Show("你的货物不足,无法售出！");
                return;
            }
            string salesTime = txtSalesDate.Text;
            double Profit = double.Parse(txtProfit.Text);
            //销售记录
            b.AddTo(salesPerson, salesPrice, salesNumber, salesTime, Profit, commodityId);
            MessageBox.Show("已售出");
            //库存减少
            int nowStockNumber = stockNumber - salesNumber;
            b.NowStockNumber(nowStockNumber, cName);
            dgvCommodity.DataSource = b.CommodityName(txtInputCondition.Text).DefaultView;
            //库存不足
            if (b.StockAlarm() == "")
            {

            }
            else {
                if (MessageBox.Show(b.StockAlarm().Trim() + "库存不足！ 请及时补货！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Purchase p = new Purchase();
                    p.Show();
                }
            }

            //生成订单
            b.OrderAdd(cName, salesNumber, salesPrice);
         dgvOrder.DataSource = b.OrderAll().DefaultView;
            txtCopeWith.Text = b.OrderSettlement();

        }

        private void dgvxs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvCommodity.Columns[e.ColumnIndex].Name;
            if (o == "商品信息")
            {
                cId = int.Parse(dgvCommodity.Rows[e.RowIndex].Cells["商品编号"].Value.ToString());
                cName = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品名称"].Value.ToString());
                cType = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品类型"].Value.ToString());
                cPrice = double.Parse(dgvCommodity.Rows[e.RowIndex].Cells["商品价格"].Value.ToString());
                drate = double.Parse(dgvCommodity.Rows[e.RowIndex].Cells["折扣率"].Value.ToString());
                sNumber = int.Parse(dgvCommodity.Rows[e.RowIndex].Cells["库存数量"].Value.ToString());
                lblspid.Text = cId.ToString();
                lblCommodityName.Text = cName;
                lblsplx.Text = cType;
                lblStockNumber.Text = sNumber.ToString();
                lblCommodityOriginal.Text = (cPrice * 2).ToString();
                double cOriginal =double.Parse(lblCommodityOriginal.Text);//商品原价
                //查不到会出现异常
                try {
                    double Discount = double.Parse(b.Discount(cName));//折扣率
                    txtUnitPriceOfAles.Text = (Discount * cOriginal).ToString();
                    double UnitPriceOfAles = double.Parse(txtUnitPriceOfAles.Text);
                    txtProfit.Text = (UnitPriceOfAles - cPrice).ToString();
                }
                catch
                {
                    txtUnitPriceOfAles.Text = (1 * cOriginal).ToString();
                    double UnitPriceOfAles = double.Parse(txtUnitPriceOfAles.Text);
                    txtProfit.Text = (UnitPriceOfAles - cPrice).ToString();
                }
               
            }
        }

        private void btncx_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String str; //获取系统时间
            str = Convert.ToString(DateTime.Now);
            txtSalesDate.Text = str;
        }

        private void sales_Load(object sender, EventArgs e)
        {
            txtSalesPerson.Text = SalesPeople;
            txtSalesPerson.Enabled = false;
            txtSalesDate.Enabled = false;
            txtUnitPriceOfAles.Enabled = false;
            txtProfit.Enabled = false;

           string nowTime= DateTime.Now.ToString();
           string Expiration=b.Now(nowTime); //折扣到期
            b.UpdateDiscount(Expiration);
           MessageBox.Show(Expiration.Trim()+"折扣到期！已恢复原价！");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbljhjg_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
             string inputcondition= txtInputCondition.Text;
                dgvCommodity.DataSource = b.CommodityName(inputcondition).DefaultView;
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         

           double CopeWith = double.Parse(txtCopeWith.Text);
            double ActualPayment = double.Parse(txtActualPayment.Text);
            lblChange.Text = (ActualPayment - CopeWith).ToString();
            b.Delete();

    }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }

        private void lblCommodityOriginal_Click(object sender, EventArgs e)
        {

        }
    }
}
