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
            //var title = BCollection.Find(x => x.TITLE == txtSearch.Text.ToString());

/*                var mongoBuilder = Builders<AddBook1>.Filter;
                var filter = mongoBuilder.Eq(y => y.TITLE, txtSearch.text.ToString());*/

            var filtirDefinition = Builders<AddBook1>.Filter.Eq(a => a.TITLE, txtSearch.text.ToString());
            var Book = BCollection.Find(filtirDefinition).ToList();
            DataBook.DataSource = Book.ToList();
            LoadBookData();


            //get the values only 
            //string booktitle = title.First().TITLE;

            //load user into to Userinfo.cs

            /*            BCollection.Find(x => x.AUTHOR_ID == txtSearch.Text.Trim().ToString());
                        BCollection.Find(x => x.PUBLISHER_ID == txtSearch.Text.Trim().ToString());
                        BCollection.Find(x => x.CAT_ID == txtSearch.Text.Trim().ToString());*/

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            DataBook.Rows.Clear();
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
