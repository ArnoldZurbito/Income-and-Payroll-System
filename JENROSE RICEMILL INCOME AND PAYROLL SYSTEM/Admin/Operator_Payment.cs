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
    public partial class Operator_Payment : Form
    {
        connection dbase = new connection();
        private string  emp;

        public Operator_Payment()
        {
            InitializeComponent();
        }
        private void Operator_Payment_Load(object sender, EventArgs e)
        {
            fill_employee_num_of_payment();
            fillEmp();
        }
        void fill_employee_num_of_payment()
        { 
            dbase.dbconnect();
            if (this.dbase.openconnection() == true)
            {
                string employee_num_of_payment_query = "SELECT * FROM employee_num_of_payment";
                MySqlDataAdapter da = new MySqlDataAdapter(employee_num_of_payment_query, dbase.objconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridOpPayment.DataSource = dt;
                dbase.closeconnection();
            }
        }

     private string employee
        {
            get { return emp; }
            set { emp = value; }
        }
            
        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
      
              lblID.Text = emp;
            try
            {
                dbase.dbconnect();
                if (this.dbase.openconnection() == true)
                {
                    string sql = "SELECT * FROM employee WHERE employee_name ='" + cmbEmp.Text + "'";
                    MySqlCommand command = new MySqlCommand(sql, dbase.objconn);
                    MySqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                      emp = dr["Employee_ID"].ToString();
                    }
                    calcSum();
                    dbase.closeconnection();
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void fillEmp()
        {
            try
            {
                dbase.dbconnect();
                if (this.dbase.openconnection() == true)
                {
                    string sql = "SELECT employee_name from employee";
                    MySqlCommand command = new MySqlCommand(sql, dbase.objconn);
                    MySqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        string bld = dr.GetString("employee_name");
                        cmbEmp.Items.Add(bld);
                    }
                    dbase.closeconnection();
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void calcSum()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Amount) FROM employee_num_of_payment where employee_id = '" + emp + "'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                txtSum.Text = command.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
