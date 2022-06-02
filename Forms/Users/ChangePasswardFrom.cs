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

namespace LibraryManegement.Forms
{
    public partial class ChangePasswardFrom : Form
    {
        public ChangePasswardFrom()
        {
            InitializeComponent();
        }
        /*------------------------------------Buttons----------------------------------------*/

        //close 
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Change pass
        private void btnbnfChangePass_Click(object sender, EventArgs e)
        {
 /*           if (IsPasswordValid())
            {
                if (PassVerify())
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("CHANGE_PASSWORD", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;


                                cmd.Parameters.AddWithValue("@USERNAME", UsersInfo.Username);
                                cmd.Parameters.AddWithValue("@NEWPASSWORD", btnftxtboxNewPass.Text.Trim());


                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                SqlDataReader dr = cmd.ExecuteReader();
                                UsersInfo.User_Password = btnftxtboxNewPass.Text.Trim();

                            }

                        }
                        AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                        SuccForm.lblTaskCompleted.Text = "Changed Successfully";
                        SuccForm.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Changing the Password an Erroe catched:"+ex.Message,"Catchec an Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ClearTextBoxes(this.Controls);
                    }
                }else
                {
                MessageBox.Show("Check your password it is not correct", "Changing aFailed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } */

        }
        /*------------------------------------Behind the Scene functions----------------------------------------*/
        // Is Old pass Same as the new?
        private bool PassVerify()
        {
            bool IsPassCorrect = false;

            if (btnftxtboxCurrentPass.Text == UsersInfo.User_Password)
            { 
                return true;
               
            }
            return IsPassCorrect;
        }

        //Is Password valid
        private bool IsPasswordValid()
        {
            if (btnftxtboxCurrentPass.Text.Trim() == string.Empty || btnftxtboxNewPass.Text.Trim() == string.Empty || btnftxtboxConfirmPass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password can't be empty.", "Login Warning", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                if (btnftxtboxNewPass.Text.Trim() != btnftxtboxConfirmPass.Text.Trim())
                {
                    MessageBox.Show("Please confirm Your Password", "Confiermation Error", MessageBoxButtons.OK);
                    btnftxtboxConfirmPass.Focus();
                    return false;
                }
                return true;
            }

        }

        //clear text boxes
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
       
    }
}
