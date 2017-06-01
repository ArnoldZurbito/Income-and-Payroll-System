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

    public partial class Montly_Income : Form
    {
        private string ex;

        connection dbase = new connection();
        
        public Montly_Income()
        {
            InitializeComponent();
        }

        private void Montly_Income_Load(object sender, EventArgs e)
        {
            fillRice_per_Kilo();

            filltxtFull();
            filltxtPartial();
            filltotalMonthly();
            filltotalExpenses();
            fillminus_expenses_to_monthly();

            openEmp1percent();
            multiplyEmp1percent_to_result();
            openEmp2percent();
            multiplyEmp2percent_to_result();
            openEmp3percent();
            multiplyEmp3percent_to_result();
            openEmp4percent();
            multiplyEmp4percent_to_result();

            Income_multiply_Kilos_result();

            OverallPayment_to_Emp1();
            //InsertOverallPaymentEmp1();
            OverallPayment_to_Emp2();
            OverallPayment_to_Emp3();
            OverallPayment_to_Emp4();




       
            //InsertOverallPaymentEmp2();
            //InsertOverallPaymentEmp3();
            //InsertOverallPaymentEmp4();
        }
        private void fillRice_per_Kilo()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string amount_query = "SELECT rice_per_kilo from admin_rights where ID = 1;";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(amount_query, conn);
                conn.Open();
                rice_per_kiloss.Text = command.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void filltxtFull()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string amount_query = "SELECT sum(Amount_to_Pay) FROM paid_customer";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(amount_query, conn);
                conn.Open();
                txtFull.Text = command.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void filltxtPartial()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string price_query = "SELECT sum(Amount_to_Pay) FROM partial_customer";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(price_query, conn);
                conn.Open();
                txtPartial.Text = command.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void filltotalMonthly()
        {
            int value1 = 0;
            int value2 = 0;
            int result = 0;
            if (int.TryParse(txtFull.Text, out value1) & int.TryParse(txtPartial.Text, out value2))
            {
                result = value1 + value2;
                txtMonthly.Text = result.ToString();
            }
        }
        private void filltotalExpenses()
        {
            try
            {
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string price_query = "SELECT sum(Amount) FROM ricemill_expenses";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(price_query, conn);
                conn.Open();
                txtRicemillExpenses.Text = command.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void fillminus_expenses_to_monthly()
        {
            int monthly = 0;
            int expenses = 0;
            int resulta = 0;

            if (int.TryParse(txtMonthly.Text, out monthly) & int.TryParse(txtRicemillExpenses.Text, out expenses))
            {
                resulta = monthly - expenses;
                txtresult.Text = resulta.ToString();
            }
        }
        private void openEmp1percent()
        {
            string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
            string price_query = "SELECT employee_per_kilo FROM employee where employee_id = 2001;";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(price_query, conn);
            conn.Open();
            Emp1percent.Text = command.ExecuteScalar().ToString();
            conn.Close();
        }
        private void multiplyEmp1percent_to_result()
        {

            int var1 = 0;
            double var2 = 0;
            double res1 = 0;
            if (int.TryParse(txtresult.Text, out var1) & double.TryParse(Emp1percent.Text, out var2))
            {
                res1 = var1 * var2;
                Emp1.Text = res1.ToString();
            }
        }
        private void openEmp2percent()
        {
            string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
            string price_query = "SELECT employee_per_kilo FROM employee where employee_id = 2002;";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(price_query, conn);
            conn.Open();
            Emp2percent.Text = command.ExecuteScalar().ToString();
            conn.Close();
        }
        private void multiplyEmp2percent_to_result()
        {
            int var11 = 0;
            double var22 = 0;
            double res11 = 0;
            if (int.TryParse(txtresult.Text, out var11) & double.TryParse(Emp2percent.Text, out var22))
            {
                res11 = var11 * var22;
                Emp2.Text = res11.ToString();
            }
        }
        private void openEmp3percent()
        {
            string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
            string price_query = "SELECT employee_per_kilo FROM employee where employee_id = 2003;";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(price_query, conn);
            conn.Open();
            Emp3percent.Text = command.ExecuteScalar().ToString();
            conn.Close();
        }
        private void multiplyEmp3percent_to_result()
        {
            int var111 = 0;
            double var222 = 0;
            double res111 = 0;
            if (int.TryParse(txtresult.Text, out var111) & double.TryParse(Emp3percent.Text, out var222))
            {
                res111 = var111 * var222;
                Emp3.Text = res111.ToString();
            }
        }
        private void openEmp4percent()
        {
            string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
            string price_query = "SELECT employee_per_kilo FROM employee where employee_id = 2004;";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(price_query, conn);
            conn.Open();
            Emp4percent.Text = command.ExecuteScalar().ToString();
            conn.Close();
        }

        private void multiplyEmp4percent_to_result()
        {
            double var1111 = 0;
            double var2222 = 0;
            double res1111 = 0;
            if (double.TryParse(txtresult.Text, out var1111) & double.TryParse(Emp4percent.Text, out var2222))
            {
                res1111 = var1111 * var2222;
                Emp4.Text = res1111.ToString();
            }
        }
        private void Income_multiply_Kilos_result()
        {
            double valueresult = 0;
            double valuerice_per_kiloss = 0;
            double valuedisplayresult = 0;
            if (double.TryParse(txtresult.Text, out valueresult) & double.TryParse(rice_per_kiloss.Text, out valuerice_per_kiloss))
            {
                valuedisplayresult = valueresult / valuerice_per_kiloss;
                Income_multiply_Kilos.Text = valuedisplayresult.ToString();
            }
        }

        private void OverallPayment_to_Emp1()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            if (double.TryParse(Income_multiply_Kilos.Text, out a) & double.TryParse(Emp1percent.Text, out b))
            {
                c = a * b;
                txtEmpp1.Text = c.ToString();

                    string sala_query1 = "Update Employee set total_salary = '" + Convert.ToDouble(c) +
                        "' where Employee_ID = 2001";
                    MySqlCommand addUser = new MySqlCommand(sala_query1, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(sala_query1, dbase.objconn);
                    del.ExecuteNonQuery();
                    dbase.closeconnection();

                }
            
        }
        private void InsertOverallPaymentEmp1()
        {
          //  ex = txtEmpp1.Text;
           

            try
            {
                if (dbase.openconnection() == true)
                {
                    string sala_query1 = "UPDATE Employee set total_salary = '" + Convert.ToDouble(txtEmpp1.Text) +
                         "' WHERE Employee_ID = 2001";
                    MySqlCommand addUser = new MySqlCommand(sala_query1, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(sala_query1, dbase.objconn);
                    del.ExecuteNonQuery();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void OverallPayment_to_Emp2()
        {
            double d = 0;
            double e = 0;
            double f = 0;
            if (double.TryParse(Income_multiply_Kilos.Text, out d) & double.TryParse(Emp2percent.Text, out e))
            {
                f = d * e;
                txtEmpp2.Text = f.ToString();
            }
        }
        private void OverallPayment_to_Emp3()
        {
            double g = 0;
            double h = 0;
            double i = 0;
            if (double.TryParse(Income_multiply_Kilos.Text, out g) & double.TryParse(Emp3percent.Text, out h))
            {
                i = g * h;
                txtEmpp3.Text = i.ToString();
            }
        }
        private void OverallPayment_to_Emp4()
        {
            double j = 0;
            double k = 0;
            double l = 0;
            if (double.TryParse(Income_multiply_Kilos.Text, out j) & double.TryParse(Emp4percent.Text, out k))
            {
                l = j * k;
                txtEmpp4.Text = l.ToString();
            }
        }

        private void nsertOverallPaymentEmp1()
        {
            try
            {
                if (dbase.openconnection() == true)
                {
                    string salang_query1 = "UPDATE employee SET total_salary ='" + txtEmpp1.Text +
                         "' WHERE Employee_ID = 2001";
                    MySqlCommand addUser = new MySqlCommand(salang_query1, dbase.objconn);
                    addUser.ExecuteNonQuery();
                    MySqlCommand del = new MySqlCommand(salang_query1, dbase.objconn);
                    del.ExecuteNonQuery();
                    dbase.closeconnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
            //private void InsertOverallPaymentEmp2()
            //{
            //    try
            //    {
            //        if (dbase.openconnection() == true)
            //        {
            //            string salang_query2 = "UPDATE employee SET total_salary ='" + txtEmpp2.Text +
            //                 "' WHERE Employee_ID = 2002";
            //            MySqlCommand addUser = new MySqlCommand(salang_query2, dbase.objconn);
            //            addUser.ExecuteNonQuery();
            //            MySqlCommand del = new MySqlCommand(salang_query2, dbase.objconn);
            //            del.ExecuteNonQuery();
            //            dbase.closeconnection();
            //        }
            //    }
            //    catch (MySqlException ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //private void InsertOverallPaymentEmp3()
            //{
            //    try
            //    {
            //        if (dbase.openconnection() == true)
            //        {
            //            string salang_query3 = "UPDATE employee SET total_salary ='" + txtEmpp3.Text +
            //                 "' WHERE Employee_ID = 2003";
            //            MySqlCommand addUser = new MySqlCommand(salang_query3, dbase.objconn);
            //            addUser.ExecuteNonQuery();
            //            dbase.closeconnection();
            //        }
            //    }
            //    catch (MySqlException ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //private void InsertOverallPaymentEmp4()
            //{
            //    try
            //    {
            //        if (dbase.openconnection() == true)
            //        {
            //            string salang_query4 = "UPDATE employee SET total_salary ='" + txtEmpp4.Text +
            //                 "' WHERE Employee_ID = 2004";
            //            MySqlCommand addUser = new MySqlCommand(salang_query4, dbase.objconn);
            //            addUser.ExecuteNonQuery();
            //              dbase.closeconnection();
            //        }
            //    }
            //    catch (MySqlException ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}

        }
    }


