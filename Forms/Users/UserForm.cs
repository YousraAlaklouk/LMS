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
    public partial class UserForm : Form
    {
        public string username;
        public string ID;

        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<User1> UserCollection;

        public UserForm()
        {
            InitializeComponent();
            refreshRolesData();
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            UserCollection = mongodb.GetCollection<User1>("USERS");
            LoadUserData();

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

        //add user -- working
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    //way 2 trying 
                    Program.db.InsertRecord("USERS",
                        new User1
                        {
                            USERNAME = txtboxUserName.Text.Trim(),
                            PASSWORD = txtboxPassword.Text.Trim(),
                            ROLE_ID = Convert.ToString(cmbboxUserRole.SelectedValue),
                            ACTIVATION = checkboxActivation.Checked,
                            CREATED_BY = UsersInfo.Username.Trim()
                        });

                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "User added ";
                    SuccForm.ShowDialog();
                    LoadUserData();
                    ClearTextBoxes(this.Controls);
                    // way 1 worrking 
                    /* Users1 usr = new Users1();
                     usr.USERNAME = txtboxUserName.Text.Trim();
                     usr.PASSWORD = txtboxPassword.Text.Trim();
                     usr.ROLE_ID = Convert.ToString(cmbboxUserRole.SelectedValue);
                     usr.ACTIVATION = checkboxActivation.Checked;
                     usr.CREATED_BY = "Testing";
                     UserCollection.InsertOne(usr);
                     AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                     SuccForm.lblTaskCompleted.Text = "User added ";
                     SuccForm.ShowDialog();
                     ClearTextBoxes(this.Controls);*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Adding a User  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtboxUserName.Focus();
                }
            }

        }

        //update --working
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
                    //way 1
                    var updateDef = Builders<User1>.Update
                                                    .Set("USERNAME", txtboxUserName.Text.Trim())
                                                    .Set("PASSWORD", txtboxPassword.Text.Trim())
                                                    .Set("ROLE_ID", Convert.ToString(cmbboxUserRole.SelectedValue))
                                                    .Set("ACTIVATION", checkboxActivation.Checked);
                    UserCollection.UpdateOne(s => s.id == ObjectId.Parse(ID), updateDef);
                    // way 2 
                    /*                    var OneRec = Program.db.loadRecordById<User1>("Users", new ObjectId(ID));
                                        OneRec.USERNAME = txtboxUserName.Text.Trim().ToString();
                                        OneRec.PASSWORD = txtboxPassword.Text.Trim().ToString();
                                        OneRec.ROLE_ID = (string)cmbboxUserRole.SelectedValue;
                                        OneRec.ACTIVATION = checkboxActivation.Checked;
                                        Program.db.UpdateRecord("Users",OneRec.id, OneRec);*/




                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "Updated Successfully";
                    LoadUserData();
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

        //Delete --working
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly AReyou sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rslt == DialogResult.Yes)
            {
                try
                {
                    UserCollection.DeleteOne(d => d.id == ObjectId.Parse(ID));

                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "User Deleted";
                    SuccForm.ShowDialog();
                    LoadUserData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Deleting a User an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ClearTextBoxes(this.Controls);
                    lblUserName.Focus();
                }

            }
            ClearTextBoxes(this.Controls);

        }


        /*-----------------------------------------Behind the scene Functions-----------------------------------------  */
        // input data is Vaild --working
        private bool IsValid()
        {
            try
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
                if (cmbboxUserRole.SelectedIndex == -1)
                {
                    MessageBox.Show("ROLE");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while checking username data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        //Load data to update  --working
        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUser.Rows.Count > 0)
            {
                ID = dataGridViewUser.CurrentRow.Cells[0].Value.ToString();
                //username = dataGridViewUser.CurrentRow.Cells[1].Value.ToString();
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

        //Load User data  --working
        private void LoadUserData()
        {
            try
            {
                /*//way 1
                var filterDefintion = Builders<Users1>.Filter.Empty;
                var users = UserCollection.Find(filterDefintion).ToList();
                dataGridViewUser.DataSource = users;

                //way 2 
                List<Users1> list = UserCollection.AsQueryable().ToList<Users1>();
                dataGridViewUser.DataSource = list;*/

                // way 3 general functions               
                var recs = Program.db.LoadRecord<User1>("USERS");
                dataGridViewUser.DataSource = recs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Users data \n " + ex.Message, "UserForm - Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // load Role TO combobox --working
        private void refreshRolesData()
        {
            try
            {
                var roles = Program.db.LoadRecord<Roles>("ROLES");
                cmbboxUserRole.DataSource = roles.ToList();
                cmbboxUserRole.DisplayMember = "ROLE_TITLE";
                cmbboxUserRole.ValueMember = "ROLE_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading roles data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //clear text boxes --working
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

        private void btnDeleteUser_Click_1(object sender, EventArgs e)
        {

        }
    }
    /// <summary>
    /// Models
    /// </summary>
    [BsonIgnoreExtraElements]
    internal class User1
    {
        public ObjectId id { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string ROLE_ID { get; set; }
        public bool ACTIVATION { get; set; }
        public string CREATED_BY { get; set; }
        public string CREATED_DATE { get; set; }
        public string BORROW_LIMIT { get; set; }
    }

}