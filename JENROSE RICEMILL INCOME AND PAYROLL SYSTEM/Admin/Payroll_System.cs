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
    public partial class Payroll_System : Form
    {
        connection dbase = new connection();
        DateTime time = DateTime.Now;
        string format = " yyyy-MM-dd hh:mm:ss tt";

        public Payroll_System()
        {
            InitializeComponent();
        }

        private void Payroll_System_Load(object sender, EventArgs e)
        {
            fillPayroll();
            txtlock();
            locktxt();
            //get credit of an employee
            lbl1();
            updatecredit1();
            lbl2();
            updatecredit2();
            lbl3();
            updatecredit3();
            lbl4();
            updatecredit4();
          
            // expenses plus credit
            lbl11();
            updateDeduction1();
            lbl22();
            updateDeduction2();
            lbl33();
            updateDeduction3();
            lbl44();
            updateDeduction4();
          
            // total_deduction minus salary //
            lbl111();
            updateremainSalary1();
            lbl222();
            updateremainSalary2(); 
            lbl333();
            updateremainSalary3(); 
            lbl444();
            updateremainSalary4();
        }

        void fillPayroll()
        {
            dbase.dbconnect();
            if (this.dbase.openconnection() == true)
            {
                string partial_query = "SELECT * FROM employee";

                MySqlDataAdapter da = new MySqlDataAdapter(partial_query, dbase.objconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridPayroll.DataSource = dt;
                dbase.closeconnection();
            }
        }

        private void dataGridPayroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridPayroll.Rows[e.RowIndex];

                txtID.Text = row.Cells["Employee_ID"].Value.ToString();
                txtOperator.Text = row.Cells["Employee_Name"].Value.ToString();
                txtWork.Text = row.Cells["Days_of_Work"].Value.ToString();
                txtPer.Text = row.Cells["Employee_per_Kilo"].Value.ToString();
                txtExpenses.Text = row.Cells["Expenses"].Value.ToString();
                txtCredit.Text = row.Cells["Credit"].Value.ToString();
                txtDeduction.Text = row.Cells["Total_Deduction"].Value.ToString();
                txtSalary.Text = row.Cells["Total_Salary"].Value.ToString();
                txtRemaining.Text = row.Cells["Remaining_Salary"].Value.ToString();
                txtPayment.Text = row.Cells["Payment"].Value.ToString();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int var1, var2;
            int.TryParse(txtPaid.Text, out var1);
            int.TryParse(txtRemaining.Text, out var2);
            if (txtPaid.Text == "")
            {
                MessageBox.Show("Select an Employee you Want to Modify", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (var1 > var2)
            {
                MessageBox.Show("Higher Input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Are You Sure You Want Save?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.OK)
                {
                    txtunlock();
                    int val1, val2;
                    int.TryParse(txtRemaining.Text, out val1);
                    int.TryParse(txtPaid.Text, out val2);
                    txtRemain.Text = (val1 - val2).ToString();

                    int va1, va2;
                    int.TryParse(txtPaid.Text, out va1);
                    int.TryParse(txtPayment.Text, out va2);                    
                    txtTotalPaymentAdd.Text = (va1 + va2).ToString();

                    updateRemainBal();
                
                }
            }
        }
        private void lbl1()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Amount) FROM employee_credit where employee_id = 2001";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl2001.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updatecredit1()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Credit ='" + lbl2001.Text +
                         "' WHERE Employee_ID = 2001";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                    cleartxt();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl2()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Amount) FROM employee_credit where Employee_Id = 2002";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl2002.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updatecredit2()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Credit ='" + lbl2002.Text +
                         "' WHERE Employee_ID = 2002";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                    cleartxt();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl3()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Amount) FROM employee_credit where employee_id = 2003";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl2003.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updatecredit3()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Credit ='" + lbl2003.Text +
                         "' WHERE Employee_ID = 2003";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                     cleartxt();
                    dbase.closeconnection();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl4()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Amount) FROM employee_credit where employee_id = 2004";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl2004.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updatecredit4()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Credit ='" + lbl2004.Text +
                         "' WHERE Employee_ID = 2004";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                    cleartxt();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl11()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Expenses + Credit) FROM employee where employee_id = 2001";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl1002.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateDeduction1()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Total_Deduction ='" + lbl1002.Text +
                         "' WHERE Employee_ID = 2001";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                   fillPayroll();
                  cleartxt();
                    dbase.closeconnection();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl22()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Expenses + Credit) FROM employee where employee_id = 2002";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl3002.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateDeduction2()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Total_Deduction ='" + lbl3002.Text +
                         "' WHERE Employee_ID = 2002";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                   fillPayroll();
                   cleartxt();
                    dbase.closeconnection();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl33()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Expenses + Credit) FROM employee where employee_id = 2003";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl4002.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateDeduction3()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Total_Deduction ='" + lbl4002.Text +
                         "' WHERE Employee_ID = 2003";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                    cleartxt();
                    dbase.closeconnection();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl44()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(Expenses + Credit) FROM employee where employee_id = 2004";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl5002.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateDeduction4()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Total_Deduction ='" + lbl5002.Text +
                         "' WHERE Employee_ID = 2004";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                     fillPayroll();
                    cleartxt();
                    dbase.closeconnection();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl111()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(total_salary - total_deduction) FROM employee where employee_id = 2001";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl100.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateremainSalary1()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET remaining_salary ='" + lbl100.Text +
                         "' WHERE Employee_ID = 2001";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                    cleartxt();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl222()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(total_salary - total_deduction) FROM employee where employee_id = 2002";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl200.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateremainSalary2()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET remaining_salary ='" + lbl200.Text +
                         "' WHERE Employee_ID = 2002";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                    cleartxt();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl333()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(total_salary - total_deduction) FROM employee where employee_id = 2003";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl300.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateremainSalary3()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET remaining_salary ='" + lbl300.Text +
                         "' WHERE Employee_ID = 2003";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                    cleartxt();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbl444()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string credit_query = "SELECT sum(total_salary - total_deduction) FROM employee where employee_id = 2004";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(credit_query, conn);
                conn.Open();
                lbl400.Text = command.ExecuteScalar().ToString();
                fillPayroll();
                cleartxt();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateremainSalary4()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET remaining_salary ='" + lbl400.Text +
                         "' WHERE Employee_ID = 2004";
                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                    del.ExecuteNonQuery();
                    fillPayroll();
                    cleartxt();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void locktxt()
        {
            txtOperator.ReadOnly = true;
            txtWork.ReadOnly = true;
            txtPer.ReadOnly = true;
            txtExpenses.ReadOnly = true;
            txtCredit.ReadOnly = true;
            txtDeduction.ReadOnly = true;
            txtSalary.ReadOnly = true;
            txtRemaining.ReadOnly = true;
            txtRemain.ReadOnly = true;
        }
        void txtunlock()
        {
            lblBal.Visible = true;
            txtRemain.Visible = true;
        }
        void txtlock()
        {
            lblBal.Visible = false;
            txtRemain.Visible = false;
        }
        void cleartxt()
        { 
            txtOperator.Text = "";
            txtWork.Text = "";
            txtPer.Text = "";
            txtExpenses.Text  = "";
            txtCredit.Text = "";
            txtDeduction.Text = "";
            txtSalary.Text  = "";
            txtRemaining.Text = "";
            txtPaid.Text = "";
            txtlock();
        }
        private void updateRemainBal()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string query = "UPDATE employee SET Remaining_Salary ='" + Convert.ToInt32(txtRemain.Text) + "' ,  payment   = '" + Convert.ToInt32(txtTotalPaymentAdd.Text) + "' WHERE Employee_ID ='" + txtID.Text + "'";

                    MySqlCommand addUser = new MySqlCommand(query, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    

                        MySqlCommand del = new MySqlCommand(query, dbase.objconn);
                        del.ExecuteNonQuery();
                        MessageBox.Show("Record has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insert_employee_num_of_payment();
                        fillPayroll();
                        cleartxt();
                        dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insert_employee_num_of_payment()
        {
            dbase.dbconnect();

            if (this.dbase.openconnection() == true)
            {
                string insert_query = "INSERT INTO employee_num_of_payment (Employee_ID,Amount,Date,Employee_Name) VALUES " +
                "( '" + txtID.Text + "','" + Convert.ToInt32(txtPaid.Text) + "','" + time.ToString(format) + "','"
                + Convert.ToString(txtOperator.Text) + "')";
                MySqlCommand addemp_pay = new MySqlCommand(insert_query, dbase.objconn);
                addemp_pay.ExecuteNonQuery();
            }
            else
            {
            }

            dbase.closeconnection();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleartxt();
        }

    }
}
