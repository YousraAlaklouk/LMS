using LibraryManegement.General;
using MongoDB.Bson;
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
    public partial class MemberForm : Form
    {

        public string ID;
        public string Users_ID;
        public string username;
        AddMemberForm mmb_update = new AddMemberForm();

        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<MEMBERModel> MemberCollection;
        public MemberForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            MemberCollection = mongodb.GetCollection<MEMBERModel>("MEMBER");
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
        //Add button
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            //AddMemberForm mmb_add = new AddMemberForm();
            mmb_update.ADD_OR_UPDATE = 0; // 0 to add 1 to update
            mmb_update.User_ID = Users_ID;
            mmb_update.ShowDialog();
        }
        //Update butotns
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (mmb_update.txtboxName.Text != string.Empty)
            {
                mmb_update.ADD_OR_UPDATE = 1; // 0 to add 1 to update
                mmb_update.User_ID = Users_ID;
                mmb_update.Member_ID = ID;
                mmb_update.btnAddMember.ButtonText = "Update";
                mmb_update.lblAdd.Text = "Update Member";
                mmb_update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecet a cell of the member you want to update \n ", " Select Member data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Delete button
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (mmb_update.txtboxName.Text != string.Empty)
            {
                DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly AReyou sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    try
                    {   //Delete member
                       
                        //Delete User
                        
                        AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                        SuccForm.lblTaskCompleted.Text = "Member Deleted";
                        SuccForm.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Deleting a member an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecet the row or cell of the member you want to Delete \n ", " Deleting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*------------------------------------Behind the Scene functions ----------------------------------------*/

        //load data when form is open
        private void MemberForm_Activated(object sender, EventArgs e)
        {
            LoadMemberData();
        }
        //Load data to update
        private void dataGridViewMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMember.Rows.Count > 0)
            {
                // username = dataGridViewMember.CurrentRow.Cells[3].Value.ToString();
                ID = Convert.ToString(dataGridViewMember.CurrentRow.Cells[0].Value);
                mmb_update.User_ID = Convert.ToString(dataGridViewMember.CurrentRow.Cells[1].Value);
                mmb_update.txtboxName.Text = dataGridViewMember.CurrentRow.Cells[2].Value.ToString();
                mmb_update.cmbGender.Text = dataGridViewMember.CurrentRow.Cells[3].Value.ToString();
                mmb_update.txtboxAddress.Text = dataGridViewMember.CurrentRow.Cells[4].Value.ToString();
                mmb_update.txtboxEmail.Text = dataGridViewMember.CurrentRow.Cells[5].Value.ToString();
                mmb_update.GetUserDataToUpdate();

                //user collection related7             
                /* mmb_update.txtboxUsername.Text = dataGridViewMember.CurrentRow.Cells[3].Value.ToString();
                 mmb_update.txtboxPassword.Text = dataGridViewMember.CurrentRow.Cells[4].Value.ToString();
                 mmb_update.checkboxActivation.Checked = Convert.ToBoolean(dataGridViewMember.CurrentRow.Cells[8].Value);*/
            }

        }

        //Load member data to data grid view
        private void LoadMemberData()
        {

            try
            {
                // way 3 general functions               
                //var recs = Program.db.LoadRecord<MEMBERModel>("MEMBER");
                //dataGridViewMember.DataSource = recs.ToList();
                /*var docs = AdminCollection.Aggregate()
                    .Lookup("USER1", "USER_ID", "_id", "as Users")
                    .As<BsonDocument>()
                    .ToList();*/
                var filterDef = Builders<MEMBERModel>.Filter.Empty;
                var member = MemberCollection.Find(filterDef).ToList();
                dataGridViewMember.DataSource = member.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Member data \n " + ex.Message, "Member Window - Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
