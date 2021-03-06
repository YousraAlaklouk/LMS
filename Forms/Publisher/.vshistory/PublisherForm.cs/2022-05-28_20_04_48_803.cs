using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson.IO;
using MongoDB.Driver.GeoJsonObjectModel;
using LibraryManegement.Forms.Publisher;

namespace LibraryManegement
{
    public partial class PublisherForm : Form
    {
        MongoClient client;
        IMongoDatabase MDatabase;
        IMongoCollection<PublisherAdd> BCollection;
        public string ID;
        public string username;

        public PublisherForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            MDatabase = client.GetDatabase("LibraryManagement");
            BCollection = MDatabase.GetCollection<PublisherAdd>("PUBLISHER");
            refreshPublisherData();

        }

        /* --------------------------Buttons-----------------------------------------------*/
        //add Publisher
        private void btnAddPublisher_Click(object sender, EventArgs e)
        {

            PublisherAdd publisher = new PublisherAdd();
            publisher.NAME = txtboxPublisherName.Text;
            publisher.EMAIL = txtboxPublisherEmail.Text;
            publisher.FOUNDATION_YEAR = Convert.ToInt32(txtboxpublisherYearOffoundation.Text);
            publisher.ADDRESS = txtboxPublisherAddress.Text;
            BCollection.InsertOne(publisher);

            MessageBox.Show("New Publisher added", "Success", MessageBoxButtons.OK , MessageBoxIcon.Information);
            refreshPublisherData();




        }
        //Delete Publisher
        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            if (txtboxPublisherName.Text == string.Empty || txtboxPublisherAddress.Text == string.Empty)
            {
                MessageBox.Show("Choose data to delete, Choose a cell or row of publisher you wants to delete", "Deleting Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*                if (checkPublisherBeforeDelete().Equals(true))
                                {*/
                //can delete
                DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly Are you sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    try
                    {
                        BCollection.DeleteOne(d => d.Id == ObjectId.Parse(ID));


                        AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                        SuccForm.lblTaskCompleted.Text = "Publisher Deleted";
                        SuccForm.ShowDialog();
                        refreshPublisherData();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Deleting a Publisher an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ClearTextBoxes(this.Controls);
                    }
                }


            }
        }
        //Update Publisher
        private void btnUpdatePublisher_Click(object sender, EventArgs e)
        {

            if (txtboxPublisherName.Text != string.Empty || txtboxPublisherEmail.Text != string.Empty)
            {
                try
                {
                    var updateDef = Builders<PublisherAdd>.Update
                                 .Set(a => a.NAME, txtboxPublisherName.Text)
                                 .Set(a => a.EMAIL, txtboxPublisherEmail.Text)
                                 .Set(a => a.FOUNDATION_YEAR, Convert.ToInt32(txtboxpublisherYearOffoundation.Text))
                                 .Set(a => a.ADDRESS, txtboxPublisherAddress.Text);



                    BCollection.UpdateOne(s => s.Id == ObjectId.Parse(ID), updateDef);
                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "Updated Successfully";
                    refreshPublisherData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Updating the Author Error catched:  \n" + ex.Message, "Catched an error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ClearTextBoxes(this.Controls);
                }
            }
            else
            {
                MessageBox.Show(" Choose data to Update", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //back
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //max-min
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
        /* -------------------------------Behind the scene-------------------------------------*/
        //load  publishers 
        private void AddPublisherForm_Activated(object sender, EventArgs e)
        {

        }
        //show the data to update
        private void dataGridViewPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPublisher.Rows.Count > 0)
            {
                ID = dataGridViewPublisher.CurrentRow.Cells[0].Value.ToString();
                //username = dataGridViewUser.CurrentRow.Cells[1].Value.ToString();
                txtboxPublisherName.Text = dataGridViewPublisher.CurrentRow.Cells[1].Value.ToString();
                txtboxPublisherEmail.Text = dataGridViewPublisher.CurrentRow.Cells[2].Value.ToString();
                txtboxpublisherYearOffoundation.Text = dataGridViewPublisher.CurrentRow.Cells[3].Value.ToString();
                txtboxPublisherAddress.Text = dataGridViewPublisher.CurrentRow.Cells[4].Value.ToString();

            }
        }
 
        //Accept only digits
        private void txtboxpublisherYearOffoundation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //clear controls
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
        //Load data to grid view
        private void refreshPublisherData()
        {
            var filterDefinition = Builders<PublisherAdd>.Filter.Empty;
            var Publisher = BCollection.Find(filterDefinition).ToList();
            dataGridViewPublisher.DataSource = Publisher;
        }





    }
}

