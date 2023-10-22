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
    public partial class Commodity : Form
    {
        public Commodity()
        {
            InitializeComponent();
        }
        BCommodity b = new BCommodity();

        int cId;
        string cName;
        string cType;
        string cPrice;
        int cmId;
        private void btntj_Click(object sender, EventArgs e)
        {
            string commodityName = txtName.Text;
            string commodityType = txtCommodityType.Text;
            string commodityPrice = txtCommodityPrice.Text;
            int manufactorId=int.Parse(txtManufactorId.Text);
            b.AddTo(commodityName, commodityType, commodityPrice, manufactorId);
            dgvCommodity.DataSource = b.ShowAll().DefaultView;
            MessageBox.Show("添加成功");
            
        }

        private void Commodity_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvCommodity.Columns[e.ColumnIndex].Name;
            if (o == "修改")
            {
                cId = int.Parse(dgvCommodity.Rows[e.RowIndex].Cells["商品编号"].Value.ToString());
                cName = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品名称"].Value.ToString());
                cType = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品类型"].Value.ToString());
                cPrice = string.Concat(dgvCommodity.Rows[e.RowIndex].Cells["商品价格"].Value.ToString());
                cmId= int.Parse(dgvCommodity.Rows[e.RowIndex].Cells["厂家编号"].Value.ToString());
                b.ToUpdate(cId, cName, cType, cPrice, cmId);
                MessageBox.Show("修改成功！");
                dgvCommodity.DataSource = b.ShowAll().DefaultView;
            }
            if(o=="删除")
            {
                cId = int.Parse(dgvCommodity.Rows[e.RowIndex].Cells["商品编号"].Value.ToString());
                if (MessageBox.Show("确定删除此条记录吗", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    b.Delete(cId);
                    dgvCommodity.DataSource = b.ShowAll().DefaultView;
                    MessageBox.Show("删除成功");
                }
                else
                {
                    return;
                }
            }
        }

        private void btncx_Click(object sender, EventArgs e)
        {
            string commodityName = txtName.Text;
            string commodityType = txtCommodityType.Text;
            string commodityPrice = txtCommodityPrice.Text;
           string manufactorId = txtManufactorId.Text;
            dgvCommodity.DataSource = b.Query(commodityName, commodityType, commodityPrice, manufactorId).DefaultView;

        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }
    }
}
