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

namespace LibraryManegement.Forms.Users
{
    public partial class Profile : Form
    {
        public string gender;

        public Profile()
        {
            InitializeComponent();
        }

        //load Profile data
        private void Profile_Load(object sender, EventArgs e)
        {
   /*         try
            {
                switch (UsersInfo.Role_ID)
                {
                    case 1://ADMIN
                        try
                        {
                            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                            {
                                using (SqlCommand cmd = new SqlCommand("LOAD_ADMIN_PROFILE_DATA", con))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@USER_ID", UsersInfo.User_ID);

                                    if (con.State != ConnectionState.Open)
                                        con.Open();


                                    DataTable dtUser = new DataTable();

                                    SqlDataReader sdr = cmd.ExecuteReader();

                                    if (sdr.HasRows)
                                    {

                                        dtUser.Load(sdr);

                                        DataRow userData = dtUser.Rows[0];

                                        txtboxName.Text = userData["NAME"].ToString();
                                        txtboxEmail.Text = userData["EMAIL"].ToString();
                                        txtboxAddress.Text = userData["ADDRESS"].ToString();
                                        gender = userData["GENDER"].ToString();

                                    }
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("An error accured while loading  Profile  data \n " + ex.Message, "Admin Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;
                    case 2: //STAFF
                        try
                        {
                            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                            {
                                using (SqlCommand cmd = new SqlCommand("LOAD_STAFF_PROFILE_DATA", con))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@USER_ID", UsersInfo.User_ID);

                                    if (con.State != ConnectionState.Open)
                                        con.Open();


                                    DataTable dtUser = new DataTable();

                                    SqlDataReader sdr = cmd.ExecuteReader();

                                    if (sdr.HasRows)
                                    {

                                        dtUser.Load(sdr);

                                        DataRow userData = dtUser.Rows[0];

                                        txtboxName.Text = userData["NAME"].ToString();
                                        txtboxEmail.Text = userData["EMAIL"].ToString();
                                        txtboxAddress.Text = userData["ADDRESS"].ToString();
                                        gender = userData["GENDER"].ToString();
                                    }
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("An error accured while loading Profile data \n " + ex.Message, "Staff Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;
                    case 4: //MEMBER
                        try
                        {
                            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                            {
                                using (SqlCommand cmd = new SqlCommand("LOAD_MEMBER_PROFILE_DATA", con))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@USER_ID", UsersInfo.User_ID);

                                    if (con.State != ConnectionState.Open)
                                        con.Open();


                                    DataTable dtUser = new DataTable();

                                    SqlDataReader sdr = cmd.ExecuteReader();

                                    if (sdr.HasRows)
                                    {

                                        dtUser.Load(sdr);

                                        DataRow userData = dtUser.Rows[0];

                                        txtboxName.Text = userData["NAME"].ToString();
                                        txtboxEmail.Text = userData["EMAIL"].ToString();
                                        txtboxAddress.Text = userData["ADDRESS"].ToString();
                                        gender = userData["GENDER"].ToString();
                                    }
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("An error accured while loading  Profile  data \n " + ex.Message, "Member Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while Loading data in General  due to Roles issues. \n Please contact support at \n  \t supp@library.com \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        //change ppass
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePasswardFrom form1 = new ChangePasswardFrom();
            form1.ShowDialog();
        }
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //max_min 
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
        //update profile
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            /*
                        switch (UsersInfo.Role_ID)
                        {
                            case 1: //Updating admin profile
                                try
                                {

                                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                                    {
                                        using (SqlCommand cmd = new SqlCommand("UPDATE_ADMIN", con))
                                        {
                                            cmd.CommandType = CommandType.StoredProcedure;
                                            cmd.Parameters.AddWithValue("@USER_ID", UsersInfo.User_ID);
                                            cmd.Parameters.AddWithValue("@NAME", txtboxName.Text);
                                            cmd.Parameters.AddWithValue("@EMAIL", txtboxEmail.Text);
                                            cmd.Parameters.AddWithValue("@GENDER", gender);
                                            cmd.Parameters.AddWithValue("@ADDRESS", txtboxAddress.Text);

                                            if (con.State != ConnectionState.Open)
                                                con.Open();

                                            cmd.ExecuteNonQuery();
                                            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                            SuccForm.lblTaskCompleted.Text = "Profile Updated ";
                                            SuccForm.ShowDialog();
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("While Updating Profile  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Updating Admin Profile  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                            case 2: // Updating staff member profile
                                try
                                {
                                    //Updating admin
                                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                                    {
                                        using (SqlCommand cmd = new SqlCommand("UPDATE_STAFF", con))
                                        {
                                            cmd.CommandType = CommandType.StoredProcedure;
                                            cmd.Parameters.AddWithValue("@USER_ID", UsersInfo.User_ID);
                                            cmd.Parameters.AddWithValue("@NAME", txtboxName.Text);
                                            cmd.Parameters.AddWithValue("@EMAIL", txtboxEmail.Text);
                                            cmd.Parameters.AddWithValue("@GENDER",gender);
                                            cmd.Parameters.AddWithValue("@ADDRESS", txtboxAddress.Text);

                                            if (con.State != ConnectionState.Open)
                                                con.Open();

                                            cmd.ExecuteNonQuery();
                                            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                            SuccForm.lblTaskCompleted.Text = "Profile Updated ";
                                            SuccForm.ShowDialog();

                                        }
                                    }
                                }
                                catch (Exception ex) {

                                    MessageBox.Show("While Updating Profile  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Updating staff Profile  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                            case 4: // UPDATING MEMBER PROFILE
                                try
                                {
                                    //Updating admin
                                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                                    {
                                        using (SqlCommand cmd = new SqlCommand("UPDATE_MEMBER", con))
                                        {
                                            cmd.CommandType = CommandType.StoredProcedure;
                                            cmd.Parameters.AddWithValue("@USER_ID", UsersInfo.User_ID);
                                            cmd.Parameters.AddWithValue("@NAME", txtboxName.Text.Trim());
                                            cmd.Parameters.AddWithValue("@EMAIL", txtboxEmail.Text.Trim());
                                            cmd.Parameters.AddWithValue("@GENDER", gender);
                                            cmd.Parameters.AddWithValue("@ADDRESS", txtboxAddress.Text);

                                            if (con.State != ConnectionState.Open)
                                                con.Open();

                                            cmd.ExecuteNonQuery();

                                            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                            SuccForm.lblTaskCompleted.Text = "Profile Updated ";
                                            SuccForm.ShowDialog();
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("While Updating Profile an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Updating Member Profile  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                        
                    }*/
        }

    }
    }
