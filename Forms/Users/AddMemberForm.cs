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
    public partial class AddMemberForm : Form
    {
        public int ADD_TO_USER, ADD_OR_UPDATE; //Hold the user Id of the recent user added
        public string User_ID, Member_ID;

        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<MEMBERModel> MemberCollection;
        IMongoCollection<User1> UserCollection;
        public AddMemberForm()
        {
            InitializeComponent();
            refreshRolesData();
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            MemberCollection = mongodb.GetCollection<MEMBERModel>("MEMBER");
            UserCollection = mongodb.GetCollection<User1>("USERS");



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
                    // first add user then add member
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
                        });

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Adding a User  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, " Adding Member Window Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        txtboxUsername.Focus();
                    }

                    //Adding to an MEMBER
                    try
                    {
                        var user = UserCollection.Find(x => x.USERNAME == txtboxUsername.Text.Trim().ToString());
                        ObjectId us_id = user.First().id;
                        // adding MEMBER
                        Program.db.InsertRecord("MEMBER",
                        new MEMBERModel
                        {
                            NAME = txtboxName.Text.Trim(),
                            ADDRESS = txtboxAddress.Text.Trim(),
                            USER_ID = us_id,
                            GENDER = cmbGender.Text.ToString(),
                            EMAIL = txtboxEmail.Text.Trim(),
                        });

                        AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                        SuccForm.lblTaskCompleted.Text = "Member added ";
                        SuccForm.ShowDialog();
                        ClearTextBoxes(this.Controls);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Adding an Member an Error catched \n" + ex.Message + "\n" + ex.StackTrace, " Adding Admin Window - Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    //way 1
                    var updateDef = Builders<User1>.Update
                                                    .Set(a => a.USERNAME, txtboxAddress.Text.Trim())
                                                    .Set(a => a.PASSWORD, txtboxPassword.Text.Trim())
                                                    .Set(a => a.ROLE_ID, Convert.ToString(cmbboxUserRole.SelectedValue))
                                                    .Set(a => a.ACTIVATION, checkboxActivation.Checked);
                    UserCollection.UpdateOne(s => s.id == ObjectId.Parse(User_ID), updateDef);
                    //Updating Member
                    //way 1
                    var updateDef2 = Builders<MEMBERModel>.Update
                                                    .Set(a => a.NAME, txtboxName.Text.Trim())
                                                    .Set(a => a.GENDER, cmbGender.Text.Trim())
                                                    .Set(a => a.ADDRESS, txtboxAddress.Text.Trim())
                                                    .Set(a => a.EMAIL, txtboxEmail.Text.Trim());
                    MemberCollection.UpdateOne(s => s._id == ObjectId.Parse(Member_ID), updateDef2);

                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "Member Updated ";
                    SuccForm.ShowDialog();
                    ClearTextBoxes(this.Controls);

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

        //------------------------------------Behind the scene functions----------------------------------------
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
                return 0;

            }


        }
        //roles data
        private void refreshRolesData()
        {
            try
            {
                var roles = Program.db.LoadRecord<Roles>("ROLES");
                cmbboxUserRole.DataSource = roles.ToList();
                cmbboxUserRole.DisplayMember = "ROLE_TITLE";
                cmbboxUserRole.ValueMember = "ROLE_ID";
                cmbboxUserRole.SelectedIndex = cmbboxUserRole.FindStringExact("MEMBER");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Roles data \n " + ex.Message, "Add Member form - Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void GetUserDataToUpdate()
        {

            //Updating to user
            var user = UserCollection.Find(x => x.id == ObjectId.Parse(this.User_ID));

            //ser the values to theits fields 
            string username = user.First().USERNAME.ToString();
            string pass = user.First().PASSWORD.ToString();
            bool activation = user.First().ACTIVATION;
            txtboxUsername.Text = username;
            txtboxPassword.Text = pass;
            checkboxActivation.Checked = activation;

        }


    }
    [BsonIgnoreExtraElements]
    internal class MEMBERModel

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
