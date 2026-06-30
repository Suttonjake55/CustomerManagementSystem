using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JacobSutton_C989.DataBase;
using System.Windows.Forms;

namespace JacobSutton_C989.Models
{

    public class Reporting
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }



        public List<Reporting> GetReportData()
        {
            List<Reporting> data = new List<Reporting>();

            string query = @"SELECT u.userName, c.customerName, a.type, a.start, ci.city FROM appointment a JOIN user u ON a.userId = u.userId JOIN customer c ON a.customerId = c.customerId JOIN address ad ON c.addressId = ad.addressId JOIN city ci ON ad.cityId = ci.cityId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(dbConnection.connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Add(new Reporting
                                {
                                    Name = reader["userName"].ToString(),
                                    Type = reader["Type"].ToString(),
                                    CustomerName = reader["customerName"].ToString(),
                                    Start = Convert.ToDateTime(reader["start"]).ToLocalTime(),
                                    City = reader["city"].ToString()
                                });
                            }
                        } 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            return data;
        }
        public object AppointmentTypeByMonth(List<Reporting> data)
        {
            //First use of Lambda expression grouping appointments by each month, and then counting how many there are for each month.
            var report = data
                .GroupBy(a => new { Month = a.Start.ToString("MMMM"), a.Type })
                .Select(g => new
                {
                    Month = g.Key.Month,
                    Type = g.Key.Type,
                    Count = g.Count()
                })
                .OrderBy(r => r.Month)
                .ToList();

            return report;

        }

        public object UserSchedule(List<Reporting> data, string name)
        {
            //Second Lambda expression looks for each appointment scheduled with the logged in user and groups them together.
            var userSchedule = data
                .Where(a => a.Name == name)
                .OrderBy(a => a.Start)
                .Select(a => new
                {
                    Time = a.Start.ToString("hh:mm tt"),
                    Date = a.Start.ToShortDateString(),
                    Customer = a.CustomerName,
                    Type =a.Type,
                })
                .ToList();

            return userSchedule;
        }

        public object LocationReport(List<Reporting> data)
        {
            //Last Lambda expression is again using the GroupBy Lambda to group the results of where users are scheduling appointments
            var userLocation = data
                .GroupBy(c => c.City)
                .Select(g => new
                {
                    City = g.Key,
                    AppointmentCount = g.Count()
                })
                .OrderByDescending(x => x.AppointmentCount)
                .ToList();
            return userLocation;

        }
    }
}

