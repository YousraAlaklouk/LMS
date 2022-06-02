
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
    public partial class UserWelcomeForm : Form
    {
        public int counter = 0;
        public int time = 0;
        public string text;

        public UserWelcomeForm()
        {
            InitializeComponent();
        }
        //moving text
        private void UserWelcomeForm_Load(object sender, EventArgs e)
        {
            text = lblWelcome.Text;
            time = text.Length;
            lblWelcome.Text = "";
            timer1.Start();
        }

        //timer the moving text
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWelcome.Text = text.Substring(0, counter);
            ++counter;
            if (counter > time)
            {
                timer1.Stop();
            }
        }

/*------------------------------------Buttons----------------------------------------*/

        //Return books
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm form1 = new ReturnBookForm();
            this.IsMdiContainer = true;
            form1.TopLevel = false;
            RightPanel.Controls.Clear();
            RightPanel.Controls.Add(form1);
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }
        //Profile button
        private void btnProfileIcon_Click(object sender, EventArgs e)
        {
            Profile form1 = new Profile();
            form1.ShowDialog();
        }
        //Borrow book
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            SearchBookForm form1 = new SearchBookForm();
            form1.topPanel.Visible = false;
            this.IsMdiContainer = true;
            form1.TopLevel = false;
            RightPanel.Controls.Clear();
            RightPanel.Controls.Add(form1);
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }
        //Borrow history
        private void btnBorrowingHistory_Click(object sender, EventArgs e)
        {
            BorrowingHistoryForm form1 = new BorrowingHistoryForm();
            this.IsMdiContainer = true;
            form1.TopLevel = false;
            RightPanel.Controls.Clear();
            RightPanel.Controls.Add(form1);
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //max_min 
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
        //logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentForm form1 = new PaymentForm();
            this.IsMdiContainer = true;
            form1.TopLevel = false;
            RightPanel.Controls.Clear();
            RightPanel.Controls.Add(form1);
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }
    }
}
