namespace Purchase_and_sale
{
    partial class Salequery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.销售编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.盈利 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsId = new System.Windows.Forms.TextBox();
            this.txtsPeople = new System.Windows.Forms.TextBox();
            this.txtcId = new System.Windows.Forms.TextBox();
            this.txtsPrice = new System.Windows.Forms.TextBox();
            this.txtsNumber = new System.Windows.Forms.TextBox();
            this.txtsTime = new System.Windows.Forms.TextBox();
            this.txtsProfit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.销售编号,
            this.销售人,
            this.销售单价,
            this.销售数量,
            this.销售日期,
            this.盈利,
            this.商品编号,
            this.修改,
            this.删除});
            this.dgvSale.Location = new System.Drawing.Point(12, 162);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowTemplate.Height = 27;
            this.dgvSale.Size = new System.Drawing.Size(1124, 453);
            this.dgvSale.TabIndex = 0;
            this.dgvSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvxs_CellContentClick);
            // 
            // 销售编号
            // 
            this.销售编号.DataPropertyName = "xsid";
            this.销售编号.HeaderText = "销售编号";
            this.销售编号.Name = "销售编号";
            // 
            // 销售人
            // 
            this.销售人.DataPropertyName = "xsr";
            this.销售人.HeaderText = "销售人";
            this.销售人.Name = "销售人";
            // 
            // 销售单价
            // 
            this.销售单价.DataPropertyName = "xsdj";
            this.销售单价.HeaderText = "销售单价";
            this.销售单价.Name = "销售单价";
            // 
            // 销售数量
            // 
            this.销售数量.DataPropertyName = "xssl";
            this.销售数量.HeaderText = "销售数量";
            this.销售数量.Name = "销售数量";
            // 
            // 销售日期
            // 
            this.销售日期.DataPropertyName = "xsrq";
            this.销售日期.HeaderText = "销售日期";
            this.销售日期.Name = "销售日期";
            // 
            // 盈利
            // 
            this.盈利.DataPropertyName = "xsyl";
            this.盈利.HeaderText = "盈利";
            this.盈利.Name = "盈利";
            // 
            // 商品编号
            // 
            this.商品编号.DataPropertyName = "spid";
            this.商品编号.HeaderText = "商品编号";
            this.商品编号.Name = "商品编号";
            // 
            // 修改
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "修改";
            this.修改.DefaultCellStyle = dataGridViewCellStyle1;
            this.修改.HeaderText = "修改";
            this.修改.Name = "修改";
            this.修改.Width = 50;
            // 
            // 删除
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "删除";
            this.删除.DefaultCellStyle = dataGridViewCellStyle2;
            this.删除.HeaderText = "删除";
            this.删除.Name = "删除";
            this.删除.Width = 50;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(782, 100);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(72, 42);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btncx_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "销售人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "销售单价";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "销售数量";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "销售日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "销售编号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "盈利";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(734, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "商品编号";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtsId
            // 
            this.txtsId.Location = new System.Drawing.Point(145, 49);
            this.txtsId.Name = "txtsId";
            this.txtsId.Size = new System.Drawing.Size(84, 25);
            this.txtsId.TabIndex = 10;
            // 
            // txtsPeople
            // 
            this.txtsPeople.Location = new System.Drawing.Point(145, 100);
            this.txtsPeople.Name = "txtsPeople";
            this.txtsPeople.Size = new System.Drawing.Size(84, 25);
            this.txtsPeople.TabIndex = 10;
            // 
            // txtcId
            // 
            this.txtcId.Location = new System.Drawing.Point(819, 51);
            this.txtcId.Name = "txtcId";
            this.txtcId.Size = new System.Drawing.Size(84, 25);
            this.txtcId.TabIndex = 10;
            // 
            // txtsPrice
            // 
            this.txtsPrice.Location = new System.Drawing.Point(379, 51);
            this.txtsPrice.Name = "txtsPrice";
            this.txtsPrice.Size = new System.Drawing.Size(84, 25);
            this.txtsPrice.TabIndex = 10;
            // 
            // txtsNumber
            // 
            this.txtsNumber.Location = new System.Drawing.Point(379, 100);
            this.txtsNumber.Name = "txtsNumber";
            this.txtsNumber.Size = new System.Drawing.Size(84, 25);
            this.txtsNumber.TabIndex = 10;
            // 
            // txtsTime
            // 
            this.txtsTime.Location = new System.Drawing.Point(589, 51);
            this.txtsTime.Name = "txtsTime";
            this.txtsTime.Size = new System.Drawing.Size(84, 25);
            this.txtsTime.TabIndex = 10;
            this.txtsTime.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtsProfit
            // 
            this.txtsProfit.Location = new System.Drawing.Point(589, 100);
            this.txtsProfit.Name = "txtsProfit";
            this.txtsProfit.Size = new System.Drawing.Size(84, 25);
            this.txtsProfit.TabIndex = 10;
            this.txtsProfit.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // Salequery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 627);
            this.Controls.Add(this.txtcId);
            this.Controls.Add(this.txtsProfit);
            this.Controls.Add(this.txtsNumber);
            this.Controls.Add(this.txtsPeople);
            this.Controls.Add(this.txtsTime);
            this.Controls.Add(this.txtsPrice);
            this.Controls.Add(this.txtsId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Salequery";
            this.Text = "销售查询";
            this.Load += new System.EventHandler(this.Squery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 盈利;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售编号;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsId;
        private System.Windows.Forms.TextBox txtsPeople;
        private System.Windows.Forms.TextBox txtcId;
        private System.Windows.Forms.TextBox txtsPrice;
        private System.Windows.Forms.TextBox txtsNumber;
        private System.Windows.Forms.TextBox txtsTime;
        private System.Windows.Forms.TextBox txtsProfit;
    }
}