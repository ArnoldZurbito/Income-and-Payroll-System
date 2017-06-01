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
    public partial class User_Account : Form
    {


       connection  opencon = new connection();

        public User_Account()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Encypt_User_Pass enc = new Encypt_User_Pass();
            encryptusername.Text = enc.GetEncrypt(txtUsername.Text);
            encryptpass.Text = enc.GetEncrypt(txtPassword.Text);

            log_in();
        }

        public void log_in()
        {
          try
             {
                opencon.dbconnect();
                {
                    if (this.opencon.openconnection() == true)
                    {
                        string find_user = "SELECT * FROM USER_ACCOUNT WHERE USERNAME =  '" + encryptusername.Text + "' AND PASSWORD ='" + encryptpass.Text + "'LIMIT 1";

                        MySqlDataAdapter objda = new MySqlDataAdapter(find_user, opencon.objconn);
                        DataTable objdt = new DataTable();
                        objda.Fill(objdt);

                        if (txtUsername.Text == "")
                        {
                            lblPrompt.Text = "Please Enter Username";
                            txtUsername.Focus();
                        }
                        else if (txtPassword.Text == "")
                        {
                            lblPrompt.Text = "Please Enter Password";
                            txtPassword.Focus();
                        }
                        else if (objdt.Rows.Count == 0)
                        {
                            lblPrompt.Text = "Account does'nt exist";
                            opencon.closeconnection();
                        }
                        else if (txtUsername.Text == "operator1")
                        {
                            Add_Data operate = new Add_Data();

                            operate.Show();
                            this.Hide();
                        }
                        else if (txtUsername.Text == "operator2")
                        {
                            Add_Data operate = new Add_Data();
                            operate.Show();
                            this.Hide();
                        }
                        else if (txtUsername.Text == "operator3")
                        {
                            Add_Data operate = new Add_Data();
                            operate.Show();
                            this.Hide();
                        }
                        else if (txtUsername.Text == "watcher")
                        {
                            Add_Data operate = new Add_Data();
                            operate.Show();
                            this.Hide();
                        }
                        else
                        {
                            Manager_Interface admin = new Manager_Interface();

                            //admin.fileToolStripMenuItem.Visible = false;

                            admin.Show();
                            this.Hide();
                        }
                      //  lblPrompt.Text = "Successfully Logout";
                        opencon.closeconnection();
                    }
                    opencon.closeconnection();
                }
             }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
      }
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {               
                    txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               cmdLogin.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void User_Account_Load(object sender, EventArgs e)
        {

        }
    }
  }

