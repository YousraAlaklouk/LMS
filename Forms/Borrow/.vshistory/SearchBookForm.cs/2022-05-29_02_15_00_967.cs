
using LibraryManegement.General;
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
        public int Book_ID;
        public string title;
        public int book_quantity;
        public SearchBookForm()
        {
            InitializeComponent();
            loadBookData();
            
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
        //Search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
/*            try
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while Searching books \n " + ex.Message, "Error catched",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        //Borrowing a book button
        private void btnBorrowThis_Click(object sender, EventArgs e)
        {

            if (Book_ID <= 0)
            {
                MessageBox.Show("To Continue! \n First, Choose a Book. \n Then Try Again", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(book_quantity <= 0)
                {
                    MessageBox.Show("Sorry this book is not availble rightnow. \n Try Again after 10 days ", "Book Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // book is availble 
                {
                    
                    if (UsersInfo.Borrowing_Limit_Check())
                    {
                        DialogResult rslt = MessageBox.Show("Are you sure you want to Borrow   \n" + title + "\n", "Borrowing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rslt == DialogResult.Yes)
                        {
                            try
                            {   //update Book Quantity //book_quantity--;
                                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                                {
                                    using (SqlCommand cmd = new SqlCommand("UPDATE_BOOK_QUANTITY", con))
                                    {
                                        cmd.CommandType = CommandType.StoredProcedure;

                                        book_quantity--;
                                        cmd.Parameters.AddWithValue("@BOOK_ID", Book_ID);
                                        cmd.Parameters.AddWithValue("@QUANTITY", book_quantity);

                                        if (con.State != ConnectionState.Open)
                                            con.Open();

                                        cmd.ExecuteNonQuery();

                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error accured while DECREASING book quantity  \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            try
                            {
                                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
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
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error accured while borrowing a book \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have Already Reached the Borrowing limit \n", "Couldn't borrow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    


                }

            }*/

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
    /*        try
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("LOAD_BOOKS_DATA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        dataGridViewBook.DataSource = dtRoles;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading books data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
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
           title = dataGridViewBook.CurrentRow.Cells[0].Value.ToString();
           Book_ID = int.Parse(dataGridViewBook.CurrentRow.Cells[9].Value.ToString());
           book_quantity = int.Parse(dataGridViewBook.CurrentRow.Cells[7].Value.ToString());
            //check if book title is validd
            //Add to borrow table

        }

       
    }

}
