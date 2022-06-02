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
using LibraryManegement.General;

namespace LibraryManegement
{
    public partial class BooksForm : Form
    {
        public int ID;
        AddBookForm frm_edit = new AddBookForm();
        public BooksForm()
        {
            InitializeComponent();
        }


        /*------------------------------------Buttons----------------------------------------*/

        //back - close
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

        //add buton
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AddBookForm frm2 = new AddBookForm();
            frm2.btnAddBook.ButtonText = "Add";
            frm2.ADD_OR_UPDATE = 0;
            frm2.ShowDialog();

        }

        //Delete book
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(frm_edit.txtboxAddBookTitle.Text == string.Empty) {
                MessageBox.Show("Selecet a row or cell of the book you want to delete \n ", " Deleting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBookBeforeDelete().Equals(true))
                {

                    DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly Are you sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rslt == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                            {
                                using (SqlCommand cmd = new SqlCommand("DELETE_BOOK", con))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@ID", ID);

                                    if (con.State != ConnectionState.Open)
                                        con.Open();

                                    cmd.ExecuteReader();

                                }
                            }
                            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                            SuccForm.lblTaskCompleted.Text = "Book Deleted";
                            SuccForm.ShowDialog();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("While Deleting a Book an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            ClearTextBoxes(this.Controls);
                        }
                    }
                }
                    
                
           
        }


        }

        //update book
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (frm_edit.txtboxAddBookTitle.Text  != string.Empty) {
                frm_edit.btnAddBook.ButtonText = "Update";
                frm_edit.ADD_OR_UPDATE = Convert.ToInt32(dataGridViewBook.CurrentRow.Cells[9].Value);
                frm_edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need to select a cell of the row you wants to edit","Updating Failed", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        /*------------------------------------Behind the scene Functions----------------------------------------*/
        //show data in Update form 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridViewBook.CurrentRow.Cells[2].Value;
            MemoryStream mems = new MemoryStream(img);


            ID = Convert.ToInt32(dataGridViewBook.CurrentRow.Cells[9].Value);
            frm_edit.ID = Convert.ToInt32(dataGridViewBook.CurrentRow.Cells[9].Value);
            frm_edit.txtboxAddBookTitle.Text = dataGridViewBook.CurrentRow.Cells[0].Value.ToString();
            frm_edit.cmbboxAuthorsName.Text = dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
            frm_edit.cmbboxPublisherName.Text = dataGridViewBook.CurrentRow.Cells[5].Value.ToString();
            frm_edit.bunifuRating1.Text = dataGridViewBook.CurrentRow.Cells[3].Value.ToString();
            frm_edit.cmbboxCategory.Text = dataGridViewBook.CurrentRow.Cells[4].Value.ToString();
            frm_edit.txtboxAddBookIsbn.Text = dataGridViewBook.CurrentRow.Cells[6].Value.ToString();
            frm_edit.txtboxQuantity.Text = dataGridViewBook.CurrentRow.Cells[7].Value.ToString();
            frm_edit.picbocCover.Image = Image.FromStream(mems);
            frm_edit.BookDate.Value = Convert.ToDateTime(dataGridViewBook.CurrentRow.Cells[8].Value);


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
        //load books data
        private void BooksForm_Activated(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            try
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
            }catch(Exception ex) {
                MessageBox.Show("An error accured while loading book data \n "+ex.Message,"Error catched");
            }
        }
       //check BOOK before delelting if it has linke books
        public bool checkBookBeforeDelete()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("CHECK_BOOK_BEFORE_DELETE", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@BOOK_ID", ID);
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        DataTable dtBook = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            //can't delete
                            MessageBox.Show("You can't delete this book its had been borrowed before! \nInstead, you can update the book Quantity", "Can't Complete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return false;                           
                        }
                        else {
                            //cann delete
                            return true;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while checking if a book can be deleted \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }
}
