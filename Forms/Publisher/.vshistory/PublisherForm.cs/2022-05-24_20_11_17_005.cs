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
        public int ID;
        public string username;

        public PublisherForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            MDatabase = client.GetDatabase("LibraryManagement");
            BCollection = MDatabase.GetCollection<PublisherAdd>("PUBLISHER");
        }

/* --------------------------Buttons-----------------------------------------------*/
        //add Publisher
        private void btnAddPublisher_Click(object sender, EventArgs e)
        {

            PublisherAdd publisher = new PublisherAdd();
            publisher.PublisherName = txtboxPublisherName.Text;
            publisher.Email = txtboxPublisherEmail.Text;
            publisher.Year = txtboxpublisherYearOffoundation.Text;
            publisher.Address = txtboxPublisherAddress.Text;
            BCollection.InsertOne(publisher);

            MessageBox.Show("New Publisher added");



            
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
                if (checkPublisherBeforeDelete().Equals(true))
                {
                    //can delete
                    DialogResult rslt = MessageBox.Show("Record Will be Deleted Paremntly Are you sure you want to delete?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rslt == DialogResult.Yes)
                    {
                        try
                        {
                            var filterDefinition = Builders<PublisherAdd>.Filter.Eq(a => a.Email, dataGridViewPublisher.CurrentCell.RowIndex.ToString());
                            BCollection.DeleteOne(filterDefinition);

                            AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                            SuccForm.lblTaskCompleted.Text = "Publisher Deleted";
                            SuccForm.ShowDialog();

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
        }
        //Update Publisher
        private void btnUpdatePublisher_Click(object sender, EventArgs e)
        {

  /*          if (txtboxPublisherName.Text == string.Empty || txtboxPublisherAddress.Text == string.Empty)
            {
                MessageBox.Show("You Can't leave the Name and Email empty","Updaing Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE_PUBLISHER", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@OLDNAME", this.username);
                            cmd.Parameters.AddWithValue("@NAME", txtboxPublisherName.Text);
                            cmd.Parameters.AddWithValue("@ADDRESS", txtboxPublisherAddress.Text);
                            cmd.Parameters.AddWithValue("@FOUNDATION_YEAR", int.Parse(txtboxpublisherYearOffoundation.Text));
                            cmd.Parameters.AddWithValue("@EMAIL", txtboxPublisherEmail.Text);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            SqlDataReader dr = cmd.ExecuteReader();

                        }

                    }
                    AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                    SuccForm.lblTaskCompleted.Text = "Updated Successfully";
                    SuccForm.ShowDialog();
                }
                catch (Exception ex) {
                    MessageBox.Show("While Updating "+ username +"an Error catched \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    ClearTextBoxes(this.Controls);
                }
            }*/
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
          /*  ClearTextBoxes(this.Controls);
            try
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("LOAD_PUBLISHERS_DATA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        DataTable dtRoles = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRoles.Load(dr);

                        dataGridViewPublisher.DataSource = dtRoles;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading publisher  data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        //show the data to update
        private void dataGridViewPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPublisher.Rows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridViewPublisher.CurrentRow.Cells[0].Value);
                username = dataGridViewPublisher.CurrentRow.Cells[1].Value.ToString();
                txtboxPublisherName.Text = dataGridViewPublisher.CurrentRow.Cells[1].Value.ToString();
                txtboxPublisherAddress.Text = dataGridViewPublisher.CurrentRow.Cells[2].Value.ToString();
                txtboxpublisherYearOffoundation.Text = dataGridViewPublisher.CurrentRow.Cells[3].Value.ToString();
                txtboxPublisherEmail.Text = dataGridViewPublisher.CurrentRow.Cells[4].Value.ToString();
            }
        }
        //Publisher doesn't exists and data is valid
  /*      private int IsValid()
        {
            if (txtboxPublisherName.Text != string.Empty && txtboxPublisherEmail.Text != string.Empty)
            {
                try
                {


                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM PUBLISHER WHERE ([NAME] = @NAME)", con))
                        {
                            check_User_Name.Parameters.AddWithValue("@NAME", txtboxPublisherName.Text);
                            if (con.State != ConnectionState.Open)
                                con.Open();
                            int UserExist = (int)check_User_Name.ExecuteScalar(); // if already exists returns 1 

                            if (UserExist > 0)
                            {
                                MessageBox.Show("Publisher Already Exists. ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
                                return 1;
                            }
                            else
                            {
                                return UserExist;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while checking if publisher exsits or not \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }
            else
            {
                MessageBox.Show("Publisher Name and Contact Can't Be Empty. Check it and Try Again!", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return 1;
            }
        }*/
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
        //check PUBLISHER before delelting  if it has linke books
        public bool checkPublisherBeforeDelete()
        {
     /*       try
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("CHECK_PUBLISHER_BEFORE_DELETE", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PUBLISHER_ID", ID);
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        DataTable dtBook = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            // can't delete
                            MessageBox.Show("You can't delete this publisher it has a book in the library! ", "Can't Complete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                MessageBox.Show("An error accured while checking if a publisher can be deleted \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
*/
        }



    }
}
