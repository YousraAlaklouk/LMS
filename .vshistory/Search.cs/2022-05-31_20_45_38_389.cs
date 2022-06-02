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
using System.Text.RegularExpressions;

namespace LibraryManegement
{
    public partial class Search : Form
    {
        MongoClient client;
        IMongoDatabase MDatabase;
        IMongoCollection<AddBook1> BCollection;
        public Search()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            MDatabase = client.GetDatabase("LibraryManagement");
            BCollection = MDatabase.GetCollection<AddBook1>("BOOK");
            LoadBookData();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            var queryExpr = new BsonRegularExpression(new Regex(search, RegexOptions.None));

            var builder = Builders<AddBook1>.Filter;
            if (comboBox1.SelectedIndex == 1)
            {
                var filter = builder.Regex(a => a.Id, queryExpr); 
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                var filter = builder.Regex(a => a.AUTHOR_ID, queryExpr);
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                var filter = builder.Regex(a => a.PUBLISHER_ID, queryExpr); 
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                var filter = builder.Regex(a => a.CAT_ID, queryExpr); 
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 5)
            {

                var filter = builder.Regex(a => a.TITLE, queryExpr); 
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;


            }
            else if (comboBox1.SelectedIndex == 6)

            {
                var filter = builder.Regex(a => a.ISBN_NO, queryExpr); 
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 7)

            {
                var filter = builder.Regex(a => a.RATE, queryExpr); 
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 8)

            {
                var filter = builder.Regex(a => a.QUANTITY, queryExpr);
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 9)

            {
                var filter = builder.Regex(a => a.DATE, queryExpr);
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 10)

            {
                var filter = builder.Regex(a => a.EDITION, queryExpr);
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 11)

            {
                var filter = builder.Regex(a => a.EDITORS, queryExpr);
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 12)

            {
                var filter = builder.Regex(a => a.LANGUAGE, queryExpr);
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
            else if (comboBox1.SelectedIndex == 13)

            {
                var filter = builder.Regex(a => a.PAGECOUNT, queryExpr);
                var matchedDocuments = BCollection.FindSync(filter).ToList();
                DataBook.DataSource = matchedDocuments;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadBookData();
        }
        private void LoadBookData()
        {
            try
            {
         
                var recs = Program.db.LoadRecord<AddBook1>("BOOK");
                DataBook.DataSource = recs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading Users data \n " + ex.Message, "UserForm - Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
