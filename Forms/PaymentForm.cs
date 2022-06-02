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
    public partial class PaymentForm : Form
    {
        public double payment;
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon!","wait for it",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please head to the cashier for payment", "lol", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
