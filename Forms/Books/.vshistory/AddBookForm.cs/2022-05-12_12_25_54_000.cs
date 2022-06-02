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
    public partial class AddBookForm : Form
    {
        public int ADD_OR_UPDATE, ID;
        public AddBookForm()
        {
            InitializeComponent();
            refreshdataAuthor();
            refreshdataPublisher();
            refreshdataCategory();
        }

        /*------------------------------------Buttons----------------------------------------*/

        // add and Update book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //Add book button clicked
            if (ADD_OR_UPDATE == 0)
            {
                if (IsValid() <= 0)
                {


                    //converting the pic to binray
                    MemoryStream mem = new MemoryStream();
                    picbocCover.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _picbocCover = mem.ToArray();

                    try
                    {   //Add book
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("ADD_BOOK", con))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@AUTHOR_ID", cmbboxAuthorsName.SelectedValue);
                                cmd.Parameters.AddWithValue("@PUBLISHER_ID", cmbboxPublisherName.SelectedValue);
                                cmd.Parameters.AddWithValue("@CAT_ID", cmbboxCategory.SelectedValue);
                                cmd.Parameters.AddWithValue("@TITLE", txtboxAddBookTitle.Text);
                                cmd.Parameters.AddWithValue("@ISBN_NO", txtboxAddBookIsbn.Text);
                                cmd.Parameters.AddWithValue("@CATEGORY", cmbboxCategory.Text);
                                cmd.Parameters.AddWithValue("@COVER", _picbocCover);
                                cmd.Parameters.AddWithValue("@RATE", bunifuRating1.Value);
                                cmd.Parameters.AddWithValue("@QUANTITY", int.Parse(txtboxQuantity.Text));
                                cmd.Parameters.AddWithValue("@DATE", BookDate.Value);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                SuccForm.lblTaskCompleted.Text = "Book Added";
                                SuccForm.ShowDialog();
                                ClearTextBoxes(this.Controls);
                            }
                        }
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
            }
            //Update book button clicked
            else
            {
                if (IsValid() <= 0)
                {
                    //converting the pic to binray
                    MemoryStream mem = new MemoryStream();
                    picbocCover.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _picbocCover = mem.ToArray();

                    try
                    {
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE_BOOK", con))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@ID", ID);
                                cmd.Parameters.AddWithValue("@AUTHOR_ID", cmbboxAuthorsName.SelectedValue);
                                cmd.Parameters.AddWithValue("@PUBLISHER_ID", cmbboxPublisherName.SelectedValue);
                                cmd.Parameters.AddWithValue("@CAT_ID", cmbboxCategory.SelectedValue);
                                cmd.Parameters.AddWithValue("@TITLE", txtboxAddBookTitle.Text);
                                cmd.Parameters.AddWithValue("@ISBN_NO", txtboxAddBookIsbn.Text);
                                cmd.Parameters.AddWithValue("@CATEGORY", cmbboxCategory.Text);
                                cmd.Parameters.AddWithValue("@COVER", _picbocCover);
                                cmd.Parameters.AddWithValue("@RATE", bunifuRating1.Value);
                                cmd.Parameters.AddWithValue("@QUANTITY", int.Parse(txtboxQuantity.Text));
                                cmd.Parameters.AddWithValue("@DATE", BookDate.Value);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                                SuccForm.lblTaskCompleted.Text = "Book Updated";
                                SuccForm.ShowDialog();
                            }
                        }
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
        /*------------------------------------Behind the scene ----------------------------------------*/
        // Is data Valid
        private int IsValid()
        {
            if (cmbboxAuthorsName.Text == string.Empty)
            {

                MessageBox.Show("Select an Author Please!", "Author Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbboxAuthorsName.Focus();
                return 2;
            }
            if (cmbboxPublisherName.Text == string.Empty)
            {
                MessageBox.Show("Publisher  IS REQUIRED", "Publisher Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbboxPublisherName.Focus();
                return 2;
            }
            if (txtboxAddBookTitle.Text == string.Empty)
            {
                MessageBox.Show("Book title  IS REQUIRED", "Book Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxAddBookTitle.Focus();
                return 2;

            }
            if (txtboxAddBookIsbn.Text == string.Empty)
            {
                MessageBox.Show("Book ISBN IS REQUIRED", "ISBN number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxAddBookIsbn.Focus();
                return 2;

            }
            if (txtboxQuantity.Text == string.Empty)
            {
                MessageBox.Show("Quantity can't be empty if book is not Available set it to 0", "Book Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxQuantity.Focus();
                return 2;
            }
            else
            {
                if (ADD_OR_UPDATE == 0)
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM BOOK WHERE ([TITLE] = @TITLE)", con))
                        {
                            check_User_Name.Parameters.AddWithValue("@TITLE", txtboxAddBookTitle.Text);
                            if (con.State != ConnectionState.Open)
                                con.Open();
                            int UserExist = (int)check_User_Name.ExecuteScalar(); // if already exists returns 1 

                            if (UserExist > 0)
                            {
                                MessageBox.Show("Book Already Exists. ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
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
                    return 0;
                }
            }

        }


        //get author combo dorp list from database
        public void refreshdataAuthor()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("COMBO_AUTHOR_BOOK", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        cmbboxAuthorsName.DataSource = dtRoles;
                        cmbboxAuthorsName.DisplayMember = "FULLNAME";
                        cmbboxAuthorsName.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Publisher data to combo boc" + ex.Message, "Error catched");
            }
        }
        //get publisher combo dorp list from database
        public void refreshdataPublisher()
        {
            try
            {


                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("COMBO_PUBLISHER_BOOK", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        cmbboxPublisherName.DataSource = dtRoles;
                        cmbboxPublisherName.DisplayMember = "NAME";
                        cmbboxPublisherName.ValueMember = "ID";
                    }
                }
            }catch(Exception ex) {
                MessageBox.Show("An error accured while loading Publisher data to combo boc"+ex.Message,"Error catched");
                }
        }
        //get Categorys 
        private void refreshdataCategory()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("COMBO_CAT_BOOK", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        cmbboxCategory.DataSource = dtRoles;
                        cmbboxCategory.DisplayMember = "CATEGORY";
                        cmbboxCategory.ValueMember = "ID";
                    }
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }
        //allow only int for quantity
        private void txtboxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void AddBookForm_Activated(object sender, EventArgs e)
        {
            refreshdataAuthor();
            refreshdataCategory();
            refreshdataPublisher();
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
    

