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

        public int ID;
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
            refreshPublisherData();
        }
        /*-------------------------------------Buttons-----------------------------------------------------*/
        //Add Author
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            refreshPublisherData();

            AddAuthor author = new AddAuthor();
            author.AuthorName = txtboxAuthorName.Text;
            author.AuthorSurname = txtboxAuthorSurname.Text;
            author.Nationality = txtboxAuthorNationality.Text;
            author.Email = txtboxAuthorEmail.Text;
            BCollection.InsertOne(author);

            MessageBox.Show("New Author added");




        }
        //delete auhtor
        private void deleteAuthor_clicker(object sender, EventArgs e)
        {
            refreshPublisherData();

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
                            var filterDefinition = Builders<AddAuthor>.Filter.Eq(a => a.Email, dataGridViewAuthor.CurrentCell.RowIndex.ToString());
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
            refreshPublisherData();
            //check if a cell is clicked to load the data
            if (txtboxAuthorName.Text == string.Empty || txtboxAuthorSurname.Text == string.Empty)
            {
                MessageBox.Show("Choose data to Update, \n You Can't leave the Name and Email empty", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    var filterDefinition = Builders<AddAuthor>.Filter.Eq(a => a.Email, dataGridViewAuthor.CurrentCell.RowIndex.ToString());
                    var UpdateDefinition = Builders<AddAuthor>.Update
                    .Set(a => a.AuthorName, txtboxAuthorName.Text)
                    .Set(a => a.AuthorSurname, txtboxAuthorSurname.Text)
                    .Set(a => a.Nationality, txtboxAuthorNationality.Text)
                    .Set(a => a.Email, txtboxAuthorEmail.Text);

                    BCollection.UpdateOne(filterDefinition, UpdateDefinition);
                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "Updated Successfully";
                    SuccForm.ShowDialog();


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


        /*-------------------------------Behind the scene functions----------------------------------------------*/
        //Author doesn't exists and data is valid
        /*        private int IsValid()
                {
                    if (txtboxAuthorName.Text != string.Empty && txtboxAuthorSurname.Text != string.Empty)
                    {

                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM AUTHOR WHERE ([NAME] = @NAME)", con))
                            {
                                check_User_Name.Parameters.AddWithValue("@NAME", txtboxAuthorName.Text);
                                if (con.State != ConnectionState.Open)
                                    con.Open();
                                int UserExist = (int)check_User_Name.ExecuteScalar(); // if already exists returns 1 

                                if (UserExist > 0)
                                {
                                    MessageBox.Show("Author Already Exists. ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
                                    return 1;
                                }
                                else
                                {
                                    return UserExist;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Author Name and Contact Can't Be Empty. Check it and Try Again!", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                        return 1;
                    }
                }*/
        //show the data when videoGrid clicked
        private void dataGridViewAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dataGridViewAuthor.Rows.Count > 0)
                {
                    var filterDefinition = Builders<AddAuthor>.Filter.Empty;
                    var Books = BCollection.Find(filterDefinition).ToList();
                    dataGridViewAuthor.DataSource = Books;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accourd while loading data to update" + ex.Message, "Error Catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //Load data to grid view
        private void refreshPublisherData()
        {
            var filterDefinition = Builders<AddAuthor>.Filter.Empty;
            var Books = BCollection.Find(filterDefinition).ToList();
            dataGridViewAuthor.DataSource = Books;
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
            refreshPublisherData();
        }
        //check author before delelting  if it has linke books
        /*        public bool checkAuthorBeforeDelete()
                {*/
        /*
                    try
                    {
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("CHECK_AUTHOR_BEFORE_DELETE", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@AUTHOR_ID", ID);
                                if (con.State != ConnectionState.Open)
                                    con.Open();
                                DataTable dtBook = new DataTable();

                                SqlDataReader dr = cmd.ExecuteReader();


                                if (dr.HasRows)
                                {
                                    //can't delete
                                    MessageBox.Show("You can't delete this Author it has a book in the library! ", "Can't Complete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return false;
                                }
                                else
                                {
                                    //can delete
                                    return true;
                                }
                            }   
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error accured while checkign if author can be deleted \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
            }*/

    }
    }



