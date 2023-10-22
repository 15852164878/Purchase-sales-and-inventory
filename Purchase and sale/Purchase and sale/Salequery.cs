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
    public partial class Salequery : Form
    {
        public Salequery()
        {
            InitializeComponent();
        }
        BSalequery b = new BSalequery();
       
             int sId;
            string sPeople;
            string sPrice;
            string sNumber ;
            string sTime;
           double Profit;
            int cId;


        private void btncx_Click(object sender, EventArgs e)
        {

            string saleId =txtsId.Text;
            string salePeople = txtsPeople.Text;
            string salePrice = txtsPrice.Text;
            string saleNumber = txtsNumber.Text;
            string saleTime = txtsTime.Text;
            string saleProfit = txtsProfit.Text;
            string commodityId = txtcId.Text;
            //MessageBox.Show("2");
            //   MessageBox.Show(sPeople);
            //MessageBox.Show(sPrice);
            //MessageBox.Show(sNumber);
            //MessageBox.Show(sTime);
            //MessageBox.Show(sProfit);
            //MessageBox.Show(cId.ToString());
            /// sPeople sPrice sNumber sTime sProfit cId);
            dgvSale.DataSource = b.Query(saleId, salePeople, salePrice, saleNumber, saleTime, saleProfit, commodityId).DefaultView;




            //string Condition = cmbCondition.Text;
            //string InputCondition = txtCondition.Text;
            //if (Condition == "")
            //{
            //    MessageBox.Show("请选择查询条件");
            //}
            //if (Condition == "销售编号")
            //{
            //    dgvSale.DataSource = b.SaleId(int.Parse(InputCondition)).DefaultView;

            //}
            //if (Condition == "销售人")
            //{
            //    dgvSale.DataSource = b.SalePepole(InputCondition).DefaultView;

            //}
            //if (Condition == "销售单价")
            //{
            //    dgvSale.DataSource = b.SalePrice(InputCondition).DefaultView;

            //}
            //if (Condition == "销售数量")
            //{
            //    dgvSale.DataSource = b.SaleNumber(InputCondition).DefaultView;

            //}
            //if (Condition == "销售日期")
            //{
            //    dgvSale.DataSource = b.SaleTime(InputCondition).DefaultView;

            //}
            //if (Condition == "商品编号")
            //{
            //    dgvSale.DataSource = b.CommodityId(int.Parse(InputCondition)).DefaultView;

            //}

            //if (Condition == "查询所有")
            //{
            //    dgvSale.DataSource = b.ShowAll().DefaultView;

            //}
        }

        private void dgvxs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string o = dgvSale.Columns[e.ColumnIndex].Name;
            if (o == "修改")
            {
                sId = int.Parse(dgvSale.Rows[e.RowIndex].Cells["销售编号"].Value.ToString());
                sPeople = string.Concat(dgvSale.Rows[e.RowIndex].Cells["销售人"].Value.ToString());
                sPrice = string.Concat(dgvSale.Rows[e.RowIndex].Cells["销售单价"].Value.ToString());
                sNumber = string.Concat(dgvSale.Rows[e.RowIndex].Cells["销售数量"].Value.ToString());
                sTime = string.Concat(dgvSale.Rows[e.RowIndex].Cells["销售日期"].Value.ToString());
                Profit = double.Parse(dgvSale.Rows[e.RowIndex].Cells["盈利"].Value.ToString());
                cId = int.Parse(dgvSale.Rows[e.RowIndex].Cells["商品编号"].Value.ToString());
                b.Update(sId, sPeople, sPrice, sNumber, sTime, Profit, cId);
                dgvSale.DataSource = b.ShowAll().DefaultView;
                MessageBox.Show("修改成功");


            }
            if (o == "删除")
            {
                sId = int.Parse(dgvSale.Rows[e.RowIndex].Cells["销售编号"].Value.ToString());
                if (MessageBox.Show("确定删除此条记录吗", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    b.sc(sId);
                    MessageBox.Show("删除成功");
                    dgvSale.DataSource = b.ShowAll().DefaultView;
                }
                else
                {
                    return;
                }

            }
        }

        private void Squery_Load(object sender, EventArgs e)
        {

        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
