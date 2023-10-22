namespace Purchase_and_sale
{
    partial class Manufactor
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
            this.dgvManufactor = new System.Windows.Forms.DataGridView();
            this.btnAddTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.txtPersonInChargeOfTheManufacturer = new System.Windows.Forms.TextBox();
            this.txtManufacturerTelephoneNumber = new System.Windows.Forms.TextBox();
            this.txtManufacturerAddress = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.厂家编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufactor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManufactor
            // 
            this.dgvManufactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.厂家编号,
            this.厂家名称,
            this.厂家负责人,
            this.厂家电话,
            this.厂家地址,
            this.修改,
            this.删除});
            this.dgvManufactor.Location = new System.Drawing.Point(12, 180);
            this.dgvManufactor.Name = "dgvManufactor";
            this.dgvManufactor.RowTemplate.Height = 27;
            this.dgvManufactor.Size = new System.Drawing.Size(948, 436);
            this.dgvManufactor.TabIndex = 0;
            this.dgvManufactor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnAddTo
            // 
            this.btnAddTo.Location = new System.Drawing.Point(706, 53);
            this.btnAddTo.Name = "btnAddTo";
            this.btnAddTo.Size = new System.Drawing.Size(77, 39);
            this.btnAddTo.TabIndex = 1;
            this.btnAddTo.Text = "添加";
            this.btnAddTo.UseVisualStyleBackColor = true;
            this.btnAddTo.Click += new System.EventHandler(this.btntj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "厂家名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "厂家负责人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "厂家电话";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "厂家地址";
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.Location = new System.Drawing.Point(175, 56);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(138, 25);
            this.txtManufacturerName.TabIndex = 3;
            this.txtManufacturerName.TextChanged += new System.EventHandler(this.txtcjmc_TextChanged);
            // 
            // txtPersonInChargeOfTheManufacturer
            // 
            this.txtPersonInChargeOfTheManufacturer.Location = new System.Drawing.Point(175, 116);
            this.txtPersonInChargeOfTheManufacturer.Name = "txtPersonInChargeOfTheManufacturer";
            this.txtPersonInChargeOfTheManufacturer.Size = new System.Drawing.Size(138, 25);
            this.txtPersonInChargeOfTheManufacturer.TabIndex = 3;
            // 
            // txtManufacturerTelephoneNumber
            // 
            this.txtManufacturerTelephoneNumber.Location = new System.Drawing.Point(485, 53);
            this.txtManufacturerTelephoneNumber.Name = "txtManufacturerTelephoneNumber";
            this.txtManufacturerTelephoneNumber.Size = new System.Drawing.Size(136, 25);
            this.txtManufacturerTelephoneNumber.TabIndex = 3;
            // 
            // txtManufacturerAddress
            // 
            this.txtManufacturerAddress.Location = new System.Drawing.Point(485, 109);
            this.txtManufacturerAddress.Name = "txtManufacturerAddress";
            this.txtManufacturerAddress.Size = new System.Drawing.Size(136, 25);
            this.txtManufacturerAddress.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(706, 103);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(77, 33);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btncj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 28);
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
            // 厂家编号
            // 
            this.厂家编号.DataPropertyName = "cjid";
            this.厂家编号.HeaderText = "厂家编号";
            this.厂家编号.Name = "厂家编号";
            this.厂家编号.Width = 80;
            // 
            // 厂家名称
            // 
            this.厂家名称.DataPropertyName = "cjmc";
            this.厂家名称.HeaderText = "厂家名称";
            this.厂家名称.Name = "厂家名称";
            this.厂家名称.Width = 130;
            // 
            // 厂家负责人
            // 
            this.厂家负责人.DataPropertyName = "cjfzr";
            this.厂家负责人.HeaderText = "厂家负责人";
            this.厂家负责人.Name = "厂家负责人";
            this.厂家负责人.Width = 90;
            // 
            // 厂家电话
            // 
            this.厂家电话.DataPropertyName = "cjdh";
            this.厂家电话.HeaderText = "厂家电话";
            this.厂家电话.Name = "厂家电话";
            this.厂家电话.Width = 90;
            // 
            // 厂家地址
            // 
            this.厂家地址.DataPropertyName = "cjdz";
            this.厂家地址.HeaderText = "厂家地址";
            this.厂家地址.Name = "厂家地址";
            this.厂家地址.Width = 140;
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
            // Manufactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 628);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtManufacturerAddress);
            this.Controls.Add(this.txtManufacturerTelephoneNumber);
            this.Controls.Add(this.txtPersonInChargeOfTheManufacturer);
            this.Controls.Add(this.txtManufacturerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTo);
            this.Controls.Add(this.dgvManufactor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manufactor";
            this.Text = "厂家";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufactor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManufactor;
        private System.Windows.Forms.Button btnAddTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.TextBox txtPersonInChargeOfTheManufacturer;
        private System.Windows.Forms.TextBox txtManufacturerTelephoneNumber;
        private System.Windows.Forms.TextBox txtManufacturerAddress;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家负责人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家编号;
    }
}