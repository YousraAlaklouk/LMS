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
    public partial class BooksForm : Form
    {
        MongoClient client;
        IMongoDatabase MDatabase;
        IMongoCollection<AddBook1> BCollection;

        public int ID;
        AddBookForm frm_edit = new AddBookForm();
        public BooksForm()
        {
            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            MDatabase = client.GetDatabase("LibraryManagement");
            BCollection = MDatabase.GetCollection<AddBook1>("BOOK");
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
            if (frm_edit.txtboxAddBookTitle.Text == string.Empty)
            {
                MessageBox.Show("Selecet a row or cell of the book you want to delete \n ", " Deleting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly Are you sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    string isbn = dataGridViewBook.CurrentCell.ToString();
                    try
                    {
                        var filterDefinition = Builders<AddBook1>.Filter.Eq(a => a.ISBN_NO, isbn);
                        BCollection.DeleteOne(filterDefinition);

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

        //update book
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (frm_edit.txtboxAddBookTitle.Text != string.Empty)
            {
                frm_edit.btnAddBook.ButtonText = "Update";
                frm_edit.ADD_OR_UPDATE = Convert.ToInt32(dataGridViewBook.CurrentRow.Cells[9].Value);
                frm_edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need to select a cell of the row you wants to edit", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*------------------------------------Behind the scene Functions----------------------------------------*/
        //show data in Update form 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
/*            if (dataGridViewBook.Rows.Count > 0)
            {
                ID = dataGridViewBook.CurrentRow.Cells[0].Value.ToString();
                //username = dataGridViewUser.CurrentRow.Cells[1].Value.ToString();
                txtboxUserName.Text = dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
                txtboxPassword.Text = dataGridViewBook.CurrentRow.Cells[2].Value.ToString();
                cmbboxUserRole.Text = dataGridViewBook.CurrentRow.Cells[3].Value.ToString();
                checkboxActivation.Checked = Convert.ToBoolean(dataGridViewBook.CurrentRow.Cells[4].Value);

            }
            else
            {
                MessageBox.Show("there is not Data selected from the Data table. \n Please Selelct Data first then try Again.");
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
        //load books data
        private void BooksForm_Activated(object sender, EventArgs e)
        {


        }


        private void LoadUserData()
        {
            try
            {
                /*//way 1
                var filterDefintion = Builders<Users1>.Filter.Empty;
                var users = UserCollection.Find(filterDefintion).ToList();
                dataGridViewUser.DataSource = users;

                //way 2 
                List<Users1> list = UserCollection.AsQueryable().ToList<Users1>();
                dataGridViewUser.DataSource = list;*/

                // way 3 general functions               
                var recs = Program.db.LoadRecord<AddBook1>("BOOK");
                dataGridViewBook.DataSource = recs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Users data \n " + ex.Message, "UserForm - Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
            LoadUserData();
        }
    }
}
