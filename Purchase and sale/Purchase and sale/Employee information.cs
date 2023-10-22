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
    public partial class Employee_information : Form
    {
        public Employee_information()
        {
            InitializeComponent();
        }
        BEmployee_inforrmation b = new BEmployee_inforrmation();
        int sId;
        string sName;
        string sSex;
        string sAge;
        string sCount;
        string sPass;
        private void btn_Click_1(object sender, EventArgs e)
        {
         
           string eName= txtName.Text;
          string eSex= txtSex.Text;
          string eAge=txtAge.Text;
           int aNumber=int.Parse(txtAccountNumber.Text);
           string Pass= txtPass.Text;
            dgvStaff.DataSource = b.Query( eName, eSex, eAge, aNumber, Pass).DefaultView;
            
        }

        private void dgvygxx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvStaff.Columns[e.ColumnIndex].Name;
            if (o == "删除")
            {
                sId = int.Parse(dgvStaff.Rows[e.RowIndex].Cells["colID"].Value.ToString());
                sName = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col员工姓名"].Value.ToString());
                sSex = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col员工性别"].Value.ToString());
                sAge = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col员工年龄"].Value.ToString());
                sCount = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col账号"].Value.ToString());
                sPass = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col密码"].Value.ToString());
                if (MessageBox.Show("确定删除此条记录吗", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    b.Delete(sId);
                    MessageBox.Show("删除成功");
                    dgvStaff.DataSource = b.ShowAll().DefaultView;
                }
                else
                {
                    return;
                }
               
            }
            if(o=="查看")
            {
                sId = int.Parse(dgvStaff.Rows[e.RowIndex].Cells["colID"].Value.ToString());
                sName = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col员工姓名"].Value.ToString());
                sSex = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col员工性别"].Value.ToString());
                sAge = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col员工年龄"].Value.ToString());
                sCount = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col账号"].Value.ToString());
                sPass = string.Concat(dgvStaff.Rows[e.RowIndex].Cells["col密码"].Value.ToString());
                txtId.Text = sId.ToString().Trim();
                txtName.Text = sName.Trim();
                txtSex.Text = sSex.Trim();
                txtAge.Text = sAge.Trim();
                txtAccountNumber.Text = sCount.Trim();
                txtPass.Text = sPass.Trim();
            }
        }

        private void btnbc_Click(object sender, EventArgs e)
        {
            string sName = txtName.Text;
            string sSex = txtSex.Text;
            string sAge = txtAge.Text;
            int sCount = int.Parse(txtAccountNumber.Text);
            string sPass = txtPass.Text;
            if (txtId.Text=="")
            {
                MessageBox.Show("未读取到信息！");
            }
            else
            {
                b.Modify(sId, sName, sSex, sAge, sCount, sPass);
                MessageBox.Show("保存成功");
                dgvStaff.DataSource = b.Query(sName, sSex, sAge, sCount, sPass).DefaultView;
            }
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_information_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }
    }
}
