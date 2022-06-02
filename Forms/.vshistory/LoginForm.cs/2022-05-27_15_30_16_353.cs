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
using LibraryManegement;
using MongoDB.Driver;
using MongoDB.Bson;


namespace LibraryManegement
{
    public partial class LoginForm : Form
    {

        AdminWelcomeForm admin_form = new AdminWelcomeForm();
        UserWelcomeForm user_form = new UserWelcomeForm();
        StaffWelcomeForm staff_from = new StaffWelcomeForm();
        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<User1> UserCollection;
        public LoginForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            UserCollection = mongodb.GetCollection<User1>("USERS");

        }

        /*------------------------------------Buttons----------------------------------------*/

        //login 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsLoginValid())
            {
                try
                {
                    var user = UserCollection.Find(x => x.USERNAME == UserNameTxtBox.Text.Trim().ToString());
                    //get the values only 
                    string LoginUserName = user.First().USERNAME;
                    string LoginPassword = user.First().PASSWORD;
                    bool activation = user.First().ACTIVATION;
                    //load user into to Userinfo.cs
                    UsersInfo.Username = LoginUserName;
                    UsersInfo.User_Password = LoginPassword;
                    UsersInfo.User_ID = user.First().id.ToString();
                    UsersInfo.Role_ID = Convert.ToInt32(user.First().ROLE_ID);
                    if (LoginUserName == Convert.ToString(UserNameTxtBox.Text.Trim()) && (LoginPassword == Convert.ToString(Passwordtxtbox.Text.Trim())))
                    {
                        if (activation == true)
                        {
                            this.Hide();
                            // don't forget that when a user enters a wrong password it tells them a wrong password is entered instead of error 
                            UserAccess();

                        }
                        else
                        {
                            MessageBox.Show("Your Account has been deactivated. Contact support for more inforamtion.", "Login - CONTACT SUPPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("User Name and Pass are Invalid", "Login - Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UserName Doesn't exists", "Login - Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("UserName and password can't be empty", "Login - Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //Exit
        private void picboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Forget pass
        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to contact Support if you forget your pass \n supp@library.com", "Login - Forgot passward", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("An error accured while Loging in due to Roles issues. \n Please contact support at \n  \t supp@library.com \n " + ex.Message, "Login - Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // login not empty. 
        private bool IsLoginValid()
        {
            if (UserNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is required.", "Login - Login Warning", MessageBoxButtons.OK);
                UserNameTxtBox.Focus();
                return false;
            }
            if (Passwordtxtbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Pass is required.", "Login - Login Warning", MessageBoxButtons.OK);
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



