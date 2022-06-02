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
    public partial class StaffForm : Form
    {
        public int ID, Users_ID;
        public string username;
        AddSttafForm staff_update = new AddSttafForm();
        public StaffForm()
        {
            InitializeComponent();
        }
        /*------------------------------------Buttons----------------------------------------*/
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
        //Delete  staff
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (staff_update.txtboxName.Text != string.Empty)
            {
                staff_update.ADD_OR_UPDATE = 1;
                DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly AReyou sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    try
                    {   //Delete member
                        /*                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                                                {
                                                    using (SqlCommand cmd = new SqlCommand("DELETE_STAFF", con))
                                                    {
                                                        cmd.CommandType = CommandType.StoredProcedure;

                                                        cmd.Parameters.AddWithValue("@ID", ID);

                                                        if (con.State != ConnectionState.Open)
                                                            con.Open();

                                                        cmd.ExecuteReader();

                                                    }
                                                }
                                                //Delete User
                                                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                                                {
                                                    using (SqlCommand cmd = new SqlCommand("DELETE_USER", con))
                                                    {
                                                        cmd.CommandType = CommandType.StoredProcedure;

                                                        cmd.Parameters.AddWithValue("@ID", Users_ID);

                                                        if (con.State != ConnectionState.Open)
                                                            con.Open();

                                                        cmd.ExecuteReader();

                                                    }

                                                }
                                                AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                                SuccForm.lblTaskCompleted.Text = "Staff Deleted";
                                                SuccForm.ShowDialog();

                        */
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Deleting a Staff an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("No data selected to delete, \n Select a row or cell of the staff you want to update \n ", "Deleting Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //add staff
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            //AddMemberForm mmb_add = new AddMemberForm();
            staff_update.ADD_OR_UPDATE = 0; // 0 to add 1 to update
            staff_update.User_ID = Users_ID;
            staff_update.ShowDialog();
        }
        // Update
        private void btnUpdatestaff_Click(object sender, EventArgs e)
        {
            if (staff_update.txtboxName.Text != string.Empty)
            {
                staff_update.ADD_OR_UPDATE = 1; // 0 to add 1 to update
                staff_update.User_ID = Users_ID;
                staff_update.Member_ID = ID;
                staff_update.btnAddStaff.ButtonText = "Update";
                staff_update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a row or cell of the staff you want to update \n ", " Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*------------------------------------Behind the Scene functions ----------------------------------------*/

        //Load data to update
        private void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewStaff.Rows.Count > 0)
            {
                username = dataGridViewStaff.CurrentRow.Cells[3].Value.ToString();
                ID = Convert.ToInt32(dataGridViewStaff.CurrentRow.Cells[0].Value);
                Users_ID = Convert.ToInt32(dataGridViewStaff.CurrentRow.Cells[1].Value);
                staff_update.txtboxName.Text = dataGridViewStaff.CurrentRow.Cells[2].Value.ToString();
                staff_update.txtboxUsername.Text = dataGridViewStaff.CurrentRow.Cells[3].Value.ToString();
                staff_update.txtboxPassword.Text = dataGridViewStaff.CurrentRow.Cells[4].Value.ToString();
                staff_update.cmbboxUserRole.SelectedItem = dataGridViewStaff.CurrentRow.Cells[4].Value.ToString();
                staff_update.txtboxAddress.Text = dataGridViewStaff.CurrentRow.Cells[6].Value.ToString();
                staff_update.txtboxEmail.Text = dataGridViewStaff.CurrentRow.Cells[7].Value.ToString();
                staff_update.checkboxActivation.Checked = Convert.ToBoolean(dataGridViewStaff.CurrentRow.Cells[8].Value);
            }

        }
        //load data when form is open
        private void StaffForm_Activated(object sender, EventArgs e)
        {
            LoadStaffData();
        }


        //Load staff data to data grid view
        private void LoadStaffData()
        {
            try
            {
/*

                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("LOAD_STAFF_DATA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        dataGridViewStaff.DataSource = dtRoles;
                    }
                }*/
            }
             catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading staff data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    
    }
}
