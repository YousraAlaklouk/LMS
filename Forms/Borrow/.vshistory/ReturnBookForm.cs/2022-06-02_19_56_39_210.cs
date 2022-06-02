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
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using LibraryManegement.Forms.Books;

namespace LibraryManegement.Forms
{
    public partial class ReturnBookForm : Form
    {
        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<Borrow2> BorrowCollection;
        private double loan_days;
        private double fine;
        private int book_quantity;
        private int book_ID;
        private int borrow_ID;
        public ReturnBookForm()
        {
            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            IMongoCollection<Borrow2> BorrowCollection;
 = mongodb.GetCollection<Borrow2>("BORROWING");
            InitializeComponent();
            refreshBorrowedHistory();
        }

        //Show data to combo box
        public void refreshBorrowedHistory()
        {
            try
            {
                //lol
                    string txt = "NOT RETURNED"; 
                    var filtirDefinition = Builders<Borrow2>.Filter.Eq(a => a.STATUES, txt);
                    var borrow = BCollection.Find(filtirDefinition).ToList();
                    dataBook.DataSource = borrow;
                        List<BsonDocument> results = BCollection.Find(new BsonDocument()).ToList();

                /*var x = BCollection.
                var lookup = new BsonDocument("$lookup",
                 new BsonDocument("from", "")*/
/*
                var query = from p in BCollection.AsQueryable()
                            where p.Id.Equals(p.name)
                            join o in others.AsQueryable() on p.id equals o.entity into joined
                            select new { p.id, p.name, other = joined.First() }
                            into p
                            orderby p.other.name descending
                            select p;*/



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Borrowed books to combo box\n " + ex.Message, "Error catched");
            }
        }
        
        //return book
        private void btnReturn_Click(object sender, EventArgs e)
        {  /*
            if(cmboxBookToReturn.Text != string.Empty) {
            DialogResult rslt = MessageBox.Show("Are you sure you want to return this book?", "Returning confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    borrow_ID = (int)cmboxBookToReturn.SelectedValue;
                    try
                    {
    *//*                    // RETURNING BOOK
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE_BORROW", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ID", cmboxBookToReturn.SelectedValue);
                                cmd.Parameters.AddWithValue("@STATUES", "RETURNED");
                                if (con.State != ConnectionState.Open)
                                    con.Open();
                                SqlDataReader dr = cmd.ExecuteReader();
                                UsersInfo.borrow_limit++;
                                UsersInfo.Borrowing_Limit_Update();

                            }
                        }
                        AddedSuccefulyDialog SuccForm = new AddedSuccefulyDialog();
                        SuccForm.lblTaskCompleted.Text = "Book Returned";
                        SuccForm.ShowDialog();*//*
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("While Returning Books an Error catched \n Contact Support \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    try
                    { //get book quantity
  *//*                      using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("GET_BOOK_QUANTITY", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                              
                                cmd.Parameters.AddWithValue("@BORROW_ID", borrow_ID);
                                if (con.State != ConnectionState.Open)
                                    con.Open();

                              
                                DataTable dtUser = new DataTable();

                                SqlDataReader sdr = cmd.ExecuteReader();

                                if (sdr.HasRows)
                                {
                                    dtUser.Load(sdr);

                                    DataRow userData = dtUser.Rows[0];
   
                                    book_quantity = Convert.ToInt32(userData["QUANTITY"].ToString());
                                    book_ID= Convert.ToInt32(userData["ID"].ToString());
                                    
                                }
                                else
                                {
                                    MessageBox.Show("You have no Book quantity found", "No quanity Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }*//*
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error accured while getting book quantity  \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
    *//*                    //update Book Quantity //book_quantity++;
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE_BOOK_QUANTITY", con))
                            {
                                ++book_quantity;

                                cmd.CommandType = CommandType.StoredProcedure;
                                
                                cmd.Parameters.AddWithValue("@BOOK_ID", book_ID);
                                cmd.Parameters.AddWithValue("@QUANTITY", book_quantity);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                            }
                        }*//*
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error accured while INCREASING book quantity  \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    try
                    { 
  *//*                      //check for panelty and add it if exists
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("CHECK_PENALTY", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@BORROW_ID", borrow_ID);
                                cmd.Parameters.AddWithValue("@USER_ID", UsersInfo.User_ID);
                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                DataTable dtRoles = new DataTable();

                                SqlDataReader dr = cmd.ExecuteReader();

                                dtRoles.Load(dr);

                                DataRow userData = dtRoles.Rows[0];
                                loan_days = Convert.ToDouble(userData["LOAN_DAYS"]);
                                if (loan_days > 0)
                                {
                                    fine = loan_days * 2;
                                   
                                    using (SqlConnection con1 = new SqlConnection(AppConnection.GetConnectionString()))
                                    {
                                        using (SqlCommand cmd1 = new SqlCommand("ADD_PENALTY", con1))
                                        {
                                            cmd1.CommandType = CommandType.StoredProcedure;
                                            cmd1.Parameters.AddWithValue("@BORROW_ID", cmboxBookToReturn.SelectedValue);
                                            cmd1.Parameters.AddWithValue("@DAYS", loan_days);
                                            cmd1.Parameters.AddWithValue("@AMOUNT", fine);
                                            cmd1.Parameters.AddWithValue("@CONDITION","unpaid");
                                            if (con1.State != ConnectionState.Open)
                                                con1.Open();

                                            cmd1.ExecuteNonQuery();
                                        }
                                    }
                                    DialogResult rslt1 = MessageBox.Show("you are late in" + loan_days + "days\n you have to pay: 2 lira per day \n total:" + fine + "\n Do you want To pay it now?", "You are Overdue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (rslt1 == DialogResult.Yes)
                                    {
                                        PaymentForm frm = new PaymentForm();
                                        frm.ShowDialog();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("You are free of any charges","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                }
                            }
                        }
                        this.Close();*//*

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("After Returning Books an Error catched \n Contact Support \n" + ex.Message + "\n" + ex.Source, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You havn't Borrowed any book latey", "No Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
       
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnBookForm_Load(object sender, EventArgs e)
        {
            refreshBorrowedHistory();
        }
        private void ReturnBookForm_Activated(object sender, EventArgs e)
        {
            refreshBorrowedHistory();
        }

    }

    [BsonIgnoreExtraElements]
    internal class Borrow2
    {
        public ObjectId Id { get; set; }
        public ObjectId BOOK_ID { get; set; }
        public ObjectId USER_ID { get; set; }
        public string BORROW_DATE { get; set; }
        public string RETURN_DATE { get; set; }
        public string LATE_DATE { get; set; }
        public string STATUES { get; set; }
        public string LOAN_DAYS { get; set; }
    }
}
