namespace Purchase_and_sale
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bjkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.折扣ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存报警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentOperator = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.基础信息管理ToolStripMenuItem,
            this.进货管理ToolStripMenuItem,
            this.库存管理ToolStripMenuItem,
            this.销售管理ToolStripMenuItem,
            this.重新登陆ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工注册ToolStripMenuItem,
            this.员工权限ToolStripMenuItem,
            this.员工信息ToolStripMenuItem});
            this.员工管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.员工管理ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // 员工注册ToolStripMenuItem
            // 
            this.员工注册ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("员工注册ToolStripMenuItem.BackgroundImage")));
            this.员工注册ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.员工注册ToolStripMenuItem.Name = "员工注册ToolStripMenuItem";
            this.员工注册ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.员工注册ToolStripMenuItem.Text = "员工注册";
            this.员工注册ToolStripMenuItem.Click += new System.EventHandler(this.员工注册ToolStripMenuItem_Click);
            // 
            // 员工权限ToolStripMenuItem
            // 
            this.员工权限ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("员工权限ToolStripMenuItem.BackgroundImage")));
            this.员工权限ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.员工权限ToolStripMenuItem.Name = "员工权限ToolStripMenuItem";
            this.员工权限ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.员工权限ToolStripMenuItem.Text = "员工权限";
            this.员工权限ToolStripMenuItem.Click += new System.EventHandler(this.员工权限ToolStripMenuItem_Click);
            // 
            // 员工信息ToolStripMenuItem
            // 
            this.员工信息ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("员工信息ToolStripMenuItem.BackgroundImage")));
            this.员工信息ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.员工信息ToolStripMenuItem.Name = "员工信息ToolStripMenuItem";
            this.员工信息ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.员工信息ToolStripMenuItem.Text = "员工信息";
            this.员工信息ToolStripMenuItem.Click += new System.EventHandler(this.员工信息ToolStripMenuItem_Click);
            // 
            // 基础信息管理ToolStripMenuItem
            // 
            this.基础信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bjkToolStripMenuItem,
            this.商品ToolStripMenuItem,
            this.折扣ToolStripMenuItem,
            this.库存报警ToolStripMenuItem});
            this.基础信息管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.基础信息管理ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.基础信息管理ToolStripMenuItem.Name = "基础信息管理ToolStripMenuItem";
            this.基础信息管理ToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.基础信息管理ToolStripMenuItem.Text = "基础信息管理";
            // 
            // bjkToolStripMenuItem
            // 
            this.bjkToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bjkToolStripMenuItem.BackgroundImage")));
            this.bjkToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bjkToolStripMenuItem.Name = "bjkToolStripMenuItem";
            this.bjkToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.bjkToolStripMenuItem.Text = "厂家";
            this.bjkToolStripMenuItem.Click += new System.EventHandler(this.bjkToolStripMenuItem_Click);
            // 
            // 商品ToolStripMenuItem
            // 
            this.商品ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("商品ToolStripMenuItem.BackgroundImage")));
            this.商品ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
            this.商品ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.商品ToolStripMenuItem.Text = "商品";
            this.商品ToolStripMenuItem.Click += new System.EventHandler(this.商品ToolStripMenuItem_Click);
            // 
            // 折扣ToolStripMenuItem
            // 
            this.折扣ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("折扣ToolStripMenuItem.BackgroundImage")));
            this.折扣ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.折扣ToolStripMenuItem.Name = "折扣ToolStripMenuItem";
            this.折扣ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.折扣ToolStripMenuItem.Text = "折扣";
            this.折扣ToolStripMenuItem.Click += new System.EventHandler(this.折扣ToolStripMenuItem_Click);
            // 
            // 库存报警ToolStripMenuItem
            // 
            this.库存报警ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("库存报警ToolStripMenuItem.BackgroundImage")));
            this.库存报警ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.库存报警ToolStripMenuItem.Name = "库存报警ToolStripMenuItem";
            this.库存报警ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.库存报警ToolStripMenuItem.Text = "库存报警";
            this.库存报警ToolStripMenuItem.Click += new System.EventHandler(this.库存报警ToolStripMenuItem_Click);
            // 
            // 进货管理ToolStripMenuItem
            // 
            this.进货管理ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("进货管理ToolStripMenuItem.BackgroundImage")));
            this.进货管理ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.进货管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进货单ToolStripMenuItem,
            this.查询ToolStripMenuItem});
            this.进货管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.进货管理ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.进货管理ToolStripMenuItem.Name = "进货管理ToolStripMenuItem";
            this.进货管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.进货管理ToolStripMenuItem.Text = "进货管理";
            // 
            // 进货单ToolStripMenuItem
            // 
            this.进货单ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("进货单ToolStripMenuItem.BackgroundImage")));
            this.进货单ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.进货单ToolStripMenuItem.Name = "进货单ToolStripMenuItem";
            this.进货单ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.进货单ToolStripMenuItem.Text = "进货单";
            this.进货单ToolStripMenuItem.Click += new System.EventHandler(this.进货单ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("查询ToolStripMenuItem.BackgroundImage")));
            this.查询ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.统计ToolStripMenuItem});
            this.库存管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.库存管理ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.库存管理ToolStripMenuItem.Text = "库存管理";
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("统计ToolStripMenuItem.BackgroundImage")));
            this.统计ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.统计ToolStripMenuItem.Text = "统计";
            this.统计ToolStripMenuItem.Click += new System.EventHandler(this.统计ToolStripMenuItem_Click);
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售单ToolStripMenuItem,
            this.查询ToolStripMenuItem1});
            this.销售管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.销售管理ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            // 
            // 销售单ToolStripMenuItem
            // 
            this.销售单ToolStripMenuItem.Name = "销售单ToolStripMenuItem";
            this.销售单ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.销售单ToolStripMenuItem.Text = "销售单";
            this.销售单ToolStripMenuItem.Click += new System.EventHandler(this.销售单ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(181, 30);
            this.查询ToolStripMenuItem1.Text = "查询";
            this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.查询ToolStripMenuItem1_Click);
            // 
            // 重新登陆ToolStripMenuItem
            // 
            this.重新登陆ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新登录ToolStripMenuItem});
            this.重新登陆ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.重新登陆ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.重新登陆ToolStripMenuItem.Name = "重新登陆ToolStripMenuItem";
            this.重新登陆ToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.重新登陆ToolStripMenuItem.Text = "设置";
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("重新登录ToolStripMenuItem.BackgroundImage")));
            this.重新登录ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.重新登录ToolStripMenuItem.Text = "重新登录";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(596, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(443, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前时间：";
            // 
            // lblCurrentOperator
            // 
            this.lblCurrentOperator.AutoSize = true;
            this.lblCurrentOperator.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentOperator.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentOperator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCurrentOperator.Location = new System.Drawing.Point(29, 544);
            this.lblCurrentOperator.Name = "lblCurrentOperator";
            this.lblCurrentOperator.Size = new System.Drawing.Size(160, 24);
            this.lblCurrentOperator.TabIndex = 3;
            this.lblCurrentOperator.Text = "当前操作员：";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.BackColor = System.Drawing.Color.Transparent;
            this.lblOperator.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOperator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblOperator.Location = new System.Drawing.Point(195, 544);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(49, 24);
            this.lblOperator.TabIndex = 4;
            this.lblOperator.Text = "---";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 595);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblCurrentOperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "主界面";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工权限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基础信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进货管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bjkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 折扣ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存报警ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.ToolStripMenuItem 重新登陆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
    }
}

