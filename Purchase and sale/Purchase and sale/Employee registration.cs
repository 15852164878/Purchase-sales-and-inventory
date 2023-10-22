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
    public partial class Employee_registration : Form
    {
        public Employee_registration()
        {
            InitializeComponent();
        }
        BEmployee_registration b = new BEmployee_registration();
        private void btnzc_Click(object sender, EventArgs e)
        {
            string sName=txtName.Text;
            string sSex = b.sex(rdoMan.Checked, rdowoMan.Checked);
             string  sAge = txtAge.Text;

            Random random = new Random();
            int sAccount = random.Next();//产生一个随机数

            string sPass = txtPassWord.Text;
            if (txtPassWord.Text == txtConfirmPassWord.Text)
            {
                sPass = txtPassWord.Text;
            }
            else
            {
                MessageBox.Show("你两次输入的密码不一致");
                return;
            }
            MessageBox.Show(" 你的账号：" + sAccount + "\n 你的密码:"+"   " + sPass);
            b.EmployeeAddition(sName, sSex, sAge, sAccount, sPass);
         
        }

        private void Employee_registration_Load(object sender, EventArgs e)
        {

        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }
    }
}
