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
    public partial class SignUpMemberForm : Form
    {
        public int counter = 0;
        public int time = 0;
        public string text;

        public int ADD_TO_USER;

        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<User1> UserCollection;
        IMongoCollection<MEMBER> MemberCollection;
        public SignUpMemberForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            MemberCollection = mongodb.GetCollection<MEMBER>("MEMBER");
            UserCollection = mongodb.GetCollection<User1>("USERS");

        }

        //moving text
        private void AddMemberForm_Load(object sender, EventArgs e)
        {

            text = lblWelcome.Text;
            time = text.Length;
            lblWelcome.Text = "";
            timer1.Start();

        }

        //timer the moving text
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWelcome.Text = text.Substring(0, counter);
            ++counter;
            if (counter > time)
            {
                timer1.Stop();
            }

        }
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // add member as a member
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (chckboxPrivecy.Checked)
            {
                if (IsValidToAdd() <= 0)
                {
                    try
                    {
                        Program.db.InsertRecord("USERS",
                        new User1
                        {
                            USERNAME = txtboxUsername.Text.Trim(),
                            PASSWORD = txtboxPassword.Text.Trim(),
                            ROLE_ID = "3",
                            ACTIVATION = true,
                            CREATED_BY = "New Member"
                        });
                        // adding Member
                        try
                        {
                            var user = UserCollection.Find(x => x.USERNAME == txtboxUsername.Text.Trim().ToString());
                            ObjectId us_id = user.First().id;
                            // adding admin
                            Program.db.InsertRecord("MEMBER",
                            new MEMBER
                            {
                                NAME = txtboxName.Text.Trim(),
                                ADDRESS = txtboxAddress.Text.Trim(),
                                USER_ID = us_id,
                                GENDER = cmbGender.SelectedItem.ToString(),
                                EMAIL = txtboxEmail.Text.Trim(),
                            });

                            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                            SuccForm.lblTaskCompleted.Text = " Welcome to the Library \n You can login now ";
                            SuccForm.ShowDialog();
                            ClearTextBoxes(this.Controls);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("While Adding a Member  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, " SignUp Window - Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            txtboxName.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Adding a User  an Error catched \n" + ex.Message + "\n" + ex.StackTrace, " sign up Window -  Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        txtboxUsername.Focus();
                    }



                }
            }
            else
            {
                MessageBox.Show("You can't sign up without accpeting the Privecy Policy", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Is data valid 
        private int IsValidToAdd()
        {
            if (txtboxUsername.Text == string.Empty || txtboxPassword.Text == string.Empty)
            {
                MessageBox.Show(" User name and Password can't be empty please try again!.", "Signup Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            else
            {

                return 0;
                /*try
                {
                    var user = UserCollection.Find(x => x.USERNAME == txtboxUsername.Text.Trim().ToString());
                    txtboxUsername.Focus();
                    MessageBox.Show("UserName Is taken,  Already Exists. try something else", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
                    return 1;

                }
                catch (Exception ex)
                {
                    return 0;
                }
                //get the values only 
                //  string UserName = user.First().USERNAME;

*/

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


    }
    [BsonIgnoreExtraElements]
    internal class MEMBER
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