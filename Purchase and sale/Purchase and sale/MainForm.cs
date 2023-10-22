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

namespace Purchase_and_sale
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
   BMainForm b = new BMainForm();
        static string Operator="";
        public string aNumber;
        public string aPassword;
        public string eNumber;
        public string ePassword;
        public bool employeeCompetence=false;
       public  string Jurisdiction;
        
        private void 员工注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_registration ygzc = new Employee_registration();
            this.Hide();
            ygzc.Show();
        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_information ygxx = new Employee_information();
            this.Hide();
            ygxx.Show();
        }

        private void 员工权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_competence ec = new Employee_competence();
            this.Hide();
            ec.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
         
            //string nowTime = DateTime.Now.ToString();
            //string Expiration = b.Now(nowTime).Trim(); //折扣到期
            //b.UpdateDiscount(Expiration);
            //if (Expiration == "")
            //{

            //}
            //else
            //{
            //    MessageBox.Show(Expiration + "折扣到期！已恢复原价！");
            //}

            timer1.Interval = 1000;
            if (employeeCompetence == false)//管理员登录
            {
                Operator = b.aOperator(aNumber, aPassword);
                lblOperator.Text = Operator;
            }
          
            if (employeeCompetence == true)//员工登录
            {
                //  c2.yqx(qx);
                lblCurrentOperator.Text = "当前员工：";
                Operator = b.eOperator(eNumber, ePassword);
                lblOperator.Text = Operator;
                string y = b.NoEmpowerment(Jurisdiction).Trim();
                string[] d = y.Split(',');
                for (int i = 0; i < d.Length; i++)
                {
                    if (d[i] == "员工管理")
                    {
                        员工管理ToolStripMenuItem.Visible = false;
                    }
                    if (d[i] == "基础信息管理")
                    {
                        基础信息管理ToolStripMenuItem.Visible = false;
                    }
                    if (d[i] == "进货管理")
                    {
                        进货管理ToolStripMenuItem.Visible = false;
                    }
                    if (d[i] == "库存管理")
                    {
                        库存管理ToolStripMenuItem.Visible =false;
                    }
                    if (d[i] == "销售管理")
                    {
                        销售管理ToolStripMenuItem.Visible =false;
                    }

                }
            }
         



        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Purchaser=lblOperator.Text;
            this.Hide();
            p.Show();
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            this.Hide();
            s.Show();
        }

        private void 销售单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales s = new sales();
             s.SalesPeople=lblOperator.Text;
            this.Hide();
            s.Show();
        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Salequery s = new Salequery();
            this.Hide();
            s.Show();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pquery p = new Pquery();
            this.Hide();
            p.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String str; //获取系统时间
               str= Convert.ToString(DateTime.Now);
            label1.Text = str;
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commodity c = new Commodity();
            this.Hide();
            c.Show();
        }

        private void bjkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manufactor m = new Manufactor();
            this.Hide();
            m.Show();
        }

        private void 库存报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_alarm s = new Stock_alarm();
            this.Hide();
            s.Show(); 
        }

        private void 折扣ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Discount d = new Discount();
            this.Hide();
            d.Show();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.Show();
        }
    }
}
