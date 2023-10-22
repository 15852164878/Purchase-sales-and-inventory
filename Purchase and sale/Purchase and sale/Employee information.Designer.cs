namespace Purchase_and_sale
{
    partial class Employee_information
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col员工姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col员工性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col员工年龄 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col未分配 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col已分配 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.查看 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnPreservation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 14F);
            this.btnQuery.Location = new System.Drawing.Point(929, 42);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(70, 40);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btn_Click_1);
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.col员工姓名,
            this.col员工性别,
            this.col员工年龄,
            this.col账号,
            this.col密码,
            this.col未分配,
            this.col已分配,
            this.删除,
            this.查看});
            this.dgvStaff.Location = new System.Drawing.Point(16, 188);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowTemplate.Height = 27;
            this.dgvStaff.Size = new System.Drawing.Size(1319, 419);
            this.dgvStaff.TabIndex = 4;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvygxx_CellContentClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "colID";
            this.colID.Name = "colID";
            // 
            // col员工姓名
            // 
            this.col员工姓名.DataPropertyName = "name";
            this.col员工姓名.HeaderText = "col员工姓名";
            this.col员工姓名.Name = "col员工姓名";
            // 
            // col员工性别
            // 
            this.col员工性别.DataPropertyName = "sex";
            this.col员工性别.HeaderText = "col员工性别";
            this.col员工性别.Name = "col员工性别";
            // 
            // col员工年龄
            // 
            this.col员工年龄.DataPropertyName = "age";
            this.col员工年龄.HeaderText = "col员工年龄";
            this.col员工年龄.Name = "col员工年龄";
            // 
            // col账号
            // 
            this.col账号.DataPropertyName = "account";
            this.col账号.HeaderText = "col账号";
            this.col账号.Name = "col账号";
            // 
            // col密码
            // 
            this.col密码.DataPropertyName = "pass";
            this.col密码.HeaderText = "col密码";
            this.col密码.Name = "col密码";
            // 
            // col未分配
            // 
            this.col未分配.DataPropertyName = "wq";
            this.col未分配.HeaderText = "col未分配";
            this.col未分配.Name = "col未分配";
            // 
            // col已分配
            // 
            this.col已分配.DataPropertyName = "yq";
            this.col已分配.HeaderText = "col已分配";
            this.col已分配.Name = "col已分配";
            // 
            // 删除
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "删除";
            this.删除.DefaultCellStyle = dataGridViewCellStyle1;
            this.删除.HeaderText = "删除";
            this.删除.Name = "删除";
            this.删除.Width = 50;
            // 
            // 查看
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "查看";
            this.查看.DefaultCellStyle = dataGridViewCellStyle2;
            this.查看.HeaderText = "查看";
            this.查看.Name = "查看";
            this.查看.Width = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "员工姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "员工性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "员工年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "账号";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 25);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(445, 57);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(119, 25);
            this.txtSex.TabIndex = 11;
            this.txtSex.TextChanged += new System.EventHandler(this.txtsex_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(445, 123);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(119, 25);
            this.txtAge.TabIndex = 11;
            this.txtAge.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(716, 54);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(119, 25);
            this.txtAccountNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "密码";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(716, 123);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(119, 25);
            this.txtPass.TabIndex = 11;
            // 
            // btnPreservation
            // 
            this.btnPreservation.Location = new System.Drawing.Point(929, 114);
            this.btnPreservation.Name = "btnPreservation";
            this.btnPreservation.Size = new System.Drawing.Size(70, 38);
            this.btnPreservation.TabIndex = 12;
            this.btnPreservation.Text = "保存";
            this.btnPreservation.UseVisualStyleBackColor = true;
            this.btnPreservation.Click += new System.EventHandler(this.btnbc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(144, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(119, 25);
            this.txtId.TabIndex = 11;
            this.txtId.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // Employee_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 619);
            this.Controls.Add(this.btnPreservation);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee_information";
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.Employee_information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnPreservation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn 查看;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn col已分配;
        private System.Windows.Forms.DataGridViewTextBoxColumn col未分配;
        private System.Windows.Forms.DataGridViewTextBoxColumn col密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn col账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn col员工年龄;
        private System.Windows.Forms.DataGridViewTextBoxColumn col员工性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn col员工姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
    }
}