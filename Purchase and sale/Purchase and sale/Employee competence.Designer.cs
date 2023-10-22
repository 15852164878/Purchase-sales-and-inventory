namespace Purchase_and_sale
{
    partial class Employee_competence
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
            this.ltbOut = new System.Windows.Forms.ListBox();
            this.ltbIn = new System.Windows.Forms.ListBox();
            this.btnInAll = new System.Windows.Forms.Button();
            this.btnInOne = new System.Windows.Forms.Button();
            this.btnOutOne = new System.Windows.Forms.Button();
            this.btnOutAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSee = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbOut
            // 
            this.ltbOut.FormattingEnabled = true;
            this.ltbOut.ItemHeight = 15;
            this.ltbOut.Location = new System.Drawing.Point(74, 217);
            this.ltbOut.Name = "ltbOut";
            this.ltbOut.Size = new System.Drawing.Size(215, 259);
            this.ltbOut.TabIndex = 7;
            // 
            // ltbIn
            // 
            this.ltbIn.FormattingEnabled = true;
            this.ltbIn.ItemHeight = 15;
            this.ltbIn.Location = new System.Drawing.Point(538, 217);
            this.ltbIn.Name = "ltbIn";
            this.ltbIn.Size = new System.Drawing.Size(230, 259);
            this.ltbIn.TabIndex = 8;
            // 
            // btnInAll
            // 
            this.btnInAll.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInAll.Location = new System.Drawing.Point(374, 214);
            this.btnInAll.Name = "btnInAll";
            this.btnInAll.Size = new System.Drawing.Size(78, 37);
            this.btnInAll.TabIndex = 9;
            this.btnInAll.Text = ">>";
            this.btnInAll.UseVisualStyleBackColor = true;
            this.btnInAll.Click += new System.EventHandler(this.btninall_Click);
            // 
            // btnInOne
            // 
            this.btnInOne.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btnInOne.Location = new System.Drawing.Point(375, 290);
            this.btnInOne.Name = "btnInOne";
            this.btnInOne.Size = new System.Drawing.Size(78, 37);
            this.btnInOne.TabIndex = 10;
            this.btnInOne.Text = ">";
            this.btnInOne.UseVisualStyleBackColor = true;
            this.btnInOne.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOutOne
            // 
            this.btnOutOne.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOutOne.Location = new System.Drawing.Point(375, 362);
            this.btnOutOne.Name = "btnOutOne";
            this.btnOutOne.Size = new System.Drawing.Size(78, 37);
            this.btnOutOne.TabIndex = 11;
            this.btnOutOne.Text = "<";
            this.btnOutOne.UseVisualStyleBackColor = true;
            this.btnOutOne.Click += new System.EventHandler(this.btnoutone_Click);
            // 
            // btnOutAll
            // 
            this.btnOutAll.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOutAll.Location = new System.Drawing.Point(375, 435);
            this.btnOutAll.Name = "btnOutAll";
            this.btnOutAll.Size = new System.Drawing.Size(78, 37);
            this.btnOutAll.TabIndex = 12;
            this.btnOutAll.Text = "<<";
            this.btnOutAll.UseVisualStyleBackColor = true;
            this.btnOutAll.Click += new System.EventHandler(this.btnoutall_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(690, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 37);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "员工ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "员工姓名";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 25);
            this.txtId.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(390, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 25);
            this.txtName.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "未分配";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "已分配";
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(592, 78);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(67, 36);
            this.btnSee.TabIndex = 19;
            this.btnSee.Text = "查看";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主菜单ToolStripMenuItem
            // 
            this.返回主菜单ToolStripMenuItem.Name = "返回主菜单ToolStripMenuItem";
            this.返回主菜单ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主菜单ToolStripMenuItem.Text = "返回主界面";
            this.返回主菜单ToolStripMenuItem.Click += new System.EventHandler(this.返回主菜单ToolStripMenuItem_Click);
            // 
            // Employee_competence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 529);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOutAll);
            this.Controls.Add(this.btnOutOne);
            this.Controls.Add(this.btnInOne);
            this.Controls.Add(this.btnInAll);
            this.Controls.Add(this.ltbIn);
            this.Controls.Add(this.ltbOut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee_competence";
            this.Text = "员工权限";
            this.Load += new System.EventHandler(this.Employee_competence_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ltbOut;
        private System.Windows.Forms.ListBox ltbIn;
        private System.Windows.Forms.Button btnInAll;
        private System.Windows.Forms.Button btnInOne;
        private System.Windows.Forms.Button btnOutOne;
        private System.Windows.Forms.Button btnOutAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主菜单ToolStripMenuItem;
    }
}