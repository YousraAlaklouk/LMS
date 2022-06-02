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
    public partial class Penalty : Form
    {
        public Penalty()
        {
            InitializeComponent();
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
        //close
        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (rdiobtnPaid.Checked || rdiobtnUnpaid.Checked)
            {

                try
                {

                    if (rdiobtnPaid.Checked)

                    {

                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("FILTER_PENALTY_PAYMENT_HISTORY", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@from_date", FromDate.Value);
                                cmd.Parameters.AddWithValue("@to_date", toDate.Value);
                                cmd.Parameters.AddWithValue("@CONDITION", rdiobtnPaid.Text.ToLower());


                                if (con.State != ConnectionState.Open)
                                    con.Open();
                                DataTable dtRoles = new DataTable();

                                SqlDataReader dr = cmd.ExecuteReader();

                                dtRoles.Load(dr);

                                dataGridView.DataSource = dtRoles;


                            }
                        }
                    }
                    if (rdiobtnUnpaid.Checked)
                    {
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("FILTER_PENALTY_PAYMENT_HISTORY", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@from_date", FromDate.Value);
                                cmd.Parameters.AddWithValue("@to_date", toDate.Value);
                                cmd.Parameters.AddWithValue("@CONDITION", rdiobtnUnpaid.Text.ToLower());


                                if (con.State != ConnectionState.Open)
                                    con.Open();
                                DataTable dtRoles = new DataTable();

                                SqlDataReader dr = cmd.ExecuteReader();

                                dtRoles.Load(dr);

                                dataGridView.DataSource = dtRoles;


                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while filitring borrow history data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else{
                try
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("FILTER_PENALTY_HISTORY", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@from_date", FromDate.Value);
                            cmd.Parameters.AddWithValue("@to_date", toDate.Value);


                            if (con.State != ConnectionState.Open)
                                con.Open();
                            DataTable dtRoles = new DataTable();

                            SqlDataReader dr = cmd.ExecuteReader();

                            dtRoles.Load(dr);

                            dataGridView.DataSource = dtRoles;


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error accured while filitring borrow history data \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                

         
        }

        private void lblCleardata_Click(object sender, EventArgs e)
        {
            rdiobtnPaid.Checked = false;
            rdiobtnUnpaid.Checked = false;
        }
    }
}
