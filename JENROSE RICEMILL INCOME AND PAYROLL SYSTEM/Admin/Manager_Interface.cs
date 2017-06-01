using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JENROSE_RICEMILL_INCOME_AND_PAYROLL_SYSTEM
{
    public partial class Manager_Interface : Form
    {
        public Manager_Interface()
        {
            InitializeComponent();
        }
        private void fullPaymentMenu_Click(object sender, EventArgs e)
        {
            Paid_Customer paid = new Paid_Customer();
            paid.Show();
        }

        private void partialPaymentMenu_Click(object sender, EventArgs e)
        {
            Partial_Customer partial = new Partial_Customer();
            partial.Show();
        }
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Data id = new Add_Data();
            id.Show();
        }
        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operator_Attendance attend = new Operator_Attendance();
            attend.Show();
        }
        private void operatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Payroll_System expense = new Payroll_System();
            expense.Show();
        }

        private void ricemillExpencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ricemill_Expenses millexpenses = new Ricemill_Expenses();
            millexpenses.Show();
        }

        private void operatorCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operator_Credit opcredit = new Operator_Credit();
            opcredit.Show();
        }

        private void weeklyIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Montly_Income monthly = new Montly_Income();
            monthly.Show();
        }

        private void operatorsPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
