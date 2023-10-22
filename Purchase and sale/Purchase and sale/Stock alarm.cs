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
    public partial class Stock_alarm : Form
    {
        public Stock_alarm()
        {
            InitializeComponent();
        }
        BStock_alarm b = new BStock_alarm();
        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string cName = txtCommodityName.Text;
            string cWarehouse = txtWarehouses.Text;
            dgvStock.DataSource = b.Query(cWarehouse, cName).DefaultView;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cName = txtCommodityName.Text;
            string cWarehouse = txtWarehouses.Text;
            int sNumber = int.Parse(txtStockNumber.Text);
            int aQuantity = int.Parse(txtAlarmQuantity.Text);
            b.Update(cWarehouse, cName,sNumber, aQuantity);
            dgvStock.DataSource = b.QueryAll().DefaultView;
            MessageBox.Show("保存成功！");
            txtCommodityName.Enabled = true;
            txtWarehouses.Enabled = true;
            txtStockNumber.Enabled = true;
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvStock.Columns[e.ColumnIndex].Name;
            if (o == "修改")
            {
                string Warehouses = string.Concat(dgvStock.Rows[e.RowIndex].Cells["仓库名"].Value.ToString());
                string cName = string.Concat(dgvStock.Rows[e.RowIndex].Cells["商品名称"].Value.ToString());
                string sNumber = string.Concat(dgvStock.Rows[e.RowIndex].Cells["库存数量"].Value.ToString());
                string aQuantity = string.Concat(dgvStock.Rows[e.RowIndex].Cells["报警数量"].Value.ToString());
                txtWarehouses.Text = Warehouses;
                txtCommodityName.Text = cName;
                txtStockNumber.Text = sNumber;
                txtAlarmQuantity.Text = aQuantity;
                txtCommodityName.Enabled = false;
                txtWarehouses.Enabled = false;
                txtStockNumber.Enabled = false;
            }
        }

        private void Stock_alarm_Load(object sender, EventArgs e)
        {

            if (b.StockAlarm() == "")
            {

            }
            else {
                if (MessageBox.Show(b.StockAlarm().Trim() + "库存不足！ 请及时补货！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Purchase p = new Purchase();
                    this.Hide();
                    p.Show();
                }
            }
        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }
    }
}
