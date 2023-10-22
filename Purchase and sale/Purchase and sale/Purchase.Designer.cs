namespace Purchase_and_sale
{
    partial class Purchase
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCommodity = new System.Windows.Forms.DataGridView();
            this.商品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品厂家 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品信息 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPurchaser = new System.Windows.Forms.TextBox();
            this.txtPurchaseTime = new System.Windows.Forms.TextBox();
            this.txtPurchaseNumber = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStockPurchase = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCommodityId = new System.Windows.Forms.Label();
            this.lblCommodityName = new System.Windows.Forms.Label();
            this.lblCommodityType = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvManufactor = new System.Windows.Forms.DataGridView();
            this.厂家编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家信息 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblManufactorId = new System.Windows.Forms.Label();
            this.lblManufactorName = new System.Windows.Forms.Label();
            this.lblManufactorPeople = new System.Windows.Forms.Label();
            this.lblManufacturerTelephone = new System.Windows.Forms.Label();
            this.lblManufactorAddress = new System.Windows.Forms.Label();
            this.btnFactoryEnquiry = new System.Windows.Forms.Button();
            this.txtManufacturerId = new System.Windows.Forms.TextBox();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.txtFactoryConditions = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWarehouse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufactor)).BeginInit();
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
            this.商品厂家,
            this.商品信息});
            this.dgvCommodity.Location = new System.Drawing.Point(407, 310);
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.RowTemplate.Height = 27;
            this.dgvCommodity.Size = new System.Drawing.Size(833, 228);
            this.dgvCommodity.TabIndex = 1;
            this.dgvCommodity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvjh_CellContentClick);
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
            // 商品厂家
            // 
            this.商品厂家.DataPropertyName = "cjid";
            this.商品厂家.HeaderText = "商品厂家";
            this.商品厂家.Name = "商品厂家";
            // 
            // 商品信息
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "进货";
            this.商品信息.DefaultCellStyle = dataGridViewCellStyle3;
            this.商品信息.FillWeight = 50F;
            this.商品信息.HeaderText = "商品信息";
            this.商品信息.Name = "商品信息";
            this.商品信息.Width = 50;
            // 
            // txtPurchaser
            // 
            this.txtPurchaser.Location = new System.Drawing.Point(133, 353);
            this.txtPurchaser.Name = "txtPurchaser";
            this.txtPurchaser.Size = new System.Drawing.Size(143, 25);
            this.txtPurchaser.TabIndex = 5;
            // 
            // txtPurchaseTime
            // 
            this.txtPurchaseTime.Location = new System.Drawing.Point(133, 482);
            this.txtPurchaseTime.Name = "txtPurchaseTime";
            this.txtPurchaseTime.Size = new System.Drawing.Size(177, 25);
            this.txtPurchaseTime.TabIndex = 6;
            // 
            // txtPurchaseNumber
            // 
            this.txtPurchaseNumber.Location = new System.Drawing.Point(133, 396);
            this.txtPurchaseNumber.Name = "txtPurchaseNumber";
            this.txtPurchaseNumber.Size = new System.Drawing.Size(143, 25);
            this.txtPurchaseNumber.TabIndex = 10;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(133, 440);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(143, 25);
            this.txtPurchasePrice.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "进货人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "商品编号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "进货数量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "进货时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "商品名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "厂家编号";
            // 
            // btnStockPurchase
            // 
            this.btnStockPurchase.Location = new System.Drawing.Point(133, 565);
            this.btnStockPurchase.Name = "btnStockPurchase";
            this.btnStockPurchase.Size = new System.Drawing.Size(99, 57);
            this.btnStockPurchase.TabIndex = 20;
            this.btnStockPurchase.Text = "进货入库";
            this.btnStockPurchase.UseVisualStyleBackColor = true;
            this.btnStockPurchase.Click += new System.EventHandler(this.btntj_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(39, 441);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 15);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "进货价格";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1005, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "商品类型";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblCommodityId
            // 
            this.lblCommodityId.AutoSize = true;
            this.lblCommodityId.Location = new System.Drawing.Point(130, 235);
            this.lblCommodityId.Name = "lblCommodityId";
            this.lblCommodityId.Size = new System.Drawing.Size(55, 15);
            this.lblCommodityId.TabIndex = 25;
            this.lblCommodityId.Text = "------";
            // 
            // lblCommodityName
            // 
            this.lblCommodityName.AutoSize = true;
            this.lblCommodityName.Location = new System.Drawing.Point(130, 275);
            this.lblCommodityName.Name = "lblCommodityName";
            this.lblCommodityName.Size = new System.Drawing.Size(55, 15);
            this.lblCommodityName.TabIndex = 25;
            this.lblCommodityName.Text = "------";
            this.lblCommodityName.Click += new System.EventHandler(this.lblmc_Click);
            // 
            // lblCommodityType
            // 
            this.lblCommodityType.AutoSize = true;
            this.lblCommodityType.Location = new System.Drawing.Point(130, 307);
            this.lblCommodityType.Name = "lblCommodityType";
            this.lblCommodityType.Size = new System.Drawing.Size(55, 15);
            this.lblCommodityType.TabIndex = 25;
            this.lblCommodityType.Text = "------";
            this.lblCommodityType.Click += new System.EventHandler(this.lblCommodityType_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "厂家名称";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "厂家负责人";
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
            this.厂家信息});
            this.dgvManufactor.Location = new System.Drawing.Point(407, 31);
            this.dgvManufactor.Name = "dgvManufactor";
            this.dgvManufactor.RowTemplate.Height = 27;
            this.dgvManufactor.Size = new System.Drawing.Size(844, 219);
            this.dgvManufactor.TabIndex = 26;
            this.dgvManufactor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcj_CellContentClick);
            // 
            // 厂家编号
            // 
            this.厂家编号.DataPropertyName = "cjid";
            this.厂家编号.HeaderText = "厂家编号";
            this.厂家编号.Name = "厂家编号";
            this.厂家编号.Width = 70;
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
            // 厂家信息
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "进货";
            this.厂家信息.DefaultCellStyle = dataGridViewCellStyle4;
            this.厂家信息.HeaderText = "厂家信息";
            this.厂家信息.Name = "厂家信息";
            this.厂家信息.Width = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "厂家电话";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "厂家地址";
            // 
            // lblManufactorId
            // 
            this.lblManufactorId.AutoSize = true;
            this.lblManufactorId.Location = new System.Drawing.Point(130, 53);
            this.lblManufactorId.Name = "lblManufactorId";
            this.lblManufactorId.Size = new System.Drawing.Size(55, 15);
            this.lblManufactorId.TabIndex = 25;
            this.lblManufactorId.Text = "------";
            // 
            // lblManufactorName
            // 
            this.lblManufactorName.AutoSize = true;
            this.lblManufactorName.Location = new System.Drawing.Point(130, 89);
            this.lblManufactorName.Name = "lblManufactorName";
            this.lblManufactorName.Size = new System.Drawing.Size(55, 15);
            this.lblManufactorName.TabIndex = 25;
            this.lblManufactorName.Text = "------";
            // 
            // lblManufactorPeople
            // 
            this.lblManufactorPeople.AutoSize = true;
            this.lblManufactorPeople.Location = new System.Drawing.Point(130, 125);
            this.lblManufactorPeople.Name = "lblManufactorPeople";
            this.lblManufactorPeople.Size = new System.Drawing.Size(55, 15);
            this.lblManufactorPeople.TabIndex = 25;
            this.lblManufactorPeople.Text = "------";
            // 
            // lblManufacturerTelephone
            // 
            this.lblManufacturerTelephone.AutoSize = true;
            this.lblManufacturerTelephone.Location = new System.Drawing.Point(130, 161);
            this.lblManufacturerTelephone.Name = "lblManufacturerTelephone";
            this.lblManufacturerTelephone.Size = new System.Drawing.Size(55, 15);
            this.lblManufacturerTelephone.TabIndex = 25;
            this.lblManufacturerTelephone.Text = "------";
            // 
            // lblManufactorAddress
            // 
            this.lblManufactorAddress.AutoSize = true;
            this.lblManufactorAddress.Location = new System.Drawing.Point(130, 200);
            this.lblManufactorAddress.Name = "lblManufactorAddress";
            this.lblManufactorAddress.Size = new System.Drawing.Size(55, 15);
            this.lblManufactorAddress.TabIndex = 25;
            this.lblManufactorAddress.Text = "------";
            // 
            // btnFactoryEnquiry
            // 
            this.btnFactoryEnquiry.Location = new System.Drawing.Point(719, 260);
            this.btnFactoryEnquiry.Name = "btnFactoryEnquiry";
            this.btnFactoryEnquiry.Size = new System.Drawing.Size(58, 34);
            this.btnFactoryEnquiry.TabIndex = 27;
            this.btnFactoryEnquiry.Text = "查询";
            this.btnFactoryEnquiry.UseVisualStyleBackColor = true;
            this.btnFactoryEnquiry.Click += new System.EventHandler(this.btncj_Click);
            // 
            // txtManufacturerId
            // 
            this.txtManufacturerId.Location = new System.Drawing.Point(636, 572);
            this.txtManufacturerId.Name = "txtManufacturerId";
            this.txtManufacturerId.Size = new System.Drawing.Size(116, 25);
            this.txtManufacturerId.TabIndex = 30;
            // 
            // btnManufacturer
            // 
            this.btnManufacturer.Location = new System.Drawing.Point(791, 572);
            this.btnManufacturer.Name = "btnManufacturer";
            this.btnManufacturer.Size = new System.Drawing.Size(62, 34);
            this.btnManufacturer.TabIndex = 32;
            this.btnManufacturer.Text = "查询";
            this.btnManufacturer.UseVisualStyleBackColor = true;
            this.btnManufacturer.Click += new System.EventHandler(this.btnManufacturer_Click);
            // 
            // txtFactoryConditions
            // 
            this.txtFactoryConditions.Location = new System.Drawing.Point(565, 265);
            this.txtFactoryConditions.Name = "txtFactoryConditions";
            this.txtFactoryConditions.Size = new System.Drawing.Size(116, 25);
            this.txtFactoryConditions.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "仓库名称";
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.Location = new System.Drawing.Point(134, 527);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Size = new System.Drawing.Size(141, 25);
            this.txtWarehouse.TabIndex = 35;
            this.txtWarehouse.Text = "食品库";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 646);
            this.Controls.Add(this.txtWarehouse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnManufacturer);
            this.Controls.Add(this.txtFactoryConditions);
            this.Controls.Add(this.txtManufacturerId);
            this.Controls.Add(this.btnFactoryEnquiry);
            this.Controls.Add(this.dgvManufactor);
            this.Controls.Add(this.lblManufactorAddress);
            this.Controls.Add(this.lblManufacturerTelephone);
            this.Controls.Add(this.lblManufactorPeople);
            this.Controls.Add(this.lblManufactorName);
            this.Controls.Add(this.lblManufactorId);
            this.Controls.Add(this.lblCommodityType);
            this.Controls.Add(this.lblCommodityName);
            this.Controls.Add(this.lblCommodityId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStockPurchase);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtPurchaseNumber);
            this.Controls.Add(this.txtPurchaseTime);
            this.Controls.Add(this.txtPurchaser);
            this.Controls.Add(this.dgvCommodity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Purchase";
            this.Text = "进货表";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufactor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCommodity;
        private System.Windows.Forms.TextBox txtPurchaser;
        private System.Windows.Forms.TextBox txtPurchaseTime;
        private System.Windows.Forms.TextBox txtPurchaseNumber;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStockPurchase;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCommodityId;
        private System.Windows.Forms.Label lblCommodityName;
        private System.Windows.Forms.Label lblCommodityType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvManufactor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblManufactorId;
        private System.Windows.Forms.Label lblManufactorName;
        private System.Windows.Forms.Label lblManufactorPeople;
        private System.Windows.Forms.Label lblManufacturerTelephone;
        private System.Windows.Forms.Label lblManufactorAddress;
        private System.Windows.Forms.Button btnFactoryEnquiry;
        private System.Windows.Forms.TextBox txtManufacturerId;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品厂家;
        private System.Windows.Forms.DataGridViewButtonColumn 商品信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品编号;
        private System.Windows.Forms.TextBox txtFactoryConditions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn 厂家信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家负责人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家编号;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWarehouse;
    }
}