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
    public partial class Penalty : Form
    {
        MongoClient client;
        IMongoDatabase mongodb;
        IMongoCollection<Penallty> BCollection;
        public Penalty()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            mongodb = client.GetDatabase("LibraryManagement");
            BCollection = mongodb.GetCollection<Penallty>("PENALTY");
            refreshData();
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
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (rdiobtnPaid.Checked || rdiobtnUnpaid.Checked)
            {

                try
                {

                    if (rdiobtnPaid.Checked)

                    {


                    }
                    if (rdiobtnUnpaid.Checked)
                    {
                    }
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while filitring borrow history data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                

         
        }

        private void lblCleardata_Click(object sender, EventArgs e)
        {
            rdiobtnPaid.Checked = false;
            rdiobtnUnpaid.Checked = false;
        }
        private void refreshData()
        {
            var filterDefinition = Builders<Penallty>.Filter.Empty;
            var penalty = BCollection.Find(filterDefinition).ToList();
            dataGridView.DataSource = penalty;
        }
    }

    [BsonIgnoreExtraElements]
    internal class Penallty
    {
        public ObjectId Id { get; set; }
        public string BORROWING_ID { get; set; }
        public int DAYS { get; set; }
        public int AMOUNT { get; set; }
        public int CHANGE { get; set; }
        public string CONDITION { get; set; }

    }
}
