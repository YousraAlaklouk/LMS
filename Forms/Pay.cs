using LibraryManegement.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManegement.Forms.Borrow
{
    public partial class Pay : Form
    {
        private int borrow_id;

        public Pay()
        {
            InitializeComponent();
        }

        //search username
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtboxUsername.Text != UsersInfo.Username)
            {   
                try
                {
  /*                  using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("SEARCH_PAYMENT_DATA", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("USERNAME", txtboxUsername.Text);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            
                            DataTable dtUser = new DataTable();

                            SqlDataReader sdr = cmd.ExecuteReader();

                            if (sdr.HasRows)
                            {
                                dtUser.Load(sdr);

                                DataRow userData = dtUser.Rows[0];

                                txtboxAmount.Text = userData["CHANGE"].ToString();
                                borrow_id = Convert.ToInt32(userData["BORROWING_ID"].ToString());
                            }
                            else
                            {
                                MessageBox.Show("You have no penalties to pay", "No recored Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
  }
                        }*/
                    }
                
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while Searching username penalty \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You are not allowed to pay your penalty by your self\n go to anther cashier to complete the penalty procedure \n","Access Denied",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //receive payment
        private void btnReceivePay_Click(object sender, EventArgs e)
        {
            int amount = (Convert.ToInt32(txtboxAmount.Text) - Convert.ToInt32(txtboxAmountReceived.Text));
            try
            {
     /*           using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE_PAYMENT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@BORROW_ID", borrow_id);
                        cmd.Parameters.AddWithValue("@AMOUNT_RECEIVED", amount);
                        //cmd.Parameters.AddWithValue("@CONDITION", "paid");

                        if (amount <= 0)
                        {

                            cmd.Parameters.AddWithValue("@CONDITION", "paid");
                            MessageBox.Show("return: " + amount + "  to the member", "return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (amount > 0)
                        {
                            cmd.Parameters.AddWithValue("@CONDITION", "unpaid");
                            MessageBox.Show("Penalty change: " + amount + "", "return", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                        if (con.State != ConnectionState.Open)
                            con.Open();


                        SqlDataReader dr = cmd.ExecuteReader();

                    }

                }

                AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                SuccForm.lblTaskCompleted.Text = "Payment received";
                SuccForm.ShowDialog();
                txtboxAmount.Clear();
                txtboxAmountReceived.Clear();
               

*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while receiveing payment. \n TRY Again! payment was not received \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }
}
}

