namespace ItqanDbConnection
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.employeeDgv = new System.Windows.Forms.DataGridView();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.salaryTb = new System.Windows.Forms.TextBox();
            this.lnameTb = new System.Windows.Forms.TextBox();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDgv
            // 
            this.employeeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fName,
            this.lName,
            this.salary,
            this.phone,
            this.edit,
            this.delete});
            this.employeeDgv.Location = new System.Drawing.Point(12, 12);
            this.employeeDgv.Name = "employeeDgv";
            this.employeeDgv.RowHeadersWidth = 51;
            this.employeeDgv.RowTemplate.Height = 24;
            this.employeeDgv.Size = new System.Drawing.Size(1050, 365);
            this.employeeDgv.TabIndex = 0;
            this.employeeDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDgv_CellContentClick);
            // 
            // fnameTb
            // 
            this.fnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTb.Location = new System.Drawing.Point(12, 429);
            this.fnameTb.Multiline = true;
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(188, 46);
            this.fnameTb.TabIndex = 1;
            // 
            // salaryTb
            // 
            this.salaryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTb.Location = new System.Drawing.Point(426, 429);
            this.salaryTb.Multiline = true;
            this.salaryTb.Name = "salaryTb";
            this.salaryTb.Size = new System.Drawing.Size(189, 46);
            this.salaryTb.TabIndex = 2;
            // 
            // lnameTb
            // 
            this.lnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTb.Location = new System.Drawing.Point(206, 429);
            this.lnameTb.Multiline = true;
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(214, 46);
            this.lnameTb.TabIndex = 3;
            // 
            // phoneTb
            // 
            this.phoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTb.Location = new System.Drawing.Point(621, 429);
            this.phoneTb.Multiline = true;
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(189, 46);
            this.phoneTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "first name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "phone";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(93, 512);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(119, 59);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(236, 512);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(119, 59);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // fName
            // 
            this.fName.HeaderText = "first name";
            this.fName.MinimumWidth = 6;
            this.fName.Name = "fName";
            this.fName.Width = 125;
            // 
            // lName
            // 
            this.lName.HeaderText = "last name";
            this.lName.MinimumWidth = 6;
            this.lName.Name = "lName";
            this.lName.Width = 125;
            // 
            // salary
            // 
            this.salary.HeaderText = "salary";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Width = 125;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 482);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 16);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "lblId";
            this.lblId.Visible = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 642);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.lnameTb);
            this.Controls.Add(this.salaryTb);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.employeeDgv);
            this.Name = "Employee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDgv;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.TextBox phoneTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salaryTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label lblId;
    }
}

