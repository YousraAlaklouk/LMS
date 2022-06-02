using LibraryManegement.General;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
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
    public partial class AddAdminForm : Form
    {
        public int ADD_OR_UPDATE;
        public string User_ID, Admin_ID, ADD_TO_USER;
        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<ADMIN> AdminCollection;
        IMongoCollection<User1> UserCollection;

        public AddAdminForm()
        {
            InitializeComponent();
            refreshRolesData();
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            AdminCollection = mongodb.GetCollection<ADMIN>("ADMIN");
            UserCollection = mongodb.GetCollection<User1>("USERS");
        }

        /*------------------------------------Buttons----------------------------------------*/
        // close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // max_min 
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
        // add admin + Update admin
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (ADD_OR_UPDATE == 0)
            {
                //Add admin
                if (IsValidToAdd() <= 0)
                {
                    // first add user then add admin
                    try
                    {
                        Program.db.InsertRecord("USERS",
                        new User1
                        {
                            USERNAME = txtboxUsername.Text.Trim(),
                            PASSWORD = txtboxPassword.Text.Trim(),
                            ROLE_ID = Convert.ToString(cmbboxUserRole.SelectedValue),
                            ACTIVATION = checkboxActivation.Checked,
                            CREATED_BY = UsersInfo.Username.Trim()
                        }); ;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Adding a User  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, " Adding Admin Window Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        txtboxUsername.Focus();
                    }
                    // adding admin
                    try
                    {
                        var user = UserCollection.Find(x => x.USERNAME == txtboxUsername.Text.Trim().ToString());
                        ObjectId us_id = user.First().id;
                        // adding admin
                        Program.db.InsertRecord("ADMIN",
                        new ADMIN
                        {
                            NAME = txtboxName.Text.Trim(),
                            ADDRESS = txtboxAddress.Text.Trim(),
                            USER_ID = us_id,
                            GENDER = RadioButtonText(),
                            EMAIL = txtboxEmail.Text.Trim(),
                        });

                        AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                        SuccForm.lblTaskCompleted.Text = "admin added ";
                        SuccForm.ShowDialog();
                        ClearTextBoxes(this.Controls);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Adding an Admin  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, " Adding Admin Window - Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        txtboxName.Focus();
                    }
                }
            }
            else
            {
                // updating User
                try
                {
                    //way 1
                    var updateDef = Builders<User1>.Update
                                                    .Set("USERNAME", txtboxUsername.Text.Trim())
                                                    .Set("PASSWORD", txtboxPassword.Text.Trim())
                                                    .Set("ROLE_ID", Convert.ToString(cmbboxUserRole.SelectedValue))
                                                    .Set("ACTIVATION", checkboxActivation.Checked);
                    UserCollection.UpdateOne(s => s.id == ObjectId.Parse(User_ID), updateDef);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Updating a User an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Updating Admin Window - Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ClearTextBoxes(this.Controls);
                }
                // updating ADMIN
                try
                {
                    var user = UserCollection.Find(x => x.USERNAME == txtboxUsername.Text.Trim().ToString());
                    ObjectId us_id = user.First().id;
                    //way 1
                    var updateDef = Builders<ADMIN>.Update
                                                    .Set("NAME", txtboxUsername.Text.Trim())
                                                    .Set("USER_ID", us_id)
                                                    .Set("EMAIL", txtboxEmail.Text.Trim())
                                                    .Set("GENDER", RadioButtonText())
                                                    .Set("ADDRESS", txtboxAddress.Text.Trim());
                    AdminCollection.UpdateOne(admin => admin._id == ObjectId.Parse(Admin_ID), updateDef);
                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "admin Updated ";
                    SuccForm.ShowDialog();
                    ClearTextBoxes(this.Controls);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Updating an Admin an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Updating Admin Window - Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ClearTextBoxes(this.Controls);
                }
            }
        }

        /*------------------------------------Behind the Scene functions----------------------------------------*/
        // roles data -- working
        private void refreshRolesData()
        {
            try
            {
                var roles = Program.db.LoadRecord<Roles>("ROLES");
                cmbboxUserRole.DataSource = roles.ToList();
                cmbboxUserRole.DisplayMember = "ROLE_TITLE";
                cmbboxUserRole.ValueMember = "ROLE_ID";
                cmbboxUserRole.SelectedIndex = cmbboxUserRole.FindStringExact("Admin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Roles data \n " + ex.Message, "Add admin form - Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // is data valid to add
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
                return 0;

            }


        }
        // gender button
        private string RadioButtonText()
        {
            if (rdiobtnMale.Checked)
            {
                return rdiobtnMale.Text;
            }
            else
            {
                return rdiobtnFemale.Text;
            }
        }
        // clear text boxes
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
    internal class ADMIN
    {
        [BsonId]
        public ObjectId _id { get; set; }

        public ObjectId USER_ID { get; set; }

        public string NAME { get; set; }
        public string GENDER { get; set; }
        public string ADDRESS { get; set; }
        public string EMAIL { get; set; }
    }
}
