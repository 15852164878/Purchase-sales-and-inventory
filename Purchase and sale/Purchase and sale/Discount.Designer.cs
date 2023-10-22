namespace Purchase_and_sale
{
    partial class Discount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.折扣率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.折扣截止时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.打折 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPreservation = new System.Windows.Forms.Button();
            this.txtDiscountTime = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtCommodityName = new System.Windows.Forms.TextBox();
            this.txtCommodityType = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "折扣率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "折扣截止时间";
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品名称,
            this.商品类型,
            this.折扣率,
            this.折扣截止时间,
            this.打折});
            this.dgvDiscount.Location = new System.Drawing.Point(21, 250);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.RowTemplate.Height = 27;
            this.dgvDiscount.Size = new System.Drawing.Size(786, 272);
            this.dgvDiscount.TabIndex = 4;
            this.dgvDiscount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscount_CellContentClick);
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
            // 折扣率
            // 
            this.折扣率.DataPropertyName = "zkl";
            this.折扣率.HeaderText = "折扣率";
            this.折扣率.Name = "折扣率";
            // 
            // 折扣截止时间
            // 
            this.折扣截止时间.DataPropertyName = "zksj";
            this.折扣截止时间.HeaderText = "折扣截止时间";
            this.折扣截止时间.Name = "折扣截止时间";
            // 
            // 打折
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "打折";
            this.打折.DefaultCellStyle = dataGridViewCellStyle1;
            this.打折.HeaderText = "打折";
            this.打折.Name = "打折";
            // 
            // btnPreservation
            // 
            this.btnPreservation.Location = new System.Drawing.Point(537, 171);
            this.btnPreservation.Name = "btnPreservation";
            this.btnPreservation.Size = new System.Drawing.Size(79, 50);
            this.btnPreservation.TabIndex = 5;
            this.btnPreservation.Text = "保存";
            this.btnPreservation.UseVisualStyleBackColor = true;
            this.btnPreservation.Click += new System.EventHandler(this.btnPreservation_Click);
            // 
            // txtDiscountTime
            // 
            this.txtDiscountTime.Location = new System.Drawing.Point(525, 105);
            this.txtDiscountTime.Name = "txtDiscountTime";
            this.txtDiscountTime.Size = new System.Drawing.Size(136, 25);
            this.txtDiscountTime.TabIndex = 6;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(525, 53);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(136, 25);
            this.txtDiscount.TabIndex = 6;
            // 
            // txtCommodityName
            // 
            this.txtCommodityName.Location = new System.Drawing.Point(174, 50);
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.Size = new System.Drawing.Size(136, 25);
            this.txtCommodityName.TabIndex = 6;
            // 
            // txtCommodityType
            // 
            this.txtCommodityType.Location = new System.Drawing.Point(174, 105);
            this.txtCommodityType.Name = "txtCommodityType";
            this.txtCommodityType.Size = new System.Drawing.Size(136, 25);
            this.txtCommodityType.TabIndex = 6;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(183, 171);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(82, 47);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 532);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtCommodityType);
            this.Controls.Add(this.txtCommodityName);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtDiscountTime);
            this.Controls.Add(this.btnPreservation);
            this.Controls.Add(this.dgvDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Discount";
            this.Text = "折扣";
            this.Load += new System.EventHandler(this.Discount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.Button btnPreservation;
        private System.Windows.Forms.TextBox txtDiscountTime;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtCommodityName;
        private System.Windows.Forms.TextBox txtCommodityType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn 打折;
        private System.Windows.Forms.DataGridViewTextBoxColumn 折扣截止时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 折扣率;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
    }
}