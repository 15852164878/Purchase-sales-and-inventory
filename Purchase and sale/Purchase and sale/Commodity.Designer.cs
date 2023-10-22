namespace Purchase_and_sale
{
    partial class Commodity
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
            this.dgvCommodity = new System.Windows.Forms.DataGridView();
            this.商品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCommodityType = new System.Windows.Forms.TextBox();
            this.txtCommodityPrice = new System.Windows.Forms.TextBox();
            this.btnAddTo = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtManufactorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCommodity
            // 
            this.dgvCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品编号,
            this.商品名称,
            this.商品类型,
            this.商品价格,
            this.厂家编号,
            this.修改,
            this.删除});
            this.dgvCommodity.Location = new System.Drawing.Point(15, 214);
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.RowTemplate.Height = 27;
            this.dgvCommodity.Size = new System.Drawing.Size(899, 394);
            this.dgvCommodity.TabIndex = 0;
            this.dgvCommodity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // 商品编号
            // 
            this.商品编号.DataPropertyName = "spid";
            this.商品编号.HeaderText = "商品编号";
            this.商品编号.Name = "商品编号";
            // 
            // 商品名称
            // 
            this.商品名称.DataPropertyName = "spmc";
            this.商品名称.HeaderText = "商品名称";
            this.商品名称.Name = "商品名称";
            // 
            // 商品类型
            // 
            this.商品类型.DataPropertyName = "splx";
            this.商品类型.HeaderText = "商品类型";
            this.商品类型.Name = "商品类型";
            // 
            // 商品价格
            // 
            this.商品价格.DataPropertyName = "spjg";
            this.商品价格.HeaderText = "商品价格";
            this.商品价格.Name = "商品价格";
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
            this.修改.Width = 70;
            // 
            // 删除
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "删除";
            this.删除.DefaultCellStyle = dataGridViewCellStyle2;
            this.删除.HeaderText = "删除";
            this.删除.Name = "删除";
            this.删除.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "商品类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "商品价格";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtCommodityType
            // 
            this.txtCommodityType.Location = new System.Drawing.Point(136, 114);
            this.txtCommodityType.Name = "txtCommodityType";
            this.txtCommodityType.Size = new System.Drawing.Size(116, 25);
            this.txtCommodityType.TabIndex = 2;
            // 
            // txtCommodityPrice
            // 
            this.txtCommodityPrice.Location = new System.Drawing.Point(493, 57);
            this.txtCommodityPrice.Name = "txtCommodityPrice";
            this.txtCommodityPrice.Size = new System.Drawing.Size(116, 25);
            this.txtCommodityPrice.TabIndex = 2;
            // 
            // btnAddTo
            // 
            this.btnAddTo.Location = new System.Drawing.Point(711, 55);
            this.btnAddTo.Name = "btnAddTo";
            this.btnAddTo.Size = new System.Drawing.Size(70, 35);
            this.btnAddTo.TabIndex = 3;
            this.btnAddTo.Text = "添加";
            this.btnAddTo.UseVisualStyleBackColor = true;
            this.btnAddTo.Click += new System.EventHandler(this.btntj_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(711, 104);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(70, 35);
            this.btnQuery.TabIndex = 4;
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
            this.menuStrip1.Size = new System.Drawing.Size(963, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // txtManufactorId
            // 
            this.txtManufactorId.Location = new System.Drawing.Point(494, 111);
            this.txtManufactorId.Name = "txtManufactorId";
            this.txtManufactorId.Size = new System.Drawing.Size(115, 25);
            this.txtManufactorId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "厂家编号";
            // 
            // Commodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtManufactorId);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnAddTo);
            this.Controls.Add(this.txtCommodityPrice);
            this.Controls.Add(this.txtCommodityType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCommodity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Commodity";
            this.Text = "商品";
            this.Load += new System.EventHandler(this.Commodity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommodity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCommodityType;
        private System.Windows.Forms.TextBox txtCommodityPrice;
        private System.Windows.Forms.Button btnAddTo;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家编号;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品编号;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtManufactorId;
        private System.Windows.Forms.Label label1;
    }
}