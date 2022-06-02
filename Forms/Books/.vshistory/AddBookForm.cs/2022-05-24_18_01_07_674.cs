using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
/*using LibraryManegement.General;
*/using MongoDB.Bson;
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

/*        public int ADD_OR_UPDATE, ID;
*/        public AddBookForm()
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


                    try
                    {   //Add book

                        AddBook1 Book = new AddBook1();
                        Book.Title = txtboxAddBookTitle.Text;
                        Book.Author = cmbboxAuthorsName.SelectedText;
                        Book.Publisher = cmbboxPublisherName.SelectedText;
                        Book.Category = cmbboxCategory.SelectedText;
                        Book.ISBN = txtboxAddBookIsbn.Text;
                        Book.Quantity = Convert.ToInt32(txtboxQuantity.Text);
                        Book.Edition = txtEdition.Text;
                        Book.Editor = txtEditor.Text;
                        Book.Language = txtLang.Text;
                        Book.PageCount = txtCount.Text;
                        Book.Publish = BookDate.Value;
                        Book.Rate = bunifuRating1.Value;
                    
                        BCollection.InsertOne(Book);
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
    

