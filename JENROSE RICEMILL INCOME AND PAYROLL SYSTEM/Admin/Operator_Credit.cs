using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JENROSE_RICEMILL_INCOME_AND_PAYROLL_SYSTEM
{
    public partial class Operator_Credit : Form
    {
        connection dbase = new connection();

        public Operator_Credit()
        {
            InitializeComponent();
        }

        private void Operator_Credit_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void fillcombo()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "select employee_name from employee";

                conn.Open();
                command.ExecuteNonQuery();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string emp_name = reader.GetString("employee_name");
                    cmbCredit.Items.Add(emp_name);
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


    }
}
