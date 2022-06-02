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
using LibraryManegement.Forms.Books;

namespace LibraryManegement
{
    public partial class AddBookForm : Form
    {
        MongoClient client;
        IMongoDatabase MDatabase;
        IMongoCollection<AddBook1> BCollection;

        public int ADD_OR_UPDATE;
        public string ID;
        public AddBookForm()
        {
            InitializeComponent();


            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            MDatabase = client.GetDatabase("LibraryManagement");
            BCollection = MDatabase.GetCollection<AddBook1>("BOOK");
        }

        /*------------------------------------Buttons----------------------------------------*/

        // add and Update book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (ADD_OR_UPDATE == 0)
            {
                try
                {

                    //Add book

                    AddBook1 Book = new AddBook1();
                    Book.TITLE = txtboxAddBookTitle.Text;
                    Book.AUTHOR_ID = Convert.ToInt32(cmbboxAuthorsName.SelectedValue);
                    Book.PUBLISHER_ID = Convert.ToInt32(cmbboxPublisherName.SelectedValue);
                    Book.CAT_ID = Convert.ToInt32(cmbboxCategory.SelectedValue);
                    Book.ISBN_NO = txtboxAddBookIsbn.Text.Trim();
                    Book.QUANTITY = Convert.ToInt32(txtboxQuantity.Text);
                    Book.EDITION = txtEdition.Text;
                    Book.EDITOR = txtEditor.Text;
                    Book.LANGUAGE = txtLang.Text;
                    Book.PAGECOUNT = Convert.ToInt32(txtCount.Text);
                    Book.DATE = Convert.ToString(BookDate.Value);
                    Book.RATE = bunifuRating1.Value;

                    BCollection.InsertOne(Book);
                    MessageBox.Show("New book  added");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("While Adding a book an Error catched" + ex.Message + ex.StackTrace, "Error Catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    lblAddBookName.Focus();
                }
            }
            //Update book button clicked
            else
            {
                try
                {
                    var updateDef = Builders<AddBook1>.Update
                                .Set("TITLE", txtboxAddBookTitle.Text.Trim())
                                .Set("AUTHOR_ID", cmbboxAuthorsName.SelectedValue)
                                .Set("PUBLISHER_ID", cmbboxPublisherName.SelectedValue)
                                .Set("CAT_ID", cmbboxCategory.SelectedValue)
                                .Set("ISBN_NO", Convert.ToInt16(txtboxAddBookIsbn.Text.Trim()))
                                .Set("QUANTITY", txtboxQuantity.Text.Trim())
                                .Set("EDITION", txtEdition.Text.Trim())
                                .Set("EDITOR", txtEditor.Text.Trim())
                                .Set("LANGUAGE", txtLang.Text.Trim())
                                .Set("PAGECOUNT", txtCount.Text.Trim())
                                .Set("DATE",Convert.ToString(BookDate.Value))
                                .Set("RATE", Convert.ToInt16(bunifuRating1.Value));

                    BCollection.UpdateOne(s => s.Id == ObjectId.Parse(ID), updateDef);
                }

                catch (Exception ex)
                { 


                MessageBox.Show("While updating a book an Error catched" + ex.Message, "Error Catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ClearTextBoxes(this.Controls);
                    lblAddBookName.Focus();
                }
            }
        }
    
    





        //add auhtor button
        private void btnAddAuthor1_Click(object sender, EventArgs e)
        {
            Form from_author = new AuthorForm();
            from_author.ShowDialog();
        }

        //add publisher button
        private void btnAddPublisher1_Click(object sender, EventArgs e)
        {
            Form from_publisher = new PublisherForm();
            from_publisher.ShowDialog();
        }

        //add category button
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Form from1 = new AddCategory();
            from1.Show();
        }

        //close - back
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Max-min
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


        
        //selecting a pic
        private void lnklblPickBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //open all type pictures
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if (result == DialogResult.OK)
            {
                picbocCover.Image = Image.FromFile(dia.FileName);
            }
        }
 
        //Clear controls
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
}
    

