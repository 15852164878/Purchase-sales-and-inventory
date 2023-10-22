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
    public partial class Employee_competence : Form
    {
        public Employee_competence()
        {
          
            InitializeComponent();
          
        }

        BEmployee_competence B = new BEmployee_competence();
        private void Employee_competence_Load(object sender, EventArgs e)
        {
           


        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < ltbOut.Items.Count; i++)
            {
              if(ltbOut.SelectedIndex==i)
                {
                    string a = Convert.ToString((ltbOut.Items[i]));
                    ltbIn.Items.Add(a);
                    ltbOut.Items.RemoveAt(i);

                }
                
            }

        }

        private void btnoutone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbIn.Items.Count; i++)
            {
                if (ltbIn.SelectedIndex == i)
                {
                    string a = Convert.ToString((ltbIn.Items[i]));
                    ltbOut.Items.Add(a);
                    ltbIn.Items.RemoveAt(i);

                }


            }

        }

        private void btninall_Click(object sender, EventArgs e)
        {
            string sId = txtId.Text;
            for (int i = 0; i < ltbOut.Items.Count; i++)
            {
              
                string  a=(ltbOut.Items[i]).ToString();
                    ltbIn.Items.Add(a.Trim());
                
            }
            ltbOut.Items.Clear();
          

        }

        private void btnoutall_Click(object sender, EventArgs e)
        {
            string sId = txtId.Text;
            for (int i = 0; i < ltbIn.Items.Count; i++)
            {
                string a = (ltbIn.Items[i]).ToString();
                ltbOut.Items.Add(a.Trim());

            }
            ltbIn.Items.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sId = txtId.Text.Trim();
           string sName=txtName.Text.Trim();
            string a = "";
            string b = "";
            for (int i = 0; i < ltbOut.Items.Count; i++)
            {
                a =a+(ltbOut.Items[i]).ToString()+"," ;
            }
      
            for (int i = 0; i < ltbIn.Items.Count; i++)
            {
                b =b+ (ltbIn.Items[i]).ToString()+"," ;
            }
            B.ModifyUnassigned(a.Trim(), sId, sName);
            B.ModifyAssigned(b.Trim(), sId, sName);
          
            MessageBox.Show("保存成功");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ltbIn.Items.Clear();
            ltbOut.Items.Clear();
            //未分配
            string sId = txtId.Text;
            string y = B.QueryUnassigned(sId).Trim();
            string[] d = y.Split(',');
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] != "")
                {

                    for (int j = 0; j < ltbOut.Items.Count; j++)
                    {

                        if (ltbOut.Items[j].ToString() == d[i])
                        {
                            return;
                        }


                    }
                    ltbOut.Items.Add(d[i]);
                }
            }

            //已分配
            string g = B.QueryAssigned(sId).Trim();
            string[] f = g.Split(',');
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i] != "")
                {
                    for (int j = 0; j < ltbIn.Items.Count; j++)
                    {
                        if (ltbIn.Items[j].ToString() == f[i])
                        {
                            return;
                        }
                    }
                    ltbIn.Items.Add(f[i]);
                }
            }
        }

        private void 返回主菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }
    }
}
