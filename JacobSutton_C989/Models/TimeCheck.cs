using JacobSutton_C989.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSutton_C989.Models
{
    public class TimeCheck
    {
        public bool BusinessHours(DateTime localStart, DateTime localEnd)
        {
            TimeZoneInfo EST = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            DateTime estStart = TimeZoneInfo.ConvertTime(localStart, EST);
            DateTime estEnd = TimeZoneInfo.ConvertTime(localEnd, EST);

            TimeSpan workStart = new TimeSpan(9, 0, 0);
            TimeSpan workEnd = new TimeSpan(17, 0, 0);

            var weekday = estStart.DayOfWeek != DayOfWeek.Saturday && estStart.DayOfWeek != DayOfWeek.Sunday;

            var workHours = estStart.TimeOfDay >= workStart && estEnd.TimeOfDay <= workEnd;

            var sameDay = estStart.Date == estEnd.Date;

            return weekday && workHours && sameDay;
        }

        public bool AppointmentOverlap(DateTime localStart2, DateTime localEnd2, int apptID = -1)
        {
            
            
                DateTime StartUtc = localStart2.ToUniversalTime();
                DateTime EndUtc = localEnd2.ToUniversalTime();

                string query = @"SELECT COUNT(*) FROM appointment WHERE userId = @userId AND (@newStart < end AND @newEnd > start) AND appointmentId != @currentApptId";

                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

                cmd.Parameters.AddWithValue("@userId", LoggedInUser.LoggedInId);
                cmd.Parameters.AddWithValue("@newStart", StartUtc);
                cmd.Parameters.AddWithValue("@newEnd", EndUtc);
                cmd.Parameters.AddWithValue("@currentApptId", apptID);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;

        }

        public bool HasAppointment(int userId)
        {
            DateTime now = DateTime.UtcNow;
            DateTime AptCheck = now.AddMinutes(15);

            string query = @"SELECT a.start, a.type, c.customerName FROM appointment a JOIN customer c ON a.customerId = c.customerId WHERE a.userId = @userId AND a.start BETWEEN @now AND @plusFifteen";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(dbConnection.connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", userId);
                        cmd.Parameters.AddWithValue("@now", now);
                        cmd.Parameters.AddWithValue("@plusFifteen", AptCheck);

                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime StartUtc = Convert.ToDateTime(reader["start"]);
                                DateTime localStart = StartUtc.ToLocalTime();
                                string aptType = reader["type"].ToString();
                                string customer = reader["customerName"].ToString();

                                MessageBox.Show($"Reminder: You have a {aptType} appointment at {localStart.ToString("hh:mm tt")}");
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
      
        }
    }
}
