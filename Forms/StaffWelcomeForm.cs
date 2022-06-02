using LibraryManegement.Forms.Borrow;
using LibraryManegement.Forms.Reports;
using LibraryManegement.Forms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManegement.Forms
{
    public partial class StaffWelcomeForm : Form
    {
        public StaffWelcomeForm()
        {
            InitializeComponent();
        }
        // ----------------------------------------------Main Panel----------------------------------------------------------
        //member form
        private void btnMemberForStaff_Click(object sender, EventArgs e)
        {
            Form mmbform = new MemberForm();
            mmbform.ShowDialog();
        }
        //Publihser form
        private void btnPublishersForStaff_Click(object sender, EventArgs e)
        {
            Form from_publisher = new PublisherForm();
            from_publisher.ShowDialog();
        }
        //Books form
        private void btnBooksForStaff_Click(object sender, EventArgs e)
        {
            Form Bk_frm = new BooksForm();
            Bk_frm.ShowDialog();
        }
        //Author form
        private void btnAuthorsForStaff_Click(object sender, EventArgs e)
        {
            Form from_author = new AuthorForm();
            from_author.ShowDialog();
        }
        //Report form
        private void btnBorrowingReports_Click(object sender, EventArgs e)
        {
            Form frm = new ReportsFrom();
            frm.ShowDialog();
        }

        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        
        //-------------------------------Left Panel ---------------------------------------------------------------------------------
        //Change pass
        private void btnProfileIcon_Click(object sender, EventArgs e)
        {
            Form profileFrom = new Profile();
            profileFrom.ShowDialog();
        }
        //Borrow book
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            SearchBookForm form1 = new SearchBookForm();
            form1.ShowDialog();
        }
        //Return book
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm form1 = new ReturnBookForm();
            form1.ShowDialog();
        }
        // Books History
        private void btnBorrowingHistory_Click(object sender, EventArgs e)
        {
            BorrowingHistoryForm form1 = new BorrowingHistoryForm();
            form1.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Pay frm = new Pay();
            frm.ShowDialog();
        }
    }
}
