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
    public partial class Paid_Customer : Form
    {

        public Paid_Customer()
        {
            InitializeComponent();
        }
        connection dbase = new connection();
        DataTable dt = new DataTable();
        private void Paid_Customer_Load(object sender, EventArgs e)
        {
        
            fillData();

        }
        void fillData()
        {
            dbase.dbconnect();
            if (this.dbase.openconnection() == true)
            {

                string sql = "SELECT * FROM paid_customer";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, dbase.objconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridpaid.DataSource = dt;
                dbase.closeconnection();
            }
        }

        private void dataGridpaid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridpaid.Rows[e.RowIndex];
              textBox1.Text = rows.Cells[0].Value.ToString();
              textBox2.Text = rows.Cells[1].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteData();
        }
        private void deleteData()
        {
            try
            {
                dbase.dbconnect();

                if (this.dbase.openconnection() == true)
                {
                    dataGridpaid.Refresh();
                    string query = "delete  from paid_customer where Cus_Name = '" + textBox1.Text + "'";
                    DialogResult dialogresult = MessageBox.Show("Are You Sure You Want To Delete Customer?","Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogresult == DialogResult.OK)
                    {
                        MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                        del.ExecuteNonQuery();
                        MessageBox.Show("Record Has Been Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillData();
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
    

