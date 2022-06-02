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
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson.IO;
using MongoDB.Driver.GeoJsonObjectModel;
namespace LibraryManegement
{
    public partial class AddCategory : Form
    {

        public AddCategory()
        {
            InitializeComponent();
        }
        /*------------------------------------Buttons----------------------------------------*/
        //Add to category
        private void btnAddCategory_Click(object sender, EventArgs e)
        {


            
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
