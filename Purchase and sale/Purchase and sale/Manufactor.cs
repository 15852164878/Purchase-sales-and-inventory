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
    public partial class Manufactor : Form
    {
        public Manufactor()
        {
            InitializeComponent();
        }
        BManufactor b = new BManufactor();
        int mid;
        string mName;
        string mPeople;
        long mTelephone;
        string mAddress;
        private void btntj_Click(object sender, EventArgs e)
        {
            string manufacturerName = txtManufacturerName.Text;
            string manufacturerPeople = txtPersonInChargeOfTheManufacturer.Text;
            long manufacturerTelephone = Convert.ToInt64(txtManufacturerTelephoneNumber.Text);
            string manufacturerAddress = txtManufacturerAddress.Text;
            b.AddTo(manufacturerName, manufacturerPeople, manufacturerTelephone, manufacturerAddress);
            dgvManufactor.DataSource = b.ShowAll().DefaultView;
            MessageBox.Show("添加成功！");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvManufactor.Columns[e.ColumnIndex].Name;
            if (o == "修改")
            {
                mid = int.Parse(dgvManufactor.Rows[e.RowIndex].Cells["厂家编号"].Value.ToString());
                mName = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家名称"].Value.ToString());
                mPeople = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家负责人"].Value.ToString());
                mTelephone = Convert.ToInt64(dgvManufactor.Rows[e.RowIndex].Cells["厂家电话"].Value.ToString());
                mAddress = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家地址"].Value.ToString());
                b.Update(mid, mName, mPeople, mTelephone, mAddress);
                MessageBox.Show("修改成功！");
                dgvManufactor.DataSource = b.ShowAll().DefaultView;

            }
            if (o == "删除")
            {
                mid = int.Parse(dgvManufactor.Rows[e.RowIndex].Cells["厂家编号"].Value.ToString());
                mName = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家名称"].Value.ToString());
                mPeople = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家负责人"].Value.ToString());
                mTelephone = Convert.ToInt64(dgvManufactor.Rows[e.RowIndex].Cells["厂家电话"].Value.ToString());
                mAddress = string.Concat(dgvManufactor.Rows[e.RowIndex].Cells["厂家地址"].Value.ToString());
                if (MessageBox.Show("确定删除此条记录吗", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    b.Delete(mid);
                    dgvManufactor.DataSource = b.ShowAll().DefaultView;
                    MessageBox.Show("删除成功");
                }
                else
                {
                    return;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcjmc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncj_Click(object sender, EventArgs e)
        {
            string mName = txtManufacturerName.Text;
            string mPeople = txtPersonInChargeOfTheManufacturer.Text;
            string mmTelephone = txtManufacturerTelephoneNumber.Text;
            string mmAddress = txtManufacturerAddress.Text;
            dgvManufactor.DataSource = b.Query(mName, mPeople, mmTelephone, mmAddress).DefaultView;
        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }
    }
}
