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
    public partial class Operator_Attendance : Form
    {
        connection dbase = new connection();
        DateTime datetFirst = DateTime.Now;
        DateTime dateSecond = DateTime.Now.AddDays(-1);

        string format = " yyyy-MM-dd hh:mm:ss";

        public Operator_Attendance()
        {
            InitializeComponent();
        }

        private void Operator_Attendance_Load(object sender, EventArgs e)
        {

            label2.Text = datetFirst.ToString(format);
            fillOp();
        } 
        public void fillOp()
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
                        chkList.Items.Add(bld);
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

        private void chkList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chkList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chkList.SelectedIndex == 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    textBox1.Text = "1";
                  
                }
                else
                {
                    textBox1.Text = "0";
                }
            }
            else if (chkList.SelectedIndex == 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    textBox2.Text = "1";
                }
                else
                {
                    textBox2.Text = "0";
                }
            }
            else if (chkList.SelectedIndex == 2)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    textBox3.Text = "1";
                }
                else
                {
                    textBox3.Text = "0";
                }
            }
            else if (chkList.SelectedIndex == 3)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    textBox4.Text = "1";
 
                }
                else
                {
                    textBox4.Text = "0";
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkList.CheckedItems.Count != 0)
            {
                DialogResult dialogresult = MessageBox.Show("Are You Sure You Want To Save ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                  if  (dialogresult == DialogResult.OK)
                {
                    if (datetFirst < dateSecond)
                    {
                        MessageBox.Show(" Attendance Already Checked !");
                    }
                    else
                    {
                        update1();
                        update2();
                        update3();
                        update4();
                        MessageBox.Show("Record Has Been Successfully Updated !");
                    }
                }
            }
            else if (chkList.CheckedItems.Count ==0)
            {
            }
        }   
        public void update1()
        {
            try
            {
                string conString = "server=localhost; database =jenrose_ricemill_dbase;uid = root; password =;";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update employee set days_of_work = days_of_work   + '" + textBox1.Text + "' where employee_id = 2001";

                conn.Open();
                cmd.ExecuteNonQuery();

          
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void update2()
        {
            try
            {
                string conString = "server=localhost; database =jenrose_ricemill_dbase;uid = root; password =;";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update employee set days_of_work = days_of_work   + '" + textBox2.Text + "' where employee_id = 2002";

                conn.Open();
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Records Has BEEN successfully updated !");
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void update3()
        {
            try
            {
                string conString = "server=localhost; database =jenrose_ricemill_dbase;uid = root; password =;";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update employee set days_of_work = days_of_work   + '" + textBox3.Text + "' where employee_id = 2003";
                conn.Open();
                cmd.ExecuteNonQuery();

               // MessageBox.Show("Records Has BEEN successfully updated !");
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void update4()
        {
            try
            {
                string conString = "server=localhost; database =jenrose_ricemill_dbase;uid = root; password =;";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update employee set days_of_work = days_of_work   + '" + textBox4.Text + "' where employee_id = 2004";
                conn.Open();
                cmd.ExecuteNonQuery();

               // MessageBox.Show("Records Has BEEN successfully updated !");
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
