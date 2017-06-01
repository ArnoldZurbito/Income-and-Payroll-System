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
    public partial class Terms_and_Condition : Form
    {
        private string cus_terms;
        private string sacks_terms;
        private string kilos_terms;
        private string amount_terms;
        private string date_mill_terms;
        private string payment;


        connection db = new connection();
        DateTime time = DateTime.Now;

        string format = " yyyy-MM-dd hh:mm:ss tt";

        public Terms_and_Condition()
        {
            InitializeComponent();
        }
        public string Pass_Cus_Terms
        {
            get { return cus_terms; }
            set { cus_terms = value; }
        }
        public string Pass_Sacks_Terms
        {
            get { return sacks_terms; }
            set { sacks_terms = value; }
        }
        public string Pass_Kilos_Terms
        {
            get { return kilos_terms; }
            set { kilos_terms = value; }
        }
        public string Pass_Amount_Terms
        {
            get { return amount_terms; }
            set { amount_terms = value; }
        }
        public string Pass_DateMill_Terms
        {
            get { return date_mill_terms; }
            set { date_mill_terms = value; }
        }
        public string Pass_Payment_Terms
        {
            get { return payment; }
            set { payment = value; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
          Add_Data display = new Add_Data();
          display.Show();
          this.Hide();
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            double credit = Convert.ToDouble(payment) - Convert.ToDouble(txtPartial.Text);

            if (Convert.ToDouble(txtPartial.Text) > Convert.ToDouble(payment))
            {
                MessageBox.Show("Your Partial Higher Than Your Payment", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chkTerms.Checked == false)
            {
                MessageBox.Show("Please read our Terms and Agreement", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.dbconnect();
                if (this.db.openconnection() == true)
                {
                    string no_query = "INSERT INTO partial_customer (Cus_Id,Cus_Name,Num_of_Sacks,Num_of_Kilos,Amount_to_Pay,Date_of_Milling,Num_to_Pay,Credit) VALUES " +
                    "(NULL,'" + cus_terms + "','" + sacks_terms + "','" + kilos_terms + "','"
                    + payment + "','" + time.ToString(format) + "',1,'" + credit + "'); insert into cus_num_of_partial_payment (Partial_ID,Amount,Date,Cus_ID) values " +
                    "(NULL,'" + txtPartial.Text + "','" + time.ToString(format) + "',LAST_INSERT_ID());";
                  
                    
                    // .CommandText = "Insert Into raw_material_table(RAW_ID,RAW_NAME,RAW_QUANTITY,UNIT,RAW_EXPIRATION_DATE)  values (NULL,'" & ProdName & _
                        //                                          "','" & ProdCQuant & _
                          //                                        "','" & cmbUnit & _
                         //                                         "','" & ProdExpire & _
                           //                                       "') ; Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID) values((SELECT Product_ID FROM producttable WHERE Product_Name ='" & ProdFrom & "'),'" & ProdConsume & "',LAST_INSERT_ID());"

                    //'" + txtPartial.Text + "',
                    MySqlCommand addpartial = new MySqlCommand(no_query, db.objconn);
                    addpartial.ExecuteNonQuery();
                    MessageBox.Show("New Record has been Added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                }
                db.closeconnection();
            }
        }

        private void txtPartial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Terms_and_Condition_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

         
        }

    }
}
