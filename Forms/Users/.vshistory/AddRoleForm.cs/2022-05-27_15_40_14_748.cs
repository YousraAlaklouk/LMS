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
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using static LibraryManegement.Forms.AddRoleForm;
using MongoDB.Driver.Linq;

namespace LibraryManegement.Forms
{
    public partial class AddRoleForm : Form
    {
        public int ROLE_ID;


        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<Roles> RoleCollection;
        public AddRoleForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            RoleCollection = mongodb.GetCollection<Roles>("ROLES");
        }
        //Load Role data when form is opened
        private void AddRoleForm_Activated(object sender, EventArgs e)
        {
            LoadRoleData();
        }

        /* ---------------------------------------------Buttons------------------------------------------ */
        //addRole
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("ADD_ROLE", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@ROLE_TITLE", txtboxRoleType.Text);
                            cmd.Parameters.AddWithValue("@DESCRIPTION", txtboxRoleDescription.Text);
                            cmd.Parameters.AddWithValue("@CREATEAD_BY", UsersInfo.Username);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("ROLE ADDED SUCCESSFULY ", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes(this.Controls); 
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("While adding a Role, an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    txtboxRoleType.Focus();
                }
            }
        }
        
        //Delete Role
        private void btnDeleteRole_Click(object sender, EventArgs e)
        {

            if (txtboxRoleType.Text == string.Empty)
            {
                MessageBox.Show("Selecet a row or cell of the Role you wants to update \n ", " Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly AReyou sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("DELETE_ROLES", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@ROLE_ID", ROLE_ID);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteReader();

                            }
                        }
                        AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                        SuccForm.lblTaskCompleted.Text = "Role Deleted";
                        SuccForm.ShowDialog();
                        ClearTextBoxes(this.Controls);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Deleting a Role, an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        // ClearTextBoxes(this.Controls); if any erroe showed it will move the seleceted area which is imitatding 
                        txtboxRoleType.Focus();

                    }

                }
            }
           
        }
        //Update Role
        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (txtboxRoleType.Text == string.Empty)
            {
                MessageBox.Show("Selecet a row or cell of the Role  you want to update \n ", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE_ROLE", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@ROLE_ID", ROLE_ID);
                            cmd.Parameters.AddWithValue("@ROLE_TITLE", txtboxRoleType.Text);
                            cmd.Parameters.AddWithValue("@DESCRIPTION", txtboxRoleDescription.Text);
                            cmd.Parameters.AddWithValue("@CREATEAD_BY", UsersInfo.Username);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            SqlDataReader dr = cmd.ExecuteReader();

                        }

                    }

                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "Updated Successfully";
                    SuccForm.ShowDialog();
                    ClearTextBoxes(this.Controls);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Updaing a Role, an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //RUNS ANYWAYS

                }
            }

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

        /* -----------------------------------Behinde the scene Functions---------------------------------- */
        //Load roles data
        private void LoadRoleData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("LOAD_ROLES_DATA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        dataGridViewRole.DataSource = dtRoles;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Role data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //Load data to update
        private void dataGridViewRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRole.Rows.Count > 0)
            {
                ROLE_ID = Convert.ToInt32(dataGridViewRole.CurrentRow.Cells[0].Value);
                txtboxRoleType.Text = dataGridViewRole.CurrentRow.Cells[1].Value.ToString();
                txtboxRoleDescription.Text = dataGridViewRole.CurrentRow.Cells[2].Value.ToString();
            }
        }
        //data validate
        private bool IsValid()
        {
            if (txtboxRoleType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ROLE TYPE IS REQUIRED", "ADDING ROLE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxRoleType.Focus();
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
    [BsonIgnoreExtraElements]
    internal class Roles
    {
        public ObjectId _id { get; set; }

        public int ROLE_ID { get; set; }

        public string ROLE_TITLE { get; set; }

        public string DESCRIPTION { get; set; }
        public string CREATEAD_BY { get; set; }
        public string CREATED_DATE { get; set; }
    }
}
