using JacobSutton_C989.DataBase;
using JacobSutton_C989.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSutton_C989
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            
        }

        private void Customer_btn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void Appointment_btn_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            Reports appointment = new Reports();
            appointment.Show();
        }

        private void Appointment_cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DailyAppointments appointment = new DailyAppointments();

            DateTime dateSelected = Appointment_cal.SelectionStart;
            DateTime startDay = dateSelected.Date;
            DateTime endDay = startDay.AddDays(1).AddSeconds(-1);


            
            var result = appointment.Daily_Appointments(startDay, endDay);
            Upcoming_appt.DataSource = result;
        }

        
    }
}
