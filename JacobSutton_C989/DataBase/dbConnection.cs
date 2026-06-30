using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JacobSutton_C989.DataBase
{
    public class dbConnection
    {
        public static MySqlConnection conn {  get; set; }

        public static string connString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;

        public static void startConnection()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
                conn = new MySqlConnection(constr);

                conn.Open();

                //MessageBox.Show("The Connection is open.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (conn != null)
                {
                    //MessageBox.Show("Connection is closed");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
