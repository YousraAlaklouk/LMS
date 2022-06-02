using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManegement.Forms.Reports
{
    public partial class ReportsFrom : Form
    {
        public ReportsFrom()
        {
            InitializeComponent();
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
        //borrow reports  buttons
        private void btnBorrowingReports_Click(object sender, EventArgs e)
        {
            Borrowing frm = new Borrowing();
            frm.ShowDialog();
        }
        //penalty button
        private void btnPenaltyReports_Click(object sender, EventArgs e)
        {
            Penalty frm = new Penalty();
            frm.ShowDialog();
           
        }
    }
}
