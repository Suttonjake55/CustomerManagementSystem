using JacobSutton_C989.DataBase;
using JacobSutton_C989.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSutton_C989.AppointmentForms
{
    public partial class AddAppointment : Form
    {
        private bool isUpdate = false;
        private int currApptId;

        public AddAppointment()
        {
            InitializeComponent();
            Load_Combos();
        }
        public AddAppointment(DataRowView row)
        {
            InitializeComponent();
            Load_Combos();
            

            if (row != null)
            {
                isUpdate = true;
                currApptId = Convert.ToInt32(row["appointmentId"]);

                Customer_CB.SelectedValue = row["customerId"];
                Title_txt.Text = row["title"].ToString();
                Description_txt.Text = row["description"].ToString();
                Location_txt.Text = row["location"].ToString();
                Contact_txt.Text = row["contact"].ToString();
                Type_CB.Text = row["type"].ToString();
                URL_txt.Text = row["url"].ToString();

                StartTimePicker.Value = Convert.ToDateTime(row["start"]).ToLocalTime();
                EndTimePicker.Value = Convert.ToDateTime(row["end"]).ToLocalTime();
            }
            else 
            {
                isUpdate = false;

            }
        }

        private void Load_Combos()
        {
            //Customer Combo Box
            string query = "SELECT customerId, customerName FROM customer";
            DataTable dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            Customer_CB.DisplayMember = "customerName";
            Customer_CB.ValueMember = "customerId";
            Customer_CB.DataSource = dt;
            Customer_CB.SelectedIndex = -1;


            //Type Combo Box
            //string query2 = "SELECT type FROM appointment";
            //DataTable dt2 = new DataTable();
            //MySqlCommand cmd2 = new MySqlCommand(@query2, dbConnection.conn);
            //MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            //adapter2.Fill(dt2);

            //Type_CB.DisplayMember = "type";
            //Type_CB.DataSource = dt2;
            //Type_CB.SelectedIndex = -1;

            //USE THIS IF THE TYPE of Appointment field is not filled out

            var apptTypes = new List<string> { "Scrum", "Presentation" };
            Type_CB.DataSource = apptTypes;
            Type_CB.SelectedIndex = -1;
        }


        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                if (Type_CB.SelectedIndex == -1 || Customer_CB.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter values for required fields Customer and Type.");
                    return;

                }

                if (StartTimePicker.Value >= EndTimePicker.Value)
                {
                    MessageBox.Show("Start time must be before end time.");
                    return;
                }

                //Give variables to input values
                int CustomerId = (int)Customer_CB.SelectedValue;
                string type = Type_CB.Text;
                DateTime Start = StartTimePicker.Value;
                DateTime End = EndTimePicker.Value;

                TimeCheck time = new TimeCheck();

                if (!time.BusinessHours(Start, End))
                {
                    MessageBox.Show("Appointment can only be scheduled within hours of 9 AM and 5 PM EST, M - F");
                    return;
                }

                if (time.AppointmentOverlap(Start, End))
                {
                    MessageBox.Show("This user already has an appointment scheduled during this time.");
                    return;
                }

                //Convert time to UTC
                DateTime StartUTC = Start.ToUniversalTime();
                DateTime EndUTC = End.ToUniversalTime();

                string query = @"INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    "VALUES (@custId, @userId, '', '', '', '', @type, '', @start, @end, NOW(), @user, NOW(), @user)";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

                    //Params
                    cmd.Parameters.AddWithValue("@custId", CustomerId);
                    cmd.Parameters.AddWithValue("@userId", LoggedInUser.LoggedInId);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@start", StartUTC);
                    cmd.Parameters.AddWithValue("@end", EndUTC);
                    cmd.Parameters.AddWithValue("@user", LoggedInUser.LoggedIn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Appointment was added successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving appointment: " + ex.Message);
                    dbConnection.conn.Close();
                }
            }

            if (isUpdate)
            {
                if (Type_CB.SelectedIndex == -1 || Customer_CB.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter values for required fields Customer and Type.");
                    return;

                }

                if (StartTimePicker.Value >= EndTimePicker.Value)
                {
                    MessageBox.Show("Start time must be before end time.");
                    return;
                }

                //Give variables to input values
                int CustomerId = (int)Customer_CB.SelectedValue;
                string type = Type_CB.Text;
                DateTime Start = StartTimePicker.Value;
                DateTime End = EndTimePicker.Value;

                TimeCheck time = new TimeCheck();

                if (!time.BusinessHours(Start, End))
                {
                    MessageBox.Show("Appointment can only be scheduled within hours of 9 AM and 5 PM EST, M - F");
                    return;
                }

                if (time.AppointmentOverlap(Start, End, currApptId))
                {
                    MessageBox.Show("This user already has an appointment scheduled during this time.");
                    return;
                }

                //Convert time to UTC
                DateTime StartUTC = Start.ToUniversalTime();
                DateTime EndUTC = End.ToUniversalTime();

                string query = @"UPDATE appointment SET customerId = @custId, userId = @userId, title = @title, description = @description, location = @location, contact = @contact, URL = @URL, type = @type, start = @start, end = @end, lastUpdate = NOW(), lastUpdateBy = @user WHERE appointmentId = @apptId";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

                    //Params
                    cmd.Parameters.AddWithValue("@custId", CustomerId);
                    cmd.Parameters.AddWithValue("@userId", LoggedInUser.LoggedInId);
                    cmd.Parameters.AddWithValue("@title", Title_txt.Text);
                    cmd.Parameters.AddWithValue("@description", Description_txt.Text);
                    cmd.Parameters.AddWithValue("@location", Location_txt.Text);
                    cmd.Parameters.AddWithValue("@contact", Contact_txt.Text);
                    cmd.Parameters.AddWithValue("@URL", URL_txt.Text);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@start", StartUTC);
                    cmd.Parameters.AddWithValue("@end", EndUTC);
                    cmd.Parameters.AddWithValue("@user", LoggedInUser.LoggedIn);
                    cmd.Parameters.AddWithValue("@apptId", currApptId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Appointment was updated successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating appointment: " + ex.Message);
                    dbConnection.conn.Close();
                }
            }

        }



        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
