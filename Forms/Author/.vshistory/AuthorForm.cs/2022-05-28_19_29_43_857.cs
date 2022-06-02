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
using LibraryManegement.Forms.Author;

namespace LibraryManegement
{
    public partial class AuthorForm : Form
    {
        MongoClient client;
        IMongoDatabase MDatabase;
        IMongoCollection<AddAuthor> BCollection;

        public string ID;
        public string oldName;



        public AuthorForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            MDatabase = client.GetDatabase("LibraryManagement");
            BCollection = MDatabase.GetCollection<AddAuthor>("AUTHOR");
        }

        private void AddAuthorForm_Activated(object sender, EventArgs e)
        {
            refreshAuthorData();
        }
        /*-------------------------------------Buttons-----------------------------------------------------*/
        //Add Author
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            refreshAuthorData();

            AddAuthor author = new AddAuthor();
            author.NAME = txtboxAuthorName.Text;
            author.SURNAME = txtboxAuthorSurname.Text;
            author.NATIONALITY = txtboxAuthorNationality.Text;
            author.EMAIL = txtboxAuthorEmail.Text;
            BCollection.InsertOne(author);

            MessageBox.Show("New Author added");




        }
        //delete auhtor
        private void deleteAuthor_clicker(object sender, EventArgs e)
        {
            refreshAuthorData();

            if (txtboxAuthorName.Text == string.Empty || txtboxAuthorSurname.Text == string.Empty)
            {
                MessageBox.Show(" Choose data to Update, \n You Can't leave the Name and Email empty", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {
/*                    if (checkAuthorBeforeDelete().Equals(true))
                    {
                        //Can delete
                        DialogResult rslt = MessageBox.Show(" Author Will be Deleted Paremntly! \n Are you sure you want to Delete it?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rslt == DialogResult.Yes)
                        {*/
                            var filterDefinition = Builders<AddAuthor>.Filter.Eq(a => a.EMAIL, dataGridViewAuthor.CurrentCell.RowIndex.ToString());
                            BCollection.DeleteOne(filterDefinition);

                            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                            SuccForm.lblTaskCompleted.Text = "Author Deleted";
                            SuccForm.ShowDialog();
                            ClearTextBoxes(this.Controls);
/*

                        }
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("While Deleting an Author Error catched:  \n" + ex.Message, "Catched an error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        //update Author
        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            refreshAuthorData();
            //check if a cell is clicked to load the data

            if(txtboxAuthorName.Text != string.Empty || txtboxAuthorEmail.Text != string.Empty)
            { 
                try
                {
                    var updateDef = Builders<AddAuthor>.Update
                                 .Set(a => a.NAME, txtboxAuthorName.Text)
                                 .Set(a => a.SURNAME, txtboxAuthorSurname.Text)
                                 .Set(a => a.NATIONALITY, txtboxAuthorNationality.Text)
                                 .Set(a => a.EMAIL, txtboxAuthorEmail.Text);



                    BCollection.UpdateOne(s => s.Id == ObjectId.Parse(ID), updateDef);
                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "Updated Successfully";
                    refreshAuthorData();

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


                //close-Back
                private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Max min
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


        //show the data when videoGrid clicked
        private void dataGridViewAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewAuthor.Rows.Count > 0)
            {
                ID = dataGridViewAuthor.CurrentRow.Cells[0].Value.ToString();
                //username = dataGridViewUser.CurrentRow.Cells[1].Value.ToString();
                txtboxAuthorName.Text = dataGridViewAuthor.CurrentRow.Cells[1].Value.ToString();
                txtboxAuthorSurname.Text = dataGridViewAuthor.CurrentRow.Cells[2].Value.ToString();
                txtboxAuthorNationality.Text = dataGridViewAuthor.CurrentRow.Cells[3].Value.ToString();
                txtboxAuthorEmail.Text = dataGridViewAuthor.CurrentRow.Cells[4].Value.ToString();



            }
            else
            {
                MessageBox.Show("there is not Data selected from the Data table. \n Please Selelct Data first then try Again.");
            }


        }
        //Load data to grid view
        private void refreshAuthorData()
        {
            var filterDefinition = Builders<AddAuthor>.Filter.Empty;
            var AUTHOR = BCollection.Find(filterDefinition).ToList();
            dataGridViewAuthor.DataSource = AUTHOR;
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

        private void midPanel_Paint(object sender, PaintEventArgs e)
        {
            refreshAuthorData();
        }

        private void dataGridViewAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
    }
    }



