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
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
        }
        BDiscount b = new BDiscount();
        private void button2_Click(object sender, EventArgs e)
        {
            string cName = txtCommodityName.Text;
            string cType = txtCommodityType.Text;
             dgvDiscount.DataSource = b.Query(cName, cType).DefaultView;
        }

        private void btnPreservation_Click(object sender, EventArgs e)
        {
            string cName = txtCommodityName.Text;
            string cType = txtCommodityType.Text;
            double Discount=double.Parse(txtDiscount.Text);
            string DiscountTime= txtDiscountTime.Text;
            b.Update(cName,Discount, DiscountTime);
            MessageBox.Show("保存成功！");
            txtCommodityName.Enabled = true;
            txtCommodityType.Enabled = true;

        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }

        private void dgvDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvDiscount.Columns[e.ColumnIndex].Name;
            if (o == "打折")
            {
                string cName = string.Concat(dgvDiscount.Rows[e.RowIndex].Cells["商品名称"].Value.ToString());
                string cType = string.Concat(dgvDiscount.Rows[e.RowIndex].Cells["商品类型"].Value.ToString());
                string dDiscount = string.Concat(dgvDiscount.Rows[e.RowIndex].Cells["折扣率"].Value.ToString());
                string discountTime = string.Concat(dgvDiscount.Rows[e.RowIndex].Cells["折扣截止时间"].Value.ToString());
                txtCommodityName.Text = cName;
                txtCommodityType.Text = cType;
                txtDiscount.Text = dDiscount;
                txtDiscountTime.Text = discountTime;
                txtCommodityName.Enabled = false;
                txtCommodityType.Enabled = false;

            }
            }

        private void Discount_Load(object sender, EventArgs e)
        {
            string nowTime = DateTime.Now.ToString();
            string Expiration = b.Now(nowTime); //折扣到期
            b.UpdateDiscount(Expiration);
            if (Expiration == "")
            {

            }
            else
            {
                MessageBox.Show(Expiration + "折扣到期！已恢复原价！");
            }
        }
    }
}
