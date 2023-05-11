using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KHP_PowerWatch.DAL
{
    public class CustomerDAL
    {
        static string connec = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;

        #region select

        DatabaseManagement dbm = new DatabaseManagement();
        public DataTable Select(string entity)
        {

            SqlConnection con = new SqlConnection();
            DataTable dt = new DataTable();

            switch (entity.ToUpper())
            {
                case "CUSTOMER":
                    try
                    {
                        con.Open();
                        string sql = "SELECT * FROM CUSTOMER";
                        SqlCommand cmd = new SqlCommand(connec);

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                    break;

                case "ACCOUNT":
                    try
                    {
                        con.Open();
                        string sql = "SELECT * FROM ACCOUNT";
                        SqlCommand cmd = new SqlCommand(connec);

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                    break;

                case "METER":
                    try
                    {
                        con.Open();

                        string sql = "SELECT * FROM METER";

                        SqlCommand cmd = new SqlCommand(connec);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    break;

                case "BUILDING":
                     try
                    {
                        con.Open();
                        string sql = "SELECT * FROM CUSTOMER";
                        SqlCommand cmd = new SqlCommand(connec);

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                    break;

                default: MessageBox.Show("An error has occured. Please retry!!");
                    break;
            }
           
            return dt;


        }
        #endregion

        #region Insert
        //public bool Insert()
        #endregion
    }
}
