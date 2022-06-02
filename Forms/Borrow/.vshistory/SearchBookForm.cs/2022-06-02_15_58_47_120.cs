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
    public partial class SearchBookForm : Form
    {
        public string Book_ID;
        public string title;
        public int book_quantity;

        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<AddBook1> BookCollection;
        IMongoCollection<BORROWMODEL> BorrowCollection;
        IMongoCollection<User1> UserCollection;
        public SearchBookForm()
        {
            InitializeComponent();
            loadBookData();
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            BookCollection = mongodb.GetCollection<AddBook1>("BOOK");
            UserCollection = mongodb.GetCollection<User1>("USERS");
            BorrowCollection = mongodb.GetCollection<BORROWMODEL>("BORROWING");

        }

        /*-------------------------Buttons--------------------------------*/
        //Close
        private void picboxClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        //min max
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
        //Search button-------------------------------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                /* using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                 {
                     using (SqlCommand cmd = new SqlCommand("SEARCH_LOAD_BOOKS_DATA", con))
                     {
                         cmd.CommandType = CommandType.StoredProcedure;

                         cmd.Parameters.AddWithValue("TITLE", txtboxSearchBook.Text.Trim());
                         if (con.State != ConnectionState.Open)
                             con.Open();
                         DataTable dtBook = new DataTable();

                         SqlDataReader dr = cmd.ExecuteReader();

                         if (dr.HasRows)
                         {
                             dtBook.Load(dr);
                             dataGridViewBook.DataSource = dtBook;
                         }
                         else
                         {
                             MessageBox.Show("Book is not available in the Library yet", "No Book Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         }
                     }
                 }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while Searching books \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Borrowing a book button----------------------------------------------------------------------------
        private void btnBorrowThis_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Book_ID))
            {
                MessageBox.Show("To Continue! \n First, Choose a Book. \n Then Try Again", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (book_quantity <= 0)
                {
                    MessageBox.Show("Sorry this book is not availble rightnow. \n Try Again after a couple of days ", "Book Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // book is availble 
                {

                    /*if (UsersInfo.Borrowing_Limit_Check())
                    {*/
                    DialogResult rslt = MessageBox.Show("Are you sure you want to Borrow   \n" + title + "\n", "Borrowing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rslt == DialogResult.Yes)
                    {
                        try
                        {   //update Book Quantity //book_quantity--;
                            //deacrase book quantitty
                            book_quantity--;
                            var updateDef = Builders<AddBook1>.Update.Set(a => a.QUANTITY, Convert.ToInt32(book_quantity));
                            BookCollection.UpdateOne(s => s._id == ObjectId.Parse(Book_ID), updateDef);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error accured while DECREASING book quantity  \n " + ex.Message, "Search(borrow) book form -Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        try
                        {
                            //addborrow

                            try
                            {
                                DateTime now = DateTime.Now;
                                Program.db.InsertRecord("BORROWING",
                                new BORROWMODEL
                                {
                                    BOOK_ID = ObjectId.Parse(Book_ID),
                                    USER_ID = ObjectId.Parse(UsersInfo.User_ID),
                                    BORROW_DATE = now.ToString(),
                                    RETURN_DATE = now.AddDays(10).ToString(),
                                    STATUES = "NOT RETURNED",
                                        //  LATE_DATE =
                                        //  LOAD DAYS = 
                                });
                                AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                SuccForm.lblTaskCompleted.Text = " Book Borrowed. \n Enjoy Reading it.  ";
                                SuccForm.ShowDialog();
                                /*this.Close();*/
                                loadBookData();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("While borrowing a book an Error catched \n" + ex.Message + "\n" + ex.StackTrace, " Borrowing book Window  - Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {

                            }


                            /* using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                             {
                                 using (SqlCommand cmd = new SqlCommand("ADD_BORROWER", con))
                                 {
                                     cmd.CommandType = CommandType.StoredProcedure;


                                     cmd.Parameters.AddWithValue("@BOOK_ID", Book_ID);
                                     // cmd.Parameters.AddWithValue("@BOOK_TITLE", title);
                                     cmd.Parameters.AddWithValue("@USER_ID", UsersInfo.User_ID);
                                     cmd.Parameters.AddWithValue("@STATUES", "NOT RETURNED");

                                     if (con.State != ConnectionState.Open)
                                         con.Open();

                                     cmd.ExecuteNonQuery();

                                     UsersInfo.borrow_limit--;
                                     UsersInfo.Borrowing_Limit_Update();

                                     AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                     SuccForm.lblTaskCompleted.Text = " Book Borrowed \n";
                                     SuccForm.ShowDialog();
                                     this.Close();

                                 }
                             }*/
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error accured while borrowing a book \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        //}
                    }
                    else
                    {
                        MessageBox.Show("You Have Already Reached the Borrowing limit \n", "Couldn't borrow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }
        /*-------------------------Behind het scene functions-------------------------*/
        //To load books when form is open
        private void BorrowBookForm_Activated(object sender, EventArgs e)
        {

            loadBookData();

        }
        //Load book data
        public void loadBookData()
        {
            try
            {
                /*var filterDefinition = Builders<AddBook1>.Filter.Empty;
                var book = BookCollection.Find(filterDefinition).ToList();
                dataGridViewBook.DataSource = book;*/

                var recs = Program.db.LoadRecord<AddBook1>("BOOK");
                dataGridViewBook.DataSource = recs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading books data \n " + ex.Message, "Search Book Form - Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //clear form
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
        //choosing which book to borrow
        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //frm1.txtboxBookTitle.Text =  dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
            Book_ID = dataGridViewBook.CurrentRow.Cells[0].Value.ToString();
            title = dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
            book_quantity = int.Parse(dataGridViewBook.CurrentRow.Cells[6].Value.ToString());
            //check if book title is validd
            //Add to borrow table

        }
    }
    [BsonIgnoreExtraElements]
    internal class BORROWMODEL
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public ObjectId BOOK_ID { get; set; }

        public ObjectId USER_ID { get; set; }

        public string BORROW_DATE { get; set; }
        public string RETURN_DATE { get; set; }

        public string LATE_DATE { get; set; }
        public string STATUES { get; set; }

        public string LOAD_DAYS { get; set; }

    }


    [BsonIgnoreExtraElements]
    internal class AddBook1
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string TITLE { get; set; }
        public string AUTHOR_ID { get; set; }
        public string PUBLISHER_ID { get; set; }
        public string CAT_ID { get; set; }

        public string ISBN_NO { get; set; }
        public int QUANTITY { get; set; }
        public string EDITION { get; set; }
        public string EDITORS { get; set; }
        public string LANGUAGE { get; set; }

        public int PAGECOUNT { get; set; }
        public string DATE { get; set; }

        public int RATE { get; set; }
        //        public string Cover { get; set; }

    }
}