namespace Purchase_and_sale
{
    partial class Stock_alarm
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.txtAlarmQuantity = new System.Windows.Forms.TextBox();
            this.txtCommodityName = new System.Windows.Forms.TextBox();
            this.txtWarehouses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockNumber = new System.Windows.Forms.TextBox();
            this.btnPreservation = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报警数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "仓库名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "报警数量";
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仓库名,
            this.商品名称,
            this.库存数量,
            this.报警数量,
            this.修改});
            this.dgvStock.Location = new System.Drawing.Point(13, 250);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowTemplate.Height = 27;
            this.dgvStock.Size = new System.Drawing.Size(734, 238);
            this.dgvStock.TabIndex = 1;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // txtAlarmQuantity
            // 
            this.txtAlarmQuantity.Location = new System.Drawing.Point(500, 116);
            this.txtAlarmQuantity.Name = "txtAlarmQuantity";
            this.txtAlarmQuantity.Size = new System.Drawing.Size(104, 25);
            this.txtAlarmQuantity.TabIndex = 2;
            // 
            // txtCommodityName
            // 
            this.txtCommodityName.Location = new System.Drawing.Point(194, 48);
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.Size = new System.Drawing.Size(104, 25);
            this.txtCommodityName.TabIndex = 2;
            // 
            // txtWarehouses
            // 
            this.txtWarehouses.Location = new System.Drawing.Point(194, 116);
            this.txtWarehouses.Name = "txtWarehouses";
            this.txtWarehouses.Size = new System.Drawing.Size(104, 25);
            this.txtWarehouses.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "库存数量";
            // 
            // txtStockNumber
            // 
            this.txtStockNumber.Location = new System.Drawing.Point(500, 51);
            this.txtStockNumber.Name = "txtStockNumber";
            this.txtStockNumber.Size = new System.Drawing.Size(106, 25);
            this.txtStockNumber.TabIndex = 4;
            // 
            // btnPreservation
            // 
            this.btnPreservation.Location = new System.Drawing.Point(458, 176);
            this.btnPreservation.Name = "btnPreservation";
            this.btnPreservation.Size = new System.Drawing.Size(76, 42);
            this.btnPreservation.TabIndex = 5;
            this.btnPreservation.Text = "保存";
            this.btnPreservation.UseVisualStyleBackColor = true;
            this.btnPreservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(194, 176);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(79, 42);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // 仓库名
            // 
            this.仓库名.DataPropertyName = "kcmc";
            this.仓库名.HeaderText = "仓库名";
            this.仓库名.Name = "仓库名";
            // 
            // 商品名称
            // 
            this.商品名称.DataPropertyName = "spmc";
            this.商品名称.HeaderText = "商品名称";
            this.商品名称.Name = "商品名称";
            // 
            // 库存数量
            // 
            this.库存数量.DataPropertyName = "kcsl";
            this.库存数量.HeaderText = "库存数量";
            this.库存数量.Name = "库存数量";
            // 
            // 报警数量
            // 
            this.报警数量.DataPropertyName = "kcbj";
            this.报警数量.HeaderText = "报警数量";
            this.报警数量.Name = "报警数量";
            // 
            // 修改
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "修改";
            this.修改.DefaultCellStyle = dataGridViewCellStyle1;
            this.修改.HeaderText = "修改";
            this.修改.Name = "修改";
            // 
            // Stock_alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 500);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnPreservation);
            this.Controls.Add(this.txtStockNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWarehouses);
            this.Controls.Add(this.txtCommodityName);
            this.Controls.Add(this.txtAlarmQuantity);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Stock_alarm";
            this.Text = "库存报警";
            this.Load += new System.EventHandler(this.Stock_alarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TextBox txtAlarmQuantity;
        private System.Windows.Forms.TextBox txtCommodityName;
        private System.Windows.Forms.TextBox txtWarehouses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockNumber;
        private System.Windows.Forms.Button btnPreservation;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报警数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仓库名;
    }
}