using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
/**********************
*                     *
*   作者：张赛        *
*   日期：2019/12/4   *
*                     *
**********************/


//=================================================================================================================
//
//  版本V1.00   修改时间 2019/12/3     修改内容  界面优化 代码优化
//  版本V1.01   修改时间 2019/12/4     修改内容  改写三次架构 界面优化 代码优化
//
//=================================================================================================================
//


namespace Purchase_and_sale
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        BLogin b = new BLogin();
        private void btndl_Click(object sender, EventArgs e) 
        {

                string accountNumber = txtAccountNumber.Text.Trim();
                string passWord = txtPassWord.Text.Trim();
                if (accountNumber == "")
                {
                    MessageBox.Show("请输入账号");
                    return;
                }

                if (passWord == "")
                {
                    MessageBox.Show("请输入密码");
                    return;
                }
                
                if (cmbIdentity.Text == "")
                {
                    MessageBox.Show("请选择你的身份");
                    return;
                }
                
                if (cmbIdentity.Text == "管理员")
                {
                    if (b.UserAdministrator(accountNumber, passWord))
                    {
                        MessageBox.Show("管理员登录成功");
                        MainForm m = new MainForm();
                        m.aNumber = accountNumber;
                        m.aPassword = passWord;
                        this.Hide();
                       m.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误！");
                    }
                  
                }

                if (cmbIdentity.Text == "员工")
                {
                    if (b.UserStaff(accountNumber, passWord))
                    {
                        MessageBox.Show("员工登录成功");
                        MainForm m = new MainForm();
                        m.employeeCompetence = true;
                        m.Jurisdiction = accountNumber;
                        m.eNumber= accountNumber;
                        m.ePassword= passWord;
                        this.Hide();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误！");
                    }
                
                }
        }


     
        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
