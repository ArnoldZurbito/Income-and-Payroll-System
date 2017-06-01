namespace JENROSE_RICEMILL_INCOME_AND_PAYROLL_SYSTEM
{
    partial class Operator_Payment
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
            this.dataGridOpPayment = new System.Windows.Forms.DataGridView();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOpPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOpPayment
            // 
            this.dataGridOpPayment.AllowUserToAddRows = false;
            this.dataGridOpPayment.AllowUserToDeleteRows = false;
            this.dataGridOpPayment.ColumnHeadersHeight = 40;
            this.dataGridOpPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_ID,
            this.Employee_Name,
            this.Amount,
            this.Date});
            this.dataGridOpPayment.Location = new System.Drawing.Point(28, 27);
            this.dataGridOpPayment.Name = "dataGridOpPayment";
            this.dataGridOpPayment.ReadOnly = true;
            this.dataGridOpPayment.Size = new System.Drawing.Size(673, 291);
            this.dataGridOpPayment.TabIndex = 0;
            // 
            // Employee_ID
            // 
            this.Employee_ID.DataPropertyName = "Employee_ID";
            this.Employee_ID.HeaderText = "ID";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            this.Employee_ID.Visible = false;
            // 
            // Employee_Name
            // 
            this.Employee_Name.DataPropertyName = "Employee_Name";
            this.Employee_Name.HeaderText = "NAME OF AN EMPLOYEE";
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            this.Employee_Name.Width = 240;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "AMOUNT";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 170;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 220;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(366, 381);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(176, 26);
            this.txtSum.TabIndex = 5;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(200, 387);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(143, 20);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "TOTAL  PAYMENT";
            // 
            // cmbEmp
            // 
            this.cmbEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(366, 347);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(177, 28);
            this.cmbEmp.TabIndex = 8;
            this.cmbEmp.SelectedIndexChanged += new System.EventHandler(this.cmbEmp_SelectedIndexChanged);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(178, 350);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(165, 20);
            this.lblEmployee.TabIndex = 9;
            this.lblEmployee.Text = "Name of an Employee";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(363, 498);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "label1";
            // 
            // Operator_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 448);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.dataGridOpPayment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Operator_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operator_Payment";
            this.Load += new System.EventHandler(this.Operator_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOpPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOpPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblID;
    }
}