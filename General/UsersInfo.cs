using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManegement.General
{
    public class UsersInfo
    {

        public static int Book_limit = 3;


        public static int borrow_limit;
        public static string Username { get; set; }
        public static string User_ID { get; set; }
        public static int Role_ID { get; set; } // 1 for admin 2 for staff 4 for member 
        public static string User_Password { get; set; }
        // public static string Role_type { get; set; }

        //check book limits to borrow
        public static bool Borrowing_Limit_Check()
        {
            try
            {
 /*               using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("LOAD_BOOK_LIMIT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@USER_ID", User_ID);

                        if (con.State != ConnectionState.Open)
                            con.Open();


                        DataTable dtUser = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.HasRows)
                        {
                            dtUser.Load(sdr);

                            DataRow userData = dtUser.Rows[0];
                            borrow_limit = Convert.ToInt32(userData["BORROW_LIMIT"]);
                            if (borrow_limit <= 3 && borrow_limit > 0)
                                return true;
                        }

                        else
                        {
                            return false;
                        }
                    }
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while loading borrowing books limit \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return false;
        }
        // Update book Limits when borrowing and returning
        public static void Borrowing_Limit_Update()
        {
            try
            {
    /*            //Updating to user
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE_BOOK_LIMIT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", User_ID);
                        cmd.Parameters.AddWithValue("@BORROW_LIMIT", borrow_limit);
                        //cmd.Parameters.AddWithValue("@CONDITION","unpaid");

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();

                    }

                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error accured while Updating borrowing limits  \n " + ex.Message, "Error catched", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        //Check Book quantity
        public static bool Books_Quantity()
        {

            return false;
        }
    }
}
