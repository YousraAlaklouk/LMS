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
    public partial class SignUpMemberForm : Form
    {
        public int counter = 0;
        public int time = 0;
        public string text;

        public int ADD_TO_USER;

        public SignUpMemberForm()
        {
            InitializeComponent();
           
        }

        //moving text
        private void AddMemberForm_Load(object sender, EventArgs e)
        {

            text = lblWelcome.Text;
            time = text.Length;
            lblWelcome.Text = "";
            timer1.Start();

        }

        //timer the moving text
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWelcome.Text = text.Substring(0, counter);
            ++counter;
            if (counter > time)
            {
                timer1.Stop();
            }

        }
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // add member as a member
        private void btnRegister_Click(object sender, EventArgs e)
        {
   /*         if (chckboxPrivecy.Checked)
            {
                if (IsValidToAdd() <= 0)
                {
                    try
                    {
   *//*                     //adding to user
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("ADD_USER", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                
                                cmd.Parameters.AddWithValue("@USERNAME", txtboxUsername.Text);
                                cmd.Parameters.AddWithValue("@PASSWORD", txtboxPassword.Text);
                                cmd.Parameters.AddWithValue("@ROLE_ID", 4);
                                cmd.Parameters.AddWithValue("@ACTIVATION", true);
                                cmd.Parameters.AddWithValue("@CREATED_BY","New Member");
                                cmd.Parameters.AddWithValue("@BORROW_LIMIT", UsersInfo.Book_limit);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                ADD_TO_USER = (int)cmd.ExecuteScalar();

                            }
                        }



                        //Adding to an admin
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("ADD_MEMBER", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@NAME", txtboxName.Text);
                                cmd.Parameters.AddWithValue("@USER_ID", ADD_TO_USER);
                                cmd.Parameters.AddWithValue("@EMAIL", txtboxEmail.Text);
                                cmd.Parameters.AddWithValue("@GENDER", cmbGender.SelectedItem);
                                cmd.Parameters.AddWithValue("@ADDRESS", txtboxAddress.Text);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();
                                AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                SuccForm.lblTaskCompleted.Text = "Welcome To the Digital Library";
                                SuccForm.ShowDialog();
                                ClearTextBoxes(this.Controls);
                                this.Close();
                            }
                        }*//*
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Adding an Admin  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        txtboxName.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("You can't sign up without accpeting the Privecy Policy", "Registeration Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }*/
        }
        //Is data valid 
 /*       private int IsValidToAdd()
        {
            if ( txtboxUsername.Text == string.Empty || txtboxPassword.Text == string.Empty)
            {
                MessageBox.Show(" User name and Password can't be empty please try again!.","Signup Failed!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return 1;
            }
            else
            {
                try
                {*/
      /*              using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM USERS  WHERE ([USERNAME] = @USERNAME)", con))
                        {
                            check_User_Name.Parameters.AddWithValue("@USERNAME", txtboxUsername.Text);
                            if (con.State != ConnectionState.Open)
                                con.Open();
                            int UserExist = (int)check_User_Name.ExecuteScalar(); // if already exists returns 1 

                            if (UserExist > 0)
                            {
                                MessageBox.Show("UserName Is taken,  Already Exists. try something else", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
                                txtboxUsername.Focus();
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }

                        }
                    }*/
    /*            }
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while Checking usersName data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 2;
                }
            }
        }*/
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
