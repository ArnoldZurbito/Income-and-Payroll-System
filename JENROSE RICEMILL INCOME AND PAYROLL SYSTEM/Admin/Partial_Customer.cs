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
    public partial class Partial_Customer : Form
    {
        connection dbase = new connection();
        private int IDCus;
        private int IDCusPay;

        public Partial_Customer()
        {
            InitializeComponent();
        }

        private void Partial_Customer_Load(object sender, EventArgs e)
        {
            fillPartial();
            listCus();
            listCusnumPay();
            IDloop();
        }
        void fillPartial()
        {
            dbase.dbconnect();
            if (this.dbase.openconnection() == true)
            {
                string partial_query = "SELECT * FROM partial_customer";

                MySqlDataAdapter da = new MySqlDataAdapter(partial_query, dbase.objconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridpartial.DataSource = dt;
                dbase.closeconnection();
            }
        }
        void listCus()
        {
            dbase.dbconnect();
            if (this.dbase.openconnection() == true)
            {
                string ID_query = "SELECT Cus_ID FROM partial_customer";

                MySqlCommand command = new MySqlCommand(ID_query, dbase.objconn);
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IDCus= dr.GetInt32("Cus_ID");
                    listEmp.Items.Add(IDCus);
                }
                dbase.closeconnection();
                dr.Close();
            }
        }
        void listCusnumPay()
        {
            dbase.dbconnect();
            if (this.dbase.openconnection() == true)
            {
                string ID_query = "SELECT Cus_ID FROM cus_num_of_partial_payment";

                MySqlCommand command = new MySqlCommand(ID_query, dbase.objconn);
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IDCusPay = dr.GetInt32("Cus_ID");
                    listEmpnumPay.Items.Add(IDCusPay);
                }
                dbase.closeconnection();
                dr.Close();
            }
        }

        public void IDloop()
        { 
        // para sa ID
        }
    }
}
