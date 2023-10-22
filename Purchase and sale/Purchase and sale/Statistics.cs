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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        BStatistics b = new BStatistics();
        private void Statistics_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Condition = cbmCondition.Text;
            string InputCondition=txtCondition.Text;
           if (Condition == "显示所有"|| Condition == "")
            {
                dgvStatistics.DataSource = b.ShowAII().DefaultView;
            }
            if (Condition == "仓库名")
            {
                dgvStatistics.DataSource = b.StockName(InputCondition).DefaultView;
            }
            if (Condition == "商品名称")
            {
                dgvStatistics.DataSource = b.CommodityName(InputCondition).DefaultView;
            }

           
        }

        private void dgvStatistics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStatistics_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
