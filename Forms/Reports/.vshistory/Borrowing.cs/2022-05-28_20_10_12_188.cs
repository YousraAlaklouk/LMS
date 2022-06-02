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

namespace LibraryManegement.Forms.Reports
{
    public partial class Borrowing : Form
    {
        public Borrowing()
        {
            InitializeComponent();
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

    }
}
