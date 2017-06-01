using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace JENROSE_RICEMILL_INCOME_AND_PAYROLL_SYSTEM
{
    class connection
    {
        public MySqlConnection objconn;
        public string server = "";
        public string database = "";
        public string uid = "";
        public string password = "";

        public void dbconnect()
        {
            server = "localhost";
            database = "jenrose_ricemill_dbase";
            uid = "root";
            password = "";

            string connectionstring = "SERVER =" + server + ";DATABASE =" + database + ";UID =" + uid + ";PASSWORD =" + password;

            objconn = new MySqlConnection(connectionstring);
        }
        public bool openconnection()
        {
            try
            {
                objconn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot Connect to Server.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid Username or Password.");
                        break;
                }
                return false;
            }
        }
        public bool closeconnection()
        {
            try
            {
                objconn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
