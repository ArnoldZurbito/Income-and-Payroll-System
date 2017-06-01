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
    public partial class Display_Data : Form
    {
        private string cn;
        private string sacks;
        private string kilos;
        private string date_mill;

        public double pay = 0;

        connection db = new connection();
        DateTime time = DateTime.Now;

        string format = " yyyy-MM-dd hh:mm:ss tt";

        public string Pass_Cus
        {
            get { return cn; }
            set { cn = value; }
        }
        public string Pass_Sacks
        {
            get { return sacks; }
            set { sacks = value; }
        }
        public string Pass_Kilos
        {
            get { return kilos; }
            set { kilos = value; }
        }
        public string Pass_DateMill
        {
            get { return date_mill; }
            set { date_mill = value; }
        }
        public Display_Data()
        {
            InitializeComponent();
        }

        private void Display_Data_Load(object sender, EventArgs e)
        {
  
            string zero = "0";
            lblCus.Text = cn;
            lblSacks.Text = sacks;
            lblKilos.Text = kilos;
       
                string conString = "host = localhost; database= jenrose_ricemill_dbase; username=root; password=;";
                string price_query = "select rice_per_kilo from admin_rights where ID = 1";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(price_query, conn);
                conn.Open();
                lblPerKilo.Text  = command.ExecuteScalar().ToString();
                conn.Close();

              pay = Convert.ToInt32(kilos) * Convert.ToDouble(lblPerKilo.Text);
              lblPay.Text =  String.Concat("\u20B1",pay,zero).ToString();
              lblPayment.Text = String.Concat(pay).ToString();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Save?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    db.dbconnect();
                    if (this.db.openconnection() == true)
                    {

                        string yes_query = "INSERT INTO paid_customer (Cus_Id,Cus_Name,Num_Sacks,Num_Kilos,Amount_to_Pay,Date_of_Milling,Date_of_Payment) VALUES " +
                        "(NULL,'" + lblCus.Text + "','" + lblSacks.Text + "','" + lblKilos.Text + "','"
                        + pay + "','" + Pass_DateMill + "','" + time.ToString(format) + "')";

                        MySqlCommand addPaid = new MySqlCommand(yes_query, db.objconn);
                        addPaid.ExecuteNonQuery();
                        DialogResult dialog = MessageBox.Show("New Record has been Added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog == DialogResult.OK)
                        {
                            Add_Data add = new Add_Data();
                            add.Show();
                            this.Hide();
                        }
                    }
                    else
                    {

                    }
                    db.closeconnection();
                }
            }
            catch (MySqlException ex)
            { MessageBox.Show(ex.Message);
            }

            }
    
        private void btnNo_Click(object sender, EventArgs e)
        {
            Terms_and_Condition terms = new Terms_and_Condition();
            terms.Pass_Cus_Terms = lblCus.Text;
            terms.Pass_Sacks_Terms = lblSacks.Text;
            terms.Pass_Kilos_Terms = lblKilos.Text;
            terms.Pass_Amount_Terms = Convert.ToString(pay);
            terms.Pass_DateMill_Terms = time.ToString(format);
            terms.Pass_Payment_Terms = lblPayment.Text;
            terms.Show();
            this.Hide();
        }

        }
    }


