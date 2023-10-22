namespace Purchase_and_sale
{
    partial class sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCommodity = new System.Windows.Forms.DataGridView();
            this.商品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.折扣率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品信息 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.txtUnitPriceOfAles = new System.Windows.Forms.TextBox();
            this.txtSalesVolumes = new System.Windows.Forms.TextBox();
            this.txtSalesDate = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblspid = new System.Windows.Forms.Label();
            this.lblCommodityName = new System.Windows.Forms.Label();
            this.lblsplx = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCommodityInquiry = new System.Windows.Forms.Button();
            this.txtInputCondition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStockNumber = new System.Windows.Forms.Label();
            this.btnSettlement = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCopeWith = new System.Windows.Forms.Label();
            this.txtActualPayment = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCommodityOriginal = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.商品品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
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
            this.折扣率,
            this.库存数量,
            this.商品信息});
            this.dgvCommodity.Location = new System.Drawing.Point(322, 31);
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.Size = new System.Drawing.Size(984, 227);
            this.dgvCommodity.TabIndex = 1;
            this.dgvCommodity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvxs_CellContentClick);
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
            // 折扣率
            // 
            this.折扣率.DataPropertyName = "zkl";
            this.折扣率.HeaderText = "折扣率";
            this.折扣率.Name = "折扣率";
            // 
            // 库存数量
            // 
            this.库存数量.DataPropertyName = "kcsl";
            this.库存数量.HeaderText = "库存数量";
            this.库存数量.Name = "库存数量";
            // 
            // 商品信息
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "销售";
            this.商品信息.DefaultCellStyle = dataGridViewCellStyle2;
            this.商品信息.HeaderText = "商品信息";
            this.商品信息.Name = "商品信息";
            this.商品信息.Width = 80;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(119, 571);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(112, 47);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "销售";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btntj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "销售人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "销售单价";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "销售数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "销售日期";
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(134, 288);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Size = new System.Drawing.Size(129, 25);
            this.txtSalesPerson.TabIndex = 9;
            // 
            // txtUnitPriceOfAles
            // 
            this.txtUnitPriceOfAles.Location = new System.Drawing.Point(134, 334);
            this.txtUnitPriceOfAles.Name = "txtUnitPriceOfAles";
            this.txtUnitPriceOfAles.Size = new System.Drawing.Size(129, 25);
            this.txtUnitPriceOfAles.TabIndex = 9;
            // 
            // txtSalesVolumes
            // 
            this.txtSalesVolumes.Location = new System.Drawing.Point(134, 381);
            this.txtSalesVolumes.Name = "txtSalesVolumes";
            this.txtSalesVolumes.Size = new System.Drawing.Size(129, 25);
            this.txtSalesVolumes.TabIndex = 9;
            // 
            // txtSalesDate
            // 
            this.txtSalesDate.Location = new System.Drawing.Point(134, 424);
            this.txtSalesDate.Name = "txtSalesDate";
            this.txtSalesDate.Size = new System.Drawing.Size(162, 25);
            this.txtSalesDate.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1054, 638);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "商品编号";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "商品名称";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "商品类型";
            // 
            // lblspid
            // 
            this.lblspid.AutoSize = true;
            this.lblspid.Location = new System.Drawing.Point(131, 63);
            this.lblspid.Name = "lblspid";
            this.lblspid.Size = new System.Drawing.Size(55, 15);
            this.lblspid.TabIndex = 14;
            this.lblspid.Text = "------";
            // 
            // lblCommodityName
            // 
            this.lblCommodityName.AutoSize = true;
            this.lblCommodityName.Location = new System.Drawing.Point(131, 108);
            this.lblCommodityName.Name = "lblCommodityName";
            this.lblCommodityName.Size = new System.Drawing.Size(55, 15);
            this.lblCommodityName.TabIndex = 14;
            this.lblCommodityName.Text = "------";
            // 
            // lblsplx
            // 
            this.lblsplx.AutoSize = true;
            this.lblsplx.Location = new System.Drawing.Point(131, 153);
            this.lblsplx.Name = "lblsplx";
            this.lblsplx.Size = new System.Drawing.Size(55, 15);
            this.lblsplx.TabIndex = 14;
            this.lblsplx.Text = "------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "盈利";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(133, 473);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(129, 25);
            this.txtProfit.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(662, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "商品名称";
            // 
            // btnCommodityInquiry
            // 
            this.btnCommodityInquiry.Location = new System.Drawing.Point(916, 278);
            this.btnCommodityInquiry.Name = "btnCommodityInquiry";
            this.btnCommodityInquiry.Size = new System.Drawing.Size(59, 30);
            this.btnCommodityInquiry.TabIndex = 22;
            this.btnCommodityInquiry.Text = "查询";
            this.btnCommodityInquiry.UseVisualStyleBackColor = true;
            this.btnCommodityInquiry.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInputCondition
            // 
            this.txtInputCondition.Location = new System.Drawing.Point(771, 278);
            this.txtInputCondition.Name = "txtInputCondition";
            this.txtInputCondition.Size = new System.Drawing.Size(105, 25);
            this.txtInputCondition.TabIndex = 23;
            this.txtInputCondition.Text = "死神辣条";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "库存数量";
            // 
            // lblStockNumber
            // 
            this.lblStockNumber.AutoSize = true;
            this.lblStockNumber.Location = new System.Drawing.Point(133, 196);
            this.lblStockNumber.Name = "lblStockNumber";
            this.lblStockNumber.Size = new System.Drawing.Size(55, 15);
            this.lblStockNumber.TabIndex = 25;
            this.lblStockNumber.Text = "------";
            // 
            // btnSettlement
            // 
            this.btnSettlement.Location = new System.Drawing.Point(1014, 578);
            this.btnSettlement.Name = "btnSettlement";
            this.btnSettlement.Size = new System.Drawing.Size(89, 40);
            this.btnSettlement.TabIndex = 26;
            this.btnSettlement.Text = "结算";
            this.btnSettlement.UseVisualStyleBackColor = true;
            this.btnSettlement.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(969, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "实付：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(969, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "应付：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(964, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "找零：";
            // 
            // txtCopeWith
            // 
            this.txtCopeWith.AutoSize = true;
            this.txtCopeWith.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCopeWith.Location = new System.Drawing.Point(1056, 446);
            this.txtCopeWith.Name = "txtCopeWith";
            this.txtCopeWith.Size = new System.Drawing.Size(88, 24);
            this.txtCopeWith.TabIndex = 30;
            this.txtCopeWith.Text = "------";
            // 
            // txtActualPayment
            // 
            this.txtActualPayment.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtActualPayment.Location = new System.Drawing.Point(1060, 376);
            this.txtActualPayment.Name = "txtActualPayment";
            this.txtActualPayment.Size = new System.Drawing.Size(91, 30);
            this.txtActualPayment.TabIndex = 31;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblChange.Location = new System.Drawing.Point(1057, 510);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(88, 24);
            this.lblChange.TabIndex = 32;
            this.lblChange.Text = "------";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 28);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "商品原价";
            // 
            // lblCommodityOriginal
            // 
            this.lblCommodityOriginal.AutoSize = true;
            this.lblCommodityOriginal.Location = new System.Drawing.Point(133, 243);
            this.lblCommodityOriginal.Name = "lblCommodityOriginal";
            this.lblCommodityOriginal.Size = new System.Drawing.Size(55, 15);
            this.lblCommodityOriginal.TabIndex = 35;
            this.lblCommodityOriginal.Text = "------";
            this.lblCommodityOriginal.Click += new System.EventHandler(this.lblCommodityOriginal_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品品名,
            this.数量,
            this.金额});
            this.dgvOrder.Location = new System.Drawing.Point(318, 334);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(467, 241);
            this.dgvOrder.TabIndex = 36;
            // 
            // 商品品名
            // 
            this.商品品名.DataPropertyName = "sppm";
            this.商品品名.HeaderText = "商品品名";
            this.商品品名.Name = "商品品名";
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "sl";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            // 
            // 金额
            // 
            this.金额.DataPropertyName = "je";
            this.金额.HeaderText = "金额";
            this.金额.Name = "金额";
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 661);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.lblCommodityOriginal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtActualPayment);
            this.Controls.Add(this.txtCopeWith);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSettlement);
            this.Controls.Add(this.lblStockNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInputCondition);
            this.Controls.Add(this.btnCommodityInquiry);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblsplx);
            this.Controls.Add(this.lblCommodityName);
            this.Controls.Add(this.lblspid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalesVolumes);
            this.Controls.Add(this.txtSalesDate);
            this.Controls.Add(this.txtUnitPriceOfAles);
            this.Controls.Add(this.txtSalesPerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.dgvCommodity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sales";
            this.Text = "销售单";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCommodity;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.TextBox txtUnitPriceOfAles;
        private System.Windows.Forms.TextBox txtSalesVolumes;
        private System.Windows.Forms.TextBox txtSalesDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblspid;
        private System.Windows.Forms.Label lblCommodityName;
        private System.Windows.Forms.Label lblsplx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCommodityInquiry;
        private System.Windows.Forms.TextBox txtInputCondition;
        private System.Windows.Forms.Label lblStockNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSettlement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtCopeWith;
        private System.Windows.Forms.TextBox txtActualPayment;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCommodityOriginal;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewButtonColumn 商品信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 折扣率;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品品名;
    }
}