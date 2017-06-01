namespace JENROSE_RICEMILL_INCOME_AND_PAYROLL_SYSTEM
{
    partial class Paid_Customer
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
            this.dataGridpaid = new System.Windows.Forms.DataGridView();
            this.CUS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_SACKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_KILOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT_TO_PAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_OF_MILLING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_OF_PAYMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpaid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridpaid
            // 
            this.dataGridpaid.AllowUserToAddRows = false;
            this.dataGridpaid.AllowUserToDeleteRows = false;
            this.dataGridpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUS_ID,
            this.CUS_NAME,
            this.NUM_SACKS,
            this.NUM_KILOS,
            this.AMOUNT_TO_PAY,
            this.DATE_OF_MILLING,
            this.DATE_OF_PAYMENT});
            this.dataGridpaid.Location = new System.Drawing.Point(34, 46);
            this.dataGridpaid.Name = "dataGridpaid";
            this.dataGridpaid.ReadOnly = true;
            this.dataGridpaid.Size = new System.Drawing.Size(1034, 283);
            this.dataGridpaid.TabIndex = 0;
            this.dataGridpaid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridpaid_CellClick);
            // 
            // CUS_ID
            // 
            this.CUS_ID.DataPropertyName = "Cus_ID";
            this.CUS_ID.HeaderText = "CUSTOMER ID";
            this.CUS_ID.Name = "CUS_ID";
            this.CUS_ID.ReadOnly = true;
            this.CUS_ID.Visible = false;
            // 
            // CUS_NAME
            // 
            this.CUS_NAME.DataPropertyName = "Cus_Name";
            this.CUS_NAME.HeaderText = "CUSTOMER NAME";
            this.CUS_NAME.Name = "CUS_NAME";
            this.CUS_NAME.ReadOnly = true;
            this.CUS_NAME.Width = 200;
            // 
            // NUM_SACKS
            // 
            this.NUM_SACKS.DataPropertyName = "Num_Sacks";
            this.NUM_SACKS.HeaderText = "NUMBER OF SACKS";
            this.NUM_SACKS.Name = "NUM_SACKS";
            this.NUM_SACKS.ReadOnly = true;
            this.NUM_SACKS.Width = 150;
            // 
            // NUM_KILOS
            // 
            this.NUM_KILOS.DataPropertyName = "Num_Kilos";
            this.NUM_KILOS.HeaderText = "NUMBER OF KILOS";
            this.NUM_KILOS.Name = "NUM_KILOS";
            this.NUM_KILOS.ReadOnly = true;
            this.NUM_KILOS.Width = 130;
            // 
            // AMOUNT_TO_PAY
            // 
            this.AMOUNT_TO_PAY.DataPropertyName = "Amount_to_Pay";
            this.AMOUNT_TO_PAY.HeaderText = "AMOUT TO PAY";
            this.AMOUNT_TO_PAY.Name = "AMOUNT_TO_PAY";
            this.AMOUNT_TO_PAY.ReadOnly = true;
            this.AMOUNT_TO_PAY.Width = 150;
            // 
            // DATE_OF_MILLING
            // 
            this.DATE_OF_MILLING.DataPropertyName = "Date_of_Milling";
            this.DATE_OF_MILLING.HeaderText = "DATE OF MILLING";
            this.DATE_OF_MILLING.Name = "DATE_OF_MILLING";
            this.DATE_OF_MILLING.ReadOnly = true;
            this.DATE_OF_MILLING.Width = 180;
            // 
            // DATE_OF_PAYMENT
            // 
            this.DATE_OF_PAYMENT.DataPropertyName = "Date_of_Payment";
            this.DATE_OF_PAYMENT.HeaderText = "DATE OF PAYMENT";
            this.DATE_OF_PAYMENT.Name = "DATE_OF_PAYMENT";
            this.DATE_OF_PAYMENT.ReadOnly = true;
            this.DATE_OF_PAYMENT.Width = 180;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "&DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(447, 361);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 25);
            this.textBox2.TabIndex = 6;
            // 
            // Paid_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 416);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridpaid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paid_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAID CUSTOMER";
            this.Load += new System.EventHandler(this.Paid_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUS_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_SACKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_KILOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT_TO_PAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_OF_MILLING;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_OF_PAYMENT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}