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
    public partial class AddCategory : Form
    {
        MongoClient client;
        IMongoDatabase MDatabase;
        IMongoCollection<AddCategory1> BCollection;

        public AddCategory()
        {
            InitializeComponent();


            client = new MongoClient("mongodb+srv://Yousra:aVb6GICGnO2LtKTk@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            MDatabase = client.GetDatabase("LibraryManagement");
            BCollection = MDatabase.GetCollection<AddCategory1>("CATEGORY");
        }
        /*------------------------------------Buttons----------------------------------------*/
        //Add to category
        private void btnAddCategory_Click(object sender, EventArgs e)
        {

            AddCategory1 cat = new AddCategory1();
            cat.Category = txtboxAddCat.Text;
            BCollection.InsertOne(cat);
            MessageBox.Show("New Category  added");
        }
        //Close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*------------------------------------Behind the scene Functions----------------------------------------*/
        //Check if exists and not empty

        
        //clear box
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
