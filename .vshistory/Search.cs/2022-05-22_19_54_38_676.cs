using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManegement
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.text = "";
            DataBook.Columns.Clear();
        }
    }
}
