using JacobSutton_C989.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSutton_C989.Models
{
    public class DailyAppointments
    {
        public DataTable Daily_Appointments(DateTime start, DateTime end)
        {
            DateTime UtcStart = start.ToUniversalTime();
            DateTime UtcEnd = end.ToUniversalTime();

            string query = @"SELECT a.appointmentId, c.customerName, a.type, a.start, a.end FROM appointment a JOIN customer c ON c.customerId = a.customerId WHERE start >= @UtcStart AND start <= @UtcEnd";

            try
            {
                DataTable data = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                cmd.Parameters.AddWithValue("@UtcStart", UtcStart);
                cmd.Parameters.AddWithValue("@UtcEnd", UtcEnd);

                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                adapt.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    row["start"] = Convert.ToDateTime(row["start"]).ToLocalTime();
                    row["end"] = Convert.ToDateTime(row["end"]).ToLocalTime();
                }

                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
             
        }
    }
}
