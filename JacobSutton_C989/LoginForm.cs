using JacobSutton_C989.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using JacobSutton_C989.Resources;
using JacobSutton_C989.Models;





namespace JacobSutton_C989
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CultureInfo currCulture = CultureInfo.CurrentUICulture;
            RegionInfo currRegion = RegionInfo.CurrentRegion;
            Region_Info();
            userLocation();
            
        }

        private void userLocation()
        {
            RegionInfo currLocation = RegionInfo.CurrentRegion;
            string name = currLocation.DisplayName;

            Location_lbl.Text = $"Location {name}";
        }

        private void Region_Info()
        {
            this.Text = Resource.Login;
            Location_lbl.Text = Resource.Location;
            LoginUN_lbl.Text = Resource.Username;
            LoginPW_lbl.Text = Resource.Password;
            Login.Text = Resource.Login;
            Login_btn.Text = Resource.Login;
            Cancel_btn.Text = Resource.Cancel;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            //Define variables
            LoggedInUser.LoggedIn = UN_txt.Text;
            LoggedInUser.Password = PW_txt.Text;
            string query = $"SELECT * FROM client_schedule.user WHERE userName = @name AND password = @pw";

            //Define Logging variables
            string directPath = @"C:\temp\";
            string filePath = @"C:\temp\Login_History.txt";
            string loginWorked = $"User {LoggedInUser.LoggedIn} has logged in at {DateTime.Now} \n";
            string loginFail = $"User {LoggedInUser.LoggedIn} has failed to login at {DateTime.Now} \n" ;



            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

            //Verify that the username and password entered are matching in the database
            cmd.Parameters.AddWithValue(@"name", LoggedInUser.LoggedIn);
            cmd.Parameters.AddWithValue("@pw", LoggedInUser.Password);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    HomePage newPage = new HomePage();
                    
                    newPage.Show();


                    if (File.Exists(directPath))
                    {
                        File.AppendAllText(filePath, loginWorked);
                    }
                    else
                    {
                        Directory.CreateDirectory(directPath);
                        File.AppendAllText(filePath, loginWorked);
                    }
                }
                
                else
                {
                    Error_lbl.Text = Resource.Error;
                    File.AppendAllText(filePath, loginFail);
                }
            }

            
            TimeCheck Appt = new TimeCheck();

            if (Appt.HasAppointment(LoggedInUser.LoggedInId))
            {
                MessageBox.Show("Reminder you have an appointment in 15 minutes or less!");
            }
            if (!Appt.HasAppointment(LoggedInUser.LoggedInId))
            {
                MessageBox.Show("No appointments");
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
