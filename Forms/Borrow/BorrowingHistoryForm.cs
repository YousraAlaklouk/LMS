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

namespace LibraryManegement.Forms
{
    public partial class BorrowingHistoryForm : Form
    {
        public BorrowingHistoryForm()
        {
            InitializeComponent();
            loadBorrowing_History();
        }

        private void BorrowingHistoryForm_Load(object sender, EventArgs e)
        {
            loadBorrowing_History();
        }
        //Close - back
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Min Max
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
        //Load borrowing history  
        private void loadBorrowing_History()
        {
            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading borrowing history \n " + ex.Message, "Error catched");
            }
        }

        private void BorrowingHistoryForm_Activated(object sender, EventArgs e)
        {
            loadBorrowing_History();
        }


    }
}
