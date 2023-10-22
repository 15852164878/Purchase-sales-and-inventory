namespace Purchase_and_sale
{
    partial class Statistics
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
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.仓库名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进货价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存报警 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂家地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系人电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cbmCondition = new System.Windows.Forms.ComboBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仓库名,
            this.商品名称,
            this.商品类型,
            this.进货价格,
            this.库存数量,
            this.库存报警,
            this.厂家名称,
            this.厂家地址,
            this.联系人,
            this.联系人电话});
            this.dgvStatistics.Location = new System.Drawing.Point(8, 40);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowTemplate.Height = 27;
            this.dgvStatistics.Size = new System.Drawing.Size(1527, 530);
            this.dgvStatistics.TabIndex = 0;
            this.dgvStatistics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatistics_CellContentClick_1);
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
            // 商品类型
            // 
            this.商品类型.DataPropertyName = "splx";
            this.商品类型.HeaderText = "商品类型";
            this.商品类型.Name = "商品类型";
            // 
            // 进货价格
            // 
            this.进货价格.DataPropertyName = "spjg";
            this.进货价格.HeaderText = "进货价格";
            this.进货价格.Name = "进货价格";
            // 
            // 库存数量
            // 
            this.库存数量.DataPropertyName = "kcsl";
            this.库存数量.HeaderText = "库存数量";
            this.库存数量.Name = "库存数量";
            // 
            // 库存报警
            // 
            this.库存报警.DataPropertyName = "kcbj";
            this.库存报警.HeaderText = "库存报警";
            this.库存报警.Name = "库存报警";
            // 
            // 厂家名称
            // 
            this.厂家名称.DataPropertyName = "cjmc";
            this.厂家名称.HeaderText = "厂家名称";
            this.厂家名称.Name = "厂家名称";
            this.厂家名称.Width = 130;
            // 
            // 厂家地址
            // 
            this.厂家地址.DataPropertyName = "cjdz";
            this.厂家地址.HeaderText = "厂家地址";
            this.厂家地址.Name = "厂家地址";
            this.厂家地址.Width = 150;
            // 
            // 联系人
            // 
            this.联系人.DataPropertyName = "cjfzr";
            this.联系人.HeaderText = "联系人";
            this.联系人.Name = "联系人";
            // 
            // 联系人电话
            // 
            this.联系人电话.DataPropertyName = "cjdh";
            this.联系人电话.HeaderText = "联系人电话";
            this.联系人电话.Name = "联系人电话";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(866, 595);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(84, 39);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbmCondition
            // 
            this.cbmCondition.FormattingEnabled = true;
            this.cbmCondition.Items.AddRange(new object[] {
            "显示所有",
            "仓库名",
            "商品名称"});
            this.cbmCondition.Location = new System.Drawing.Point(532, 600);
            this.cbmCondition.Name = "cbmCondition";
            this.cbmCondition.Size = new System.Drawing.Size(123, 23);
            this.cbmCondition.TabIndex = 2;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(698, 598);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(107, 25);
            this.txtCondition.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "查询条件";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1539, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.cbmCondition);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dgvStatistics);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Statistics";
            this.Text = "统计";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cbmCondition;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系人电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂家名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存报警;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进货价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仓库名;
    }
}