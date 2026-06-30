using JacobSutton_C989.AppointmentForms;
using JacobSutton_C989.CustomerForms;
using JacobSutton_C989.DataBase;
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

namespace JacobSutton_C989
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            Load_Appointment_Data();
        }
        public void Load_Appointment_Data()
        {
            string query = "SELECT * from appointment";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(dbConnection.connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            Appointment_data.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
         }
                    
             

        private void Add_bttn_Click(object sender, EventArgs e)
        {
            AddAppointment form = new AddAppointment();
            form.ShowDialog();
            Load_Appointment_Data();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (Appointment_data.CurrentRow != null)
            {
                DataRowView selectedRow = (DataRowView)Appointment_data.CurrentRow.DataBoundItem;

                AddAppointment updateForm = new AddAppointment(selectedRow);

                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    Load_Appointment_Data();
                }
            }

            else
            {
                MessageBox.Show("Please click on a customer to update them.");
            }
            Load_Appointment_Data();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)Appointment_data.CurrentRow.DataBoundItem;
            int apptId = (int)selectedRow["appointmentId"];
            var result = MessageBox.Show("Are you sure you want to delete this appointment?", "Attention", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string removeAppt = "DELETE FROM appointment WHERE appointmentId = @apptId";
                    MySqlCommand cmd = new MySqlCommand(removeAppt, dbConnection.conn);
                    cmd.Parameters.AddWithValue("@apptId", apptId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment deleted successfully.");
                    Load_Appointment_Data();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
