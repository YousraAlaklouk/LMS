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
    public partial class AddMemberForm : Form
    {
        public int ADD_TO_USER; //Hold the user Id of the recent user added
        public int ADD_OR_UPDATE, User_ID, Member_ID;

        public AddMemberForm()
        {
            InitializeComponent();
            refreshRolesData();
        }

        /*------------------------------------Buttons----------------------------------------*/
        //min-max
        private void picboxMax_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;


            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Add + Update form
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (ADD_OR_UPDATE == 0)
            {   //adding 
                if (IsValidToAdd() <= 0)
                {

                    try
                    {
                        //adding to user
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("ADD_USER", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@USERNAME", txtboxUsername.Text);
                                cmd.Parameters.AddWithValue("@PASSWORD", txtboxPassword.Text);
                                cmd.Parameters.AddWithValue("@ROLE_ID", cmbboxUserRole.SelectedValue);
                                cmd.Parameters.AddWithValue("@ACTIVATION", checkboxActivation.Checked);
                                cmd.Parameters.AddWithValue("@CREATED_BY", UsersInfo.Username);
                                cmd.Parameters.AddWithValue("@BORROW_LIMIT", UsersInfo.Book_limit);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                //cmd.ExecuteNonQuery();
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
                                SuccForm.lblTaskCompleted.Text = "Member Added";
                                SuccForm.ShowDialog();
                                ClearTextBoxes(this.Controls);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Adding a Member an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        txtboxName.Focus();
                    }
                }
            }
            //updating
            else
            {
                try
                {
                    //Updating to user
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE_USERS", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", User_ID);
                            cmd.Parameters.AddWithValue("@USERNAME ", txtboxUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@PASSWORD", txtboxPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@ROLE_ID", cmbboxUserRole.SelectedValue);
                            cmd.Parameters.AddWithValue("@ACTIVATION", checkboxActivation.Checked);
                            cmd.Parameters.AddWithValue("@CREATED_BY", UsersInfo.Username);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            SqlDataReader dr = cmd.ExecuteReader();

                        }

                    }

                    //Updating admin
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE_MEMBER", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@USER_ID", User_ID);
                            cmd.Parameters.AddWithValue("@NAME", txtboxName.Text.Trim());
                            cmd.Parameters.AddWithValue("@EMAIL", txtboxEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@GENDER", cmbGender.Text.ToString());
                            cmd.Parameters.AddWithValue("@ADDRESS", txtboxAddress.Text);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                            SuccForm.lblTaskCompleted.Text = "Member Updated ";
                            SuccForm.ShowDialog();
                            ClearTextBoxes(this.Controls);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Updating a Member  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtboxName.Focus();
                }
            }
         }

        /*------------------------------------Behind the scene functions----------------------------------------*/
        //Is data valid and Username doesn't exists
        private int IsValidToAdd()
        {
            if (txtboxName.Text == string.Empty)
            {
                MessageBox.Show("Name Can't be empty");
                return 2;
            }
            if (txtboxPassword.Text == string.Empty)
            {
                MessageBox.Show("Password can't be empty");
                return 2;
            }
            if ((txtboxUsername.Text == string.Empty))
            {
                MessageBox.Show("username can't be empty");
                return 2;
            }
            else
            {
                if (ADD_OR_UPDATE == 0)
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
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
                    }
                }
                return 1;
            }
        }
        //roles data
        private void refreshRolesData()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("COMBO_ROLES_USER", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        cmbboxUserRole.DataSource = dtRoles;
                        cmbboxUserRole.DisplayMember = "ROLE_TITLE";
                        cmbboxUserRole.ValueMember = "ROLE_ID";
                        cmbboxUserRole.SelectedIndex = cmbboxUserRole.FindStringExact("Member");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Roles to combo \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //Clear textboxes
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
