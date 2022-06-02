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
    public partial class UserForm : Form
    {
        public String username;
        public int ID;
        public UserForm()
        {
            InitializeComponent();
            refreshRolesData();
        }

/*-----------------------------------------Buttons-----------------------------------------  */
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
        //update
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtboxUserName.Text == string.Empty)
            {
                MessageBox.Show("Selecet a row or cell of the User you want to update \n ", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE_USERS", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", ID);
                            cmd.Parameters.AddWithValue("@USERNAME ", txtboxUserName.Text.Trim());
                            cmd.Parameters.AddWithValue("@PASSWORD", txtboxPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@ROLE_ID", cmbboxUserRole.SelectedValue);
                            cmd.Parameters.AddWithValue("@ACTIVATION", checkboxActivation.Checked);
                            cmd.Parameters.AddWithValue("@CREATED_BY", UsersInfo.Username);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            SqlDataReader dr = cmd.ExecuteReader();

                        }

                    }
                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "Updated Successfully";
                    SuccForm.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Updating a User an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ClearTextBoxes(this.Controls);
                }
            }
        }
        

        /*-----------------------------------------Behind the scene Functions-----------------------------------------  */
        // input data is Vaild
        private bool IsValid()
        {
            if (txtboxUserName.Text == string.Empty)
            {
                MessageBox.Show("Name");
                return false;
            }
            if (txtboxPassword.Text == string.Empty)
            {
                MessageBox.Show("Pass");
                return false;
            }
            if ((cmbboxUserRole.SelectedIndex == -1))
            {
                MessageBox.Show("ROLE");
                return false;
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM USERS  WHERE ([USERNAME] = @USERNAME)", con))
                        {
                            check_User_Name.Parameters.AddWithValue("@USERNAME", txtboxUserName.Text);
                            if (con.State != ConnectionState.Open)
                                con.Open();
                            int UserExist = (int)check_User_Name.ExecuteScalar(); // if already exists returns 1 

                            if (UserExist > 0)
                            {
                                MessageBox.Show("UserName Is taken,  Already Exists. try something else", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
                                txtboxUserName.Focus();
                                return false;
                            }
                        }
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while checking username data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                        
                }
            }
        }

        //Load data to update
        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUser.Rows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridViewUser.CurrentRow.Cells[0].Value.ToString());
                username = dataGridViewUser.CurrentRow.Cells[1].Value.ToString();
                txtboxUserName.Text = dataGridViewUser.CurrentRow.Cells[1].Value.ToString();
                txtboxPassword.Text = dataGridViewUser.CurrentRow.Cells[2].Value.ToString();
                cmbboxUserRole.Text = dataGridViewUser.CurrentRow.Cells[3].Value.ToString();
                checkboxActivation.Checked = Convert.ToBoolean(dataGridViewUser.CurrentRow.Cells[4].Value);

            }
            else
            {
                MessageBox.Show("there is not Data selected from the Data table. \n Please Selelct Data first then try Again.");
            }
        }
        //Load User data
        private void LoadUserData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("LOAD_USERS_DATA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        dataGridViewUser.DataSource = dtRoles;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Users data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // load Role TO combobox
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


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading roles data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

       //Load data when from is open
        private void UserForm_Activated(object sender, EventArgs e)
                {
                    LoadUserData();
                }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }


        //// add user
        //private void btnAddUser_Click(object sender, EventArgs e)
        //{
        //    if (IsValid())
        //    {
        //        try
        //        {
        //            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
        //            {
        //                using (SqlCommand cmd = new SqlCommand("ADD_USER", con))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;

        //                    cmd.Parameters.AddWithValue("@USERNAME", txtboxUserName.Text);
        //                    cmd.Parameters.AddWithValue("@PASSWORD", txtboxPassword.Text);
        //                    cmd.Parameters.AddWithValue("@ROLE_ID", cmbboxUserRole.SelectedValue);
        //                    cmd.Parameters.AddWithValue("@ACTIVATION", checkboxActivation.Checked);
        //                    cmd.Parameters.AddWithValue("@CREATED_BY", UsersInfo.Username);

        //                    if (con.State != ConnectionState.Open)
        //                        con.Open();

        //                    cmd.ExecuteNonQuery();
        //                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
        //                    SuccForm.lblTaskCompleted.Text = "User added ";
        //                    SuccForm.ShowDialog();
        //                    ClearTextBoxes(this.Controls);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("While Adding a User  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        finally
        //        {
        //            txtboxUserName.Focus();
        //        }
        //    }

        //}

        ////Delete 
        //private void btnDeleteUser_Click(object sender, EventArgs e)
        //{
        //    DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly AReyou sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (rslt == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
        //            {
        //                using (SqlCommand cmd = new SqlCommand("DELETE_USER", con))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;

        //                    cmd.Parameters.AddWithValue("@ID", ID);

        //                    if (con.State != ConnectionState.Open)
        //                        con.Open();

        //                    cmd.ExecuteReader();

        //                }
        //            }
        //            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
        //            SuccForm.lblTaskCompleted.Text = "User Deleted";
        //            SuccForm.ShowDialog();

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("While Deleting a User an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        finally
        //        {
        //            ClearTextBoxes(this.Controls);
        //            lblUserName.Focus();
        //        }

        //    }
        //    ClearTextBoxes(this.Controls);
        //}
    }
}
