using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManegement.General;
using LibraryManegement.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryManegement
{
    public partial class LoginForm : Form
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        AdminWelcomeForm admin_form = new AdminWelcomeForm();
        UserWelcomeForm user_form = new UserWelcomeForm();
        StaffWelcomeForm staff_from = new StaffWelcomeForm();
       
        public LoginForm()
        {
            InitializeComponent();
        }

        /*------------------------------------Buttons----------------------------------------*/

        //login 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*           if (IsLoginValid())
                       {
                           try {
                               using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                               {
                                   using (SqlCommand cmd = new SqlCommand("LOGIN_VERIFTICATION", con))
                                   {
                                       cmd.CommandType = CommandType.StoredProcedure;

                                       cmd.Parameters.AddWithValue("@USERNAME", UserNameTxtBox.Text);
                                       cmd.Parameters.AddWithValue("@PASSWORD", Passwordtxtbox.Text);



                                       if (con.State != ConnectionState.Open)
                                           con.Open();


                                       DataTable dtUser = new DataTable();

                                       SqlDataReader sdr = cmd.ExecuteReader();

                                       if (sdr.HasRows) {

                                           dtUser.Load(sdr);
                                           //login successfuly 

                                           DataRow userData = dtUser.Rows[0];
                                           UsersInfo.Username = userData["USERNAME"].ToString();
                                           UsersInfo.Role_ID = Convert.ToInt32(userData["ROLE_ID"]);
                                           UsersInfo.User_Password = userData["PASSWORD"].ToString();
                                           UsersInfo.User_ID = userData["ID"].ToString();


                                           using (SqlConnection con1 = new SqlConnection(AppConnection.GetConnectionString()))
                                           {
                                               using (SqlCommand cmd1 = new SqlCommand("ACTIVATION_VERIFTICATION", con1))
                                               {
                                                   cmd1.CommandType = CommandType.StoredProcedure;

                                                   cmd1.Parameters.AddWithValue("@USERNAME", UserNameTxtBox.Text);

                                                   if (con1.State != ConnectionState.Open)
                                                       con1.Open();

                                                   SqlDataReader sdr1 = cmd1.ExecuteReader();

                                                   if (sdr1.HasRows)
                                                   {
                                                       this.Hide();
                                                       UserAccess();
                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("Your Account has been deactivated. Contact support for more.", "CONTACT SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   }
                                               }

                                           }

                                       }
                                       else
                                       {
                                           MessageBox.Show("User Name and Pass are Invalid", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                       }



                                       ClearTextBoxes(this.Controls);
                                   }
                               }
                           }
                           catch (Exception ex)
                           {
                               MessageBox.Show("An error accured while Login Verification \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

                           }
                       }*/


            var client = new MongoClient();
            var db = client.GetDatabase("LibraryManagement");
            var collection = db.GetCollection<LoginForm>("ADMIN");

            LoginForm userReg = new LoginForm();
            userReg.userName = UserNameTxtBox.Text.ToString();
            userReg.password = Passwordtxtbox.Text.ToString();
/*            userReg.role = cboRole.Text.ToString();
*/
/*            collection.InsertOneAsync(userReg);
*/        }
        //Exit
        private void picboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Forget pass
        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to contact Support if you forget your pass \n supp@library.com","Forgot passward", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        //SignUP
        private void lblSignup_Click(object sender, EventArgs e)
        {
            SignUpMemberForm signup = new SignUpMemberForm();
            signup.ShowDialog();
        }



        /*------------------------------------Behind the scene Functions----------------------------------------*/
        
        //User access
        private void UserAccess()
        {
            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
            try
            {
                switch (UsersInfo.Role_ID)
                {
                    case 1:
                        admin_form.lblState.Text = " Admin:";
                        admin_form.lblName.Text = UsersInfo.Username;
                        SuccForm.Size = admin_form.Size;
                        admin_form.Show();

                        break;
                    case 2:
                        staff_from.lblState.Text = " Staff:";
                        staff_from.lblName.Text = UsersInfo.Username;
                        SuccForm.Size = staff_from.Size;
                        staff_from.Show();
                        break;
                    case 4:
                        user_form.lblState.Text = " Member:";
                        user_form.lblName.Text = UsersInfo.Username;
                        SuccForm.Size = user_form.Size;
                        user_form.Show();
                        break;
                }
                SuccForm.lblTaskCompleted.Text = "Login Successfly";
                SuccForm.Opacity = .65;

                SuccForm.timer1.Interval = 1500;
                SuccForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while Loging in due to Roles issues. \n Please contact support at \n  \t supp@library.com \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // login not empty. 
        private bool IsLoginValid()
        {
            if (UserNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is required.", "Login Warning", MessageBoxButtons.OK);
                UserNameTxtBox.Focus();
                return false;
            }
            if (Passwordtxtbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Pass is required.", "Login Warning", MessageBoxButtons.OK);
                Passwordtxtbox.Focus();
                return false;
            }
            return true;
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



