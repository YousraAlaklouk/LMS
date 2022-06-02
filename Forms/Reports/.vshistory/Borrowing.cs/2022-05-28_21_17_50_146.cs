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
            client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            BCollection = mongodb.GetCollection<Borrow>("BORROWING");
        }
        //filitering borrow history based on dates
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while filitring borrow history data \n " + ex.Message, "Error catched",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

    }

    [BsonIgnoreExtraElements]
    internal class Borrow
    {
        public ObjectId Id { get; set; }
        public string BOOK_ID{ get; set; }
        public string USER_ID{ get; set; }
        public string BORROW_DATE { get; set; }
        public bool RETURN_DATE { get; set; }
        public string LATE_DATE { get; set; }
        public string STATUES { get; set; }
        public string LOAN_DAYS { get; set; }
    }

}
