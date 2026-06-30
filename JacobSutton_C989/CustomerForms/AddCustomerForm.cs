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
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JacobSutton_C989.CustomerForms
{
    public partial class AddCustomerForm : Form
    {
        private bool isUpdate = false;
        private int currCustomerId = -1;
        private int currAddressId = -1;


        public AddCustomerForm()
        {
            InitializeComponent();
            Load_City();
            isUpdate = false;
        }

        public AddCustomerForm(DataRowView row)
        {
            InitializeComponent();
            Load_City();
            isUpdate = true;

            if (row["cityId"] != DBNull.Value)
            {
                City_cb.SelectedValue = row["cityId"];
            }
            currCustomerId = (int)row["customerId"];
            currAddressId = (int)row["addressId"];
            Name_txt.Text = row["customerName"].ToString();
            PhoneNum_txt.Text = row["phone"].ToString();
            Address1_txt.Text = row["address"].ToString();
            Address2_txt.Text = row["address2"].ToString();
            PostalCode_txt.Text = row["postalCode"].ToString();
            Country_txt.Text = row["country"].ToString();   

        }

        private void Load_City()
        {
            string query = "SELECT cityId, city FROM city";
            DataTable dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            City_cb.DisplayMember = "city";
            City_cb.ValueMember = "cityId";
            City_cb.DataSource =dt;
            
            City_cb.SelectedIndex = -1;
        }


        private void Save_button_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                //Check to make sure required fields are filled out before moving on
                if (string.IsNullOrWhiteSpace(Name_txt.Text) || string.IsNullOrWhiteSpace(Address1_txt.Text) || string.IsNullOrWhiteSpace(PhoneNum_txt.Text))
                {
                    MessageBox.Show("Please fill out the required fields, (Name, Address, Phone).");
                    return;
                }

                //Check if phone number is only digits and dashes
                foreach (char c in PhoneNum_txt.Text)
                {
                    if (!char.IsDigit(c) && c != '-')
                    {
                        MessageBox.Show("The phone field may only contain numbers and dashes");
                        return;
                    }
                }

                MySqlTransaction transaction = dbConnection.conn.BeginTransaction();

                try
                {
                    
                    int selectCityId = (int)City_cb.SelectedValue;

                    string updateAddr = @"UPDATE address SET address = @addr, cityId = @cityId, postalCode = @code, phone = @phone, lastUpdate = NOW(), lastUpdateBy = @user " +
                        "WHERE addressId = @addressId";

                    MySqlCommand addrCmd = new MySqlCommand(updateAddr, dbConnection.conn, transaction);
                    addrCmd.Parameters.AddWithValue("@addr", Address1_txt.Text.Trim());
                    addrCmd.Parameters.AddWithValue("@cityID", selectCityId);
                    addrCmd.Parameters.AddWithValue("@phone", PhoneNum_txt.Text.Trim());
                    addrCmd.Parameters.AddWithValue("@code", int.Parse(PostalCode_txt.Text.Trim()));
                    addrCmd.Parameters.AddWithValue("@user", LoggedInUser.LoggedIn);
                    addrCmd.Parameters.AddWithValue("@addressId", currAddressId);

                    addrCmd.ExecuteNonQuery();

                    string updateCust = @"UPDATE customer SET customerName = @name, lastUpdate = NOW(), lastUpdateBy = @user WHERE addressId = @addressId";

                    MySqlCommand custCmd = new MySqlCommand(updateCust, dbConnection.conn, transaction);
                    custCmd.Parameters.AddWithValue("@customerId", currCustomerId);
                    custCmd.Parameters.AddWithValue("@name", Name_txt.Text.Trim());
                    custCmd.Parameters.AddWithValue("@user", LoggedInUser.LoggedIn);
                    custCmd.Parameters.AddWithValue("@addressId", currAddressId);

                    custCmd.ExecuteNonQuery();


                    transaction.Commit();
                    MessageBox.Show("Customer updated successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Close the form after success
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }

            if (!isUpdate)
            {
                //Check to make sure required fields are filled out before moving on
                if (string.IsNullOrWhiteSpace(Name_txt.Text) || string.IsNullOrWhiteSpace(Address1_txt.Text) || string.IsNullOrWhiteSpace(PhoneNum_txt.Text))
                {
                    MessageBox.Show("Please fill out the required fields, (Name, Address, Phone).");
                    return;
                }

                //Check if phone number is only digits and dashes
                foreach (char c in PhoneNum_txt.Text)
                {
                    if (!char.IsDigit(c) && c != '-')
                    {
                        MessageBox.Show("The phone field may only contain numbers and dashes");
                        return;
                    }
                }


                //Used for the ComboBox associated with the city names
                int selectCityId = (int)City_cb.SelectedValue;
                MySqlTransaction transaction = dbConnection.conn.BeginTransaction();


                try
                {
                    string addAddress = " INSERT INTO address (address, address2, cityID, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                        "VALUES (@addr, '', @cityID, @code, @phone, NOW(), @user, NOW(), @user); " +
                        "SELECT LAST_INSERT_ID();";


                    MySqlCommand addrCmd = new MySqlCommand(addAddress, dbConnection.conn, transaction);
                    addrCmd.Parameters.AddWithValue("@addr", Address1_txt.Text.Trim());
                    addrCmd.Parameters.AddWithValue("@cityID", selectCityId);
                    addrCmd.Parameters.AddWithValue("@phone", PhoneNum_txt.Text.Trim());
                    addrCmd.Parameters.AddWithValue("@code", int.Parse(PostalCode_txt.Text.Trim()));
                    addrCmd.Parameters.AddWithValue("@user", LoggedInUser.LoggedIn);


                    int newAddressId = Convert.ToInt32(addrCmd.ExecuteScalar());

                    string customerSql = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                     "VALUES (@name, @addressId, 1, NOW(), @user, NOW(), @user);";

                    MySqlCommand custCmd = new MySqlCommand(customerSql, dbConnection.conn, transaction);
                    custCmd.Parameters.AddWithValue("@name", Name_txt.Text.Trim());
                    custCmd.Parameters.AddWithValue("@addressId", newAddressId);
                    custCmd.Parameters.AddWithValue("@user", LoggedInUser.LoggedIn);

                    custCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Customer saved successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Close the form after success
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

