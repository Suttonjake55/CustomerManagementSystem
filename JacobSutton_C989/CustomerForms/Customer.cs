using JacobSutton_C989.CustomerForms;
using JacobSutton_C989.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSutton_C989
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            Load_Customer_Data();
            
        }

        public void Load_Customer_Data()
        {
            string query = @"SELECT c.customerId, c.customerName, c.addressId, a.phone, a.address, a.address2, a.postalCode, a.cityId, ci.city, co.country " +
                "FROM customer c JOIN address a ON c.addressId = a.addressId JOIN city ci ON a.cityId = ci.cityId JOIN country co ON ci.countryId = co.countryId";
           
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    Customer_data.DataSource = table;
                }
            }
        }

        private void Add_Customer_Click(object sender, EventArgs e)
        {
            AddCustomerForm newForm = new AddCustomerForm();
            newForm.ShowDialog();
            Load_Customer_Data();
        }

        private void Update_Customer_Click(object sender, EventArgs e)
        {
            if (Customer_data.CurrentRow != null)
            {
                DataRowView selectedRow = (DataRowView)Customer_data.CurrentRow.DataBoundItem;

                AddCustomerForm updateForm = new AddCustomerForm(selectedRow);

                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    Load_Customer_Data();
                }
            }
            else
            {
                MessageBox.Show("Please click on a customer to update them.");
            }
            Load_Customer_Data();
        }

        private void Delete_Customer_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)Customer_data.CurrentRow.DataBoundItem;
            int customerId = (int)selectedRow["customerId"];
            string customerName = selectedRow["customerName"].ToString();

            var result = MessageBox.Show("Are you sure you want to delete this customer from the system?", "Attention!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string apptCheck = "SELECT COUNT(*) FROM appointment WHERE customerId = @id";
                    MySqlCommand cmd = new MySqlCommand(apptCheck, dbConnection.conn);
                    cmd.Parameters.AddWithValue("@id", customerId);

                    int apptCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (apptCount > 0)
                    {
                        MessageBox.Show("This customer can't be deleted becasue there are associated appointments, please delete them first.");
                        return;
                    }
                    else
                    {
                        string deleteCustomer = "DELETE FROM customer WHERE customerId = @id";
                        MySqlCommand deleteCommand = new MySqlCommand(deleteCustomer, dbConnection.conn);
                        deleteCommand.Parameters.AddWithValue("@id", customerId);
                        deleteCommand.ExecuteNonQuery();

                        MessageBox.Show("Customer deleted successfully.");
                        Load_Customer_Data();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
