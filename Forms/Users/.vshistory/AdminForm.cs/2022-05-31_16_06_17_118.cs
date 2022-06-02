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
    public partial class AdminForm : Form
    {

        public int ID, Users_ID;
        public string username;
        AddAdminForm adm_update = new AddAdminForm();
        public AdminForm()
        {
            InitializeComponent();
        } 

        /*----------------------------------Buttons-------------------------------*/

        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        // delete admin
        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {

        }
        //update admin
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (adm_update.txtboxUsername.Text != string.Empty)
            {
                adm_update.ADD_OR_UPDATE = 1;
                adm_update.User_ID = Users_ID;
                adm_update.Admin_ID = ID;
                adm_update.btnAddAdmin.ButtonText = "Update";
                adm_update.ShowDialog();
            }
            else
            {
                MessageBox.Show("select at leat a cell of the person you wants to update\n","Select data to update",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        //add admin
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddAdminForm frm = new AddAdminForm();
            frm.ADD_OR_UPDATE = 0;
            frm.User_ID = Users_ID;
            frm.ShowDialog();
        }

        /*----------------------------------behind the scene-------------------------------*/

        //Load Admin data
        private void LoadAdminData()
        {

        }
      
        //Load data to update
        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdmin.Rows.Count > 0)
            {
                
                username = dataGridViewAdmin.CurrentRow.Cells[3].Value.ToString();
                ID = Convert.ToInt32(dataGridViewAdmin.CurrentRow.Cells[0].Value);
                Users_ID = Convert.ToInt32(dataGridViewAdmin.CurrentRow.Cells[1].Value);
                adm_update.txtboxName.Text = dataGridViewAdmin.CurrentRow.Cells[2].Value.ToString();
                adm_update.txtboxUsername.Text = dataGridViewAdmin.CurrentRow.Cells[3].Value.ToString();
                adm_update.txtboxPassword.Text = dataGridViewAdmin.CurrentRow.Cells[4].Value.ToString();
                RadioButtonText();
                adm_update.txtboxAddress.Text = dataGridViewAdmin.CurrentRow.Cells[6].Value.ToString();
                adm_update.txtboxEmail.Text = dataGridViewAdmin.CurrentRow.Cells[7].Value.ToString();
                adm_update.checkboxActivation.Checked = Convert.ToBoolean(dataGridViewAdmin.CurrentRow.Cells[8].Value);
            }
        }
        //gender button
        private object RadioButtonText()
        {
            if (dataGridViewAdmin.CurrentRow.Cells[5].Value.ToString().Equals("Male"))
            {
                return adm_update.rdiobtnMale.Checked;
            }
            else
            {
                return adm_update.rdiobtnFemale.Checked;
            }
        }

        //load data when form is open
        private void AdminForm_Activated(object sender, EventArgs e)
        {
            LoadAdminData();

        }

    }

}
