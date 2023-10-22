namespace Purchase_and_sale
{
    partial class Pquery
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
            this.dgvStockPurchase = new System.Windows.Forms.DataGridView();
            this.进货编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进货人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进货数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进货价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进货时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.txtPurchasePeople = new System.Windows.Forms.TextBox();
            this.txtPurchaseNumber = new System.Windows.Forms.TextBox();
            this.txtManufactorId = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtPurchaseTime = new System.Windows.Forms.TextBox();
            this.txtCommodityId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockPurchase)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockPurchase
            // 
            this.dgvStockPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.进货编号,
            this.进货人,
            this.进货数量,
            this.进货价格,
            this.进货时间,
            this.商品编号,
            this.厂家编号,
            this.修改,
            this.删除});
            this.dgvStockPurchase.Location = new System.Drawing.Point(16, 177);
            this.dgvStockPurchase.Name = "dgvStockPurchase";
            this.dgvStockPurchase.RowTemplate.Height = 27;
            this.dgvStockPurchase.Size = new System.Drawing.Size(1149, 368);
            this.dgvStockPurchase.TabIndex = 0;
            this.dgvStockPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // 进货编号
            // 
            this.进货编号.DataPropertyName = "jhid";
            this.进货编号.HeaderText = "进货编号";
            this.进货编号.Name = "进货编号";
            // 
            // 进货人
            // 
            this.进货人.DataPropertyName = "jhr";
            this.进货人.HeaderText = "进货人";
            this.进货人.Name = "进货人";
            // 
            // 进货数量
            // 
            this.进货数量.DataPropertyName = "jhsl";
            this.进货数量.HeaderText = "进货数量";
            this.进货数量.Name = "进货数量";
            // 
            // 进货价格
            // 
            this.进货价格.DataPropertyName = "jhjg";
            this.进货价格.HeaderText = "进货价格";
            this.进货价格.Name = "进货价格";
            // 
            // 进货时间
            // 
            this.进货时间.DataPropertyName = "jhsj";
            this.进货时间.HeaderText = "进货时间";
            this.进货时间.Name = "进货时间";
            // 
            // 商品编号
            // 
            this.商品编号.DataPropertyName = "spid";
            this.商品编号.HeaderText = "商品编号";
            this.商品编号.Name = "商品编号";
            // 
            // 厂家编号
            // 
            this.厂家编号.DataPropertyName = "cjid";
            this.厂家编号.HeaderText = "厂家编号";
            this.厂家编号.Name = "厂家编号";
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
            this.btnQuery.Location = new System.Drawing.Point(836, 104);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(74, 35);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Location = new System.Drawing.Point(113, 51);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Size = new System.Drawing.Size(98, 25);
            this.txtPurchaseId.TabIndex = 2;
            // 
            // txtPurchasePeople
            // 
            this.txtPurchasePeople.Location = new System.Drawing.Point(113, 101);
            this.txtPurchasePeople.Name = "txtPurchasePeople";
            this.txtPurchasePeople.Size = new System.Drawing.Size(98, 25);
            this.txtPurchasePeople.TabIndex = 2;
            // 
            // txtPurchaseNumber
            // 
            this.txtPurchaseNumber.Location = new System.Drawing.Point(359, 51);
            this.txtPurchaseNumber.Name = "txtPurchaseNumber";
            this.txtPurchaseNumber.Size = new System.Drawing.Size(98, 25);
            this.txtPurchaseNumber.TabIndex = 2;
            // 
            // txtManufactorId
            // 
            this.txtManufactorId.Location = new System.Drawing.Point(836, 51);
            this.txtManufactorId.Name = "txtManufactorId";
            this.txtManufactorId.Size = new System.Drawing.Size(98, 25);
            this.txtManufactorId.TabIndex = 2;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(359, 104);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(98, 25);
            this.txtPurchasePrice.TabIndex = 2;
            // 
            // txtPurchaseTime
            // 
            this.txtPurchaseTime.Location = new System.Drawing.Point(598, 54);
            this.txtPurchaseTime.Name = "txtPurchaseTime";
            this.txtPurchaseTime.Size = new System.Drawing.Size(98, 25);
            this.txtPurchaseTime.TabIndex = 2;
            // 
            // txtCommodityId
            // 
            this.txtCommodityId.Location = new System.Drawing.Point(598, 104);
            this.txtCommodityId.Name = "txtCommodityId";
            this.txtCommodityId.Size = new System.Drawing.Size(98, 25);
            this.txtCommodityId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "进货编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "进货人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "进货数量";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "厂家编号";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "进货价格";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "进货时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "商品编号";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // Pquery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCommodityId);
            this.Controls.Add(this.txtPurchaseTime);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtManufactorId);
            this.Controls.Add(this.txtPurchaseNumber);
            this.Controls.Add(this.txtPurchasePeople);
            this.Controls.Add(this.txtPurchaseId);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dgvStockPurchase);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pquery";
            this.Text = "进货单查询";
            this.Load += new System.EventHandler(this.Pquery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockPurchase)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockPurchase;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进货时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进货价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进货数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进货人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进货编号;
        private System.Windows.Forms.TextBox txtPurchaseId;
        private System.Windows.Forms.TextBox txtPurchasePeople;
        private System.Windows.Forms.TextBox txtPurchaseNumber;
        private System.Windows.Forms.TextBox txtManufactorId;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtPurchaseTime;
        private System.Windows.Forms.TextBox txtCommodityId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
    }
}