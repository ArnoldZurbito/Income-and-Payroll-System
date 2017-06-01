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
    public partial class Ricemill_Expenses : Form
    {
        connection dbase = new connection();
        DateTime time = DateTime.Now;
        string format = " yyyy-MM-dd hh:mm:ss tt ";

        public Ricemill_Expenses()
        {
            InitializeComponent();
        }
        private void Ricemill_Expenses_Load(object sender, EventArgs e)
        {
            fillExpense();
            totalExpenses();
        }
        private void fillExpense()
        {
            dbase.dbconnect();
            if (this.dbase.openconnection() == true)
            {
                string partial_query = "SELECT * FROM ricemill_expenses";

                MySqlDataAdapter da = new MySqlDataAdapter(partial_query, dbase.objconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridExpenses.DataSource = dt;
                dbase.closeconnection();
            }
        }
        private void dataGridExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridExpenses.Rows[e.RowIndex];
                txtIDs.Text = rows.Cells["Expenses_ID"].Value.ToString();
                txtDelete.Text = rows.Cells["Expenses_Names"].Value.ToString();
            }
        }
        private void totalExpenses()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string price_query = "SELECT sum(Amount) FROM ricemill_expenses";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(price_query, conn);
                conn.Open();
                txtTotal.Text = command.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addExpense();
        }

        private void addExpense()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Save?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    dbase.dbconnect();
                    if (this.dbase.openconnection() == true)
                    {

                        string yes_query = "INSERT INTO ricemill_expenses (Expenses_Id,Expenses_Names,Amount,Date) VALUES " +
                        "(NULL,'" + txtExpense.Text + "','" + txtAmount.Text + "','" + time.ToString(format) + "')";

                        MySqlCommand addPaid = new MySqlCommand(yes_query, dbase.objconn);
                        addPaid.ExecuteNonQuery();
                        DialogResult dialog = MessageBox.Show("New Record has been Added.", "Added",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillExpense();
                        totalExpenses();
                        txtAmount.Text = "";
                        txtExpense.Text ="";
                    }
                    else
                    {
                        
                    }
                    dbase.closeconnection();
                }
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

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            Deletedrow();
        }

        private void Deletedrow()
        {
            try
            {
                dbase.dbconnect();
                if (this.dbase.openconnection() == true)
                {
                    dataGridExpenses.Refresh();
                    string query = "delete  from ricemill_expenses where Expenses_Names = '" + txtDelete.Text + "'";
                    DialogResult dialogresult = MessageBox.Show("Are You Sure You Want To Delete Selected Expenses ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogresult == DialogResult.OK)
                    {
                        MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                        del.ExecuteNonQuery();
                        MessageBox.Show("Record Has Been Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillExpense();
                        dbase.closeconnection();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
