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
using LibraryManegement.General;

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

            if (IsValid() <= 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("ADD_CATEGORY", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@CATEGORY", txtboxAddCat.Text);
                            cmd.Parameters.AddWithValue("@CREATED_BY", UsersInfo.Username);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Category Added ", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          
                        }
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("While Adding a Catogery, an Error catched. \n" + ex.Message + "\n" + ex.StackTrace, "Catched an Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    ClearTextBoxes(this.Controls);
                    txtboxAddCat.Focus();
                }
            }
        }
        //Close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*------------------------------------Behind the scene Functions----------------------------------------*/
        //Check if exists and not empty
        private int IsValid()
        {
            if (txtboxAddCat.Text != string.Empty)
            {
                try
                {


                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM CATEGORY WHERE ([CATEGORY] = @CATEGORY)", con))
                        {
                            check_User_Name.Parameters.AddWithValue("@CATEGORY", txtboxAddCat.Text);
                            if (con.State != ConnectionState.Open)
                                con.Open();
                            int UserExists = (int)check_User_Name.ExecuteScalar(); // if already exists returns 1 

                            if (UserExists > 0)
                            {
                                MessageBox.Show("Category Already Exists", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                                return 1;
                            }
                            else
                            {
                                return UserExists;
                            }
                        }
                    }
                }catch (Exception ex){
                MessageBox.Show("An error accured while loading Publisher data to combo boc" + ex.Message, "Error catched");
                    return 1;
                }
        }else
            {
                MessageBox.Show("Category Can't Be Empty.", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                return 1;    
            }
        }
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
