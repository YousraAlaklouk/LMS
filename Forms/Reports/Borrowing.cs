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

namespace LibraryManegement.Forms.Reports
{
    public partial class Borrowing : Form
    {
        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<Borrow> BCollection;
        public Borrowing()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            BCollection = mongodb.GetCollection<Borrow>("BORROWING");
            refreshData();

        }
        //filitering borrow history based on dates
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (radioReturned.Checked)
            {

            
            try
            {

                    string txt = "RETURNED";

                    var filtirDefinition = Builders<Borrow>.Filter.Eq(a => a.STATUES, txt.ToString());
                    var borrow = BCollection.Find(filtirDefinition).ToList();
                    dataGridView.DataSource = borrow;

                }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while filitring borrow history data \n " + ex.Message, "Error catched",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            }
            else if (radioNOT.Checked )
            {
                try
                {
                    string txt = "NOT";

                    var filtirDefinition = Builders<Borrow>.Filter.Eq(a => a.STATUES, txt.ToString());
                    var borrow = BCollection.Find(filtirDefinition).ToList();
                    dataGridView.DataSource = borrow;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while filitring borrow history data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                try
                {

                    refreshData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while filitring borrow history data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
                        this.Close();
        }

        //min-max
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
        private void refreshData()
        {
            var filterDefinition = Builders<Borrow>.Filter.Empty;
            var borrow = BCollection.Find(filterDefinition).ToList();
            dataGridView.DataSource = borrow;
        }

        private void Borrowing_Load(object sender, EventArgs e)
        {
            radioAll.Checked = true;
            radioNOT.Checked=false;
            radioReturned.Checked=false;
        }
    }

    [BsonIgnoreExtraElements]
    internal class Borrow
    {
        public ObjectId Id { get; set; }
        public ObjectId BOOK_ID{ get; set; }
        public ObjectId USER_ID{ get; set; }
        public string BORROW_DATE { get; set; }
        public string RETURN_DATE { get; set; }
        public string LATE_DATE { get; set; }
        public string STATUES { get; set; }
        public string LOAN_DAYS { get; set; }
    }

}
