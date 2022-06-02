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
            var filter = builder.Regex(a =>a.TITLE, queryExpr); ;
            var matchedDocuments = BCollection.FindAsync(filter);


/*            DataBook.DataSource = matchedDocuments;
*/
            //get the values only 
            //string booktitle = title.First().TITLE;

            //load user into to Userinfo.cs


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
