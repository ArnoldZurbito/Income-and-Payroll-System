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
    public partial class Add_Data : Form
    {
        DateTime date = DateTime.Now;
        string format = " yyyy-MM-dd hh:mm:ss";
        public Add_Data()
        {
            InitializeComponent();
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text == "")
            {
                MessageBox.Show("Enter Customer Name", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusName.BackColor = Color.Yellow;
                txtCusName.Focus();
            }
            else if (txtSacks.Text == "")
            {
                MessageBox.Show("Enter How Many Number of Sacks", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSacks.BackColor = Color.Yellow;
                txtSacks.Focus();
            }
            else if (txtKilos.Text == "")
            {
                MessageBox.Show("Enter How Many Kilos", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKilos.BackColor = Color.Yellow;
                txtKilos.Focus();
            }
            else
            {
              lblDateMill.Text = date.ToString(format);

              Display_Data display = new Display_Data();
              display.Pass_Cus = txtCusName.Text;
              display.Pass_Sacks = txtSacks.Text;
              display.Pass_Kilos = txtKilos.Text;
              display.Pass_DateMill = lblDateMill.Text;
              display.Show();
              this.Hide();
            }
        }

        private void txtSacks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Add_Data_Load(object sender, EventArgs e)
        {

        }



    }
}
