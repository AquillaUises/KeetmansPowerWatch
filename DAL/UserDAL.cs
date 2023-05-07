using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace KHP_PowerWatch.DAL
{
    public class UserDAL
    {

        static string connec_string = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;

        public bool loginCheck(StaffLL.StaffLogin staff)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(connec_string);

            try
            {
                string sql = "SELECT Username, Staff_Password FROM MUNICIPALSTAFF_LOGIN WHERE Username = @username AND Staff_Password = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", staff.username);
                cmd.Parameters.AddWithValue("password", staff.password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return isSuccess;
        }

        public bool resetPassword(StaffLL.StaffLogin stf)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connec_string);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ResetPassword", conn);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Username", stf.username);
                command.Parameters.AddWithValue("@NewPassword", stf.password);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return isSuccess;
        }
    }
}
