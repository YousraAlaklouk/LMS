using LibraryManegement.General;
using LibraryManegement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManegement.Forms.Reports;
using LibraryManegement.Forms.Users;

namespace LibraryManegement
{
    public partial class AdminWelcomeForm : Form
    {

        public AdminWelcomeForm()
        {
            InitializeComponent();

        }
        /*-------------------------------Main  Buttons----------------------------------------*/
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

        //User buttons
        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form usrfrom = new UserForm();
            usrfrom.ShowDialog();
        }
        //Roles list 
        private void btnRoles_Click(object sender, EventArgs e)
        {
            Form roleform = new AddRoleForm();
            roleform.ShowDialog();
        }
        //Books list 
        private void btnBooks_Click(object sender, EventArgs e)
        {
            Form frm2 = new BooksForm();
            frm2.ShowDialog();
        }
        //Admin List
        private void btnAdmins_Click(object sender, EventArgs e)
        {
            
            Form form1 = new AdminForm();
            form1.ShowDialog();
        }
        //Authors list 
        private void btnAuthors_Click(object sender, EventArgs e)
        {
            Form from_author = new AuthorForm();
            from_author.ShowDialog();
        }
        //Publisher Lsit
        private void btnPublishers_Click(object sender, EventArgs e)
        {
            Form from_publisher = new PublisherForm();
            from_publisher.ShowDialog();
        }
        //Member Lsit 
        private void btnMembers_Click(object sender, EventArgs e)
        {
            Form mmbform = new MemberForm();
            mmbform.ShowDialog();
        }
        //Staff  list
        private void btnStaff_Click(object sender, EventArgs e)
        {
            Form stfform = new StaffForm();
            stfform.ShowDialog();
        }

      
 //-----------------------Other buttons----------------------     

        // Borrowing reports
        private void btnBorrowingReports_Click(object sender, EventArgs e)
        {
            Form Rpt1 = new ReportsFrom();
            Rpt1.ShowDialog();
        }
        //Panalty Reports
        private void btnPanalty_Click(object sender, EventArgs e)
        {
            Form frm1 = new Penalty();
            frm1.ShowDialog();
        }
        
        // profile
        private void btnProfileIcon_Click(object sender, EventArgs e)
        {
            Form profileFrom = new Profile();
            profileFrom.ShowDialog();
        }
        //Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

    }

}
