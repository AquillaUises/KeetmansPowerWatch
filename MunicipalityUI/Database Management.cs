using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHP_PowerWatch
{
    public partial class DatabaseManagement : Form
    {
        public DatabaseManagement()
        {
            InitializeComponent();
        }

        private void RMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RealTimeMonitoring realtime_Monitoring = new RealTimeMonitoring();
            realtime_Monitoring.Show();
        }

        private void CAbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsumptionAnalysis consumption_Analysis = new ConsumptionAnalysis();
            consumption_Analysis.Show();
        }

        private void PGbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PowerGrid_Simulator powerGrid_Simulator = new PowerGrid_Simulator();
            powerGrid_Simulator.Show();
        }

        private void DMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseManagement database_Management = new DatabaseManagement();
            database_Management.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Database_Management_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
        }

        private void CAbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ConsumptionAnalysis consumption_Analysis = new ConsumptionAnalysis();
            consumption_Analysis.Show();
        }

        private void PGbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PowerGrid_Simulator powerGrid_Simulator = new PowerGrid_Simulator();
            powerGrid_Simulator.Show();
        }

        private void DMbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseManagement database_Management = new DatabaseManagement();
            database_Management.Show();
        }

        private void Logoutbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
        }

        private void Database_Management_Load_1(object sender, EventArgs e)
        {
            lblStaff.Text = Login.loggedInStaff.ToString();
        }

        public void cmbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }

            string selectedTable = cmbEntities.SelectedItem.ToString();
            switch(selectedTable.ToUpper())
            {
                case "ACCOUNT":
                    lblID.Text = "Account Number:";
                    lblFirstname.Text = "Customer ID: ";
                    lblLastName.Text = "Bill Amount: ";
                    lblEmail.Text = "Bill Date: ";
                    lblGender.Visible = false;
                    lblPhone.Visible = false;
                    lblResidential.Visible = false;
                    txtBoxreplacer.Visible = false;
                    lblCity.Visible = false;
                    txtBoxCity.Visible = false;
                    txtBoxPhone.Visible = false;
                    txtBoxAddress.Visible = false;
                    cmbGender.Visible = false;
                    lblFloorcount.Visible = false;
                    lblTotalSquare.Visible = false;
                    txtBoxFloorCount.Visible = false;
                    txtBoxSquare.Visible = false;
                    break;

                case "CUSTOMER":
                    lblID.Text = "Customer ID:";
                    lblFirstname.Text = "First Name: ";
                    lblLastName.Text = "Last Name: ";
                    lblEmail.Text = "Email: ";
                    lblGender.Text = "Gender: ";
                    lblPhone.Text = "Phone: ";
                    lblResidential.Text = "Residential Address: ";
                    lblCity.Text = "City: ";
                    lblGender.Visible = true;
                    lblPhone.Visible = true;
                    lblGender.Text = "Gender: ";
                    txtBoxreplacer.Visible = false;
                    lblPhone.Text = "Phone: ";
                    lblResidential.Visible = true;
                    lblCity.Visible = true;
                    txtBoxCity.Visible = true;
                    txtBoxPhone.Visible = true;
                    txtBoxAddress.Visible = true;
                    cmbGender.Visible = true;
                    lblFloorcount.Visible = false;
                    lblTotalSquare.Visible = false;
                    txtBoxFloorCount.Visible = false;
                    txtBoxSquare.Visible = false;
                    break;

                case "METER":
                    lblID.Text = "Meter Number: ";
                    lblFirstname.Text = "Current Reading: ";
                    lblLastName.Text = "Meter Type: ";
                    lblEmail.Text = "Erf Number: ";
                    lblGender.Text = "Reading Date: ";
                    cmbGender.Visible = false;
                    // Show and position the new TextBox
                    txtBoxreplacer.Visible = true;
                    txtBoxreplacer.Location = cmbGender.Location;
                    lblGender.Visible = true;
                    lblPhone.Visible = false;
                    lblResidential.Visible = false;
                    lblCity.Visible = false;
                    txtBoxCity.Visible = false;
                    txtBoxPhone.Visible = false;
                    txtBoxAddress.Visible = false;
                    cmbGender.Visible = false;
                    lblFloorcount.Visible = false;
                    lblTotalSquare.Visible = false;
                    txtBoxFloorCount.Visible = false;
                    txtBoxSquare.Visible = false;
                    

                    break;

                case "BUILDING":
                    lblID.Text = "Erf Number:";
                    lblFirstname.Text = "Building Type: ";
                    lblLastName.Text = "Power Grid: ";
                    lblEmail.Text = "Building Address: ";
                    lblGender.Text = "City: ";
                    lblPhone.Text = "Suburb: ";
                    lblResidential.Text = "Customer ID: ";
                    lblCity.Text = "Number of Rooms: ";
                    lblFloorcount.Text = "Floor Count: ";
                    lblTotalSquare.Text = "Area in Sqm: ";
                    
                    txtBoxreplacer.Visible = true;
                    lblGender.Visible = true;
                    lblPhone.Visible = true;
                    lblFloorcount.Visible = true;
                    lblTotalSquare.Visible = true;
                    lblResidential.Visible = true;
                    lblCity.Visible = true;
                    txtBoxCity.Visible = true;
                    txtBoxPhone.Visible = true;
                    txtBoxAddress.Visible = true;
                    cmbGender.Visible = false;
                    txtBoxFloorCount.Visible = true;
                    txtBoxSquare.Visible = true;
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                

                // Check if an item is selected in the ComboBox
                if (cmbEntities.SelectedItem != null)
                {
                    string selectedTable = cmbEntities.SelectedItem.ToString();

                    string primaryKey = txtBoxID.Text.Trim();

                    string connectionString = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString; 

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        switch (selectedTable.ToUpper())
                        {
                            case "CUSTOMER":
                                DeleteFromCustomerTable(connection, primaryKey);
                                break;
                            case "ACCOUNT":
                                DeleteFromAccountTable(connection, primaryKey);
                                break;
                            case "BUILDING":
                                DeleteFromBuildingTable(connection, primaryKey);
                                break;
                            case "METER":
                                DeleteFromMeterTable(connection, primaryKey);
                                break;
                            default:
                                MessageBox.Show("Invalid Selection");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a table.");
                }
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Method to delete a record from the ACCOUNT table.
        private void DeleteFromAccountTable(SqlConnection connection, string primaryKey)
        {
            string query = "DELETE FROM ACCOUNT WHERE AccountNumber = @AccountNumber";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@AccountNumber", primaryKey);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records found in ACCOUNT table with the provided primary key.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to delete a record from the CUSTOMER table.
        private void DeleteFromCustomerTable(SqlConnection connection, string primaryKey)
        {
            string query = "DELETE FROM CUSTOMER WHERE Customer_IDNo = @CustomerID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@CustomerID", primaryKey);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records found in CUSTOMER table with the provided primary key.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to delete a record from the BUILDING table.
        private void DeleteFromBuildingTable(SqlConnection connection, string primaryKey)
        {
            string query = "DELETE FROM BUILDING WHERE Erf_No = @ErfNumber";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@ErfNumber", primaryKey);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records found in BUILDING table with the provided primary key.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Method to delete a record from the METER table.
        private void DeleteFromMeterTable(SqlConnection connection, string primaryKey)
        {
            string query = "DELETE FROM METER WHERE Meter_No = @MeterNumber";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@MeterNumber", primaryKey);
                    command.ExecuteNonQuery();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { command.Dispose(); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               

                // Check if an item is selected in the ComboBox
                if (cmbEntities.SelectedItem != null)
                {
                    string selectedTable = cmbEntities.SelectedItem.ToString();

                    string connectionString = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString; 

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        switch (selectedTable.ToUpper())
                        {
                            case "CUSTOMER":
                                InsertIntoCustomerTable(connection);
                                break;

                            case "BUILDING":
                               InsertIntoBuildingTable(connection);
                                break;

                            case "METER":
                                InsertIntoMeterTable(connection);
                                break;

                            case "ACCOUNT":
                                InsertIntoAccountTable(connection);
                                break;

                            default:
                                MessageBox.Show("Invalid Selection");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to insert a record into the CUSTOMER table.
        private void InsertIntoCustomerTable(SqlConnection connection)
        {
           
            string customerID = txtBoxID.Text.Trim();
            string firstName = txtBoxFirstName.Text.Trim();
            string lastName = txtBoxLastName.Text.Trim();
            string email = txtBoxEmail.Text.Trim();
            string gender = cmbGender.Text.Trim();
            
            string contactNumber = txtBoxPhone.Text.Trim();
            string address = txtBoxAddress.Text.Trim();
            string city = txtBoxCity.Text.Trim();
            string AddedBy = Login.loggedInStaff.ToString();

            string query = "INSERT INTO CUSTOMER (Customer_IDNo, Customer_FirstName, Customer_LastName, Customer_Email, Customer_Gender, ContactNumber, Residential_Address, City, Added_By) " +
                           "VALUES (@CustomerID, @FirstName, @LastName, @Email, @Gender, @ContactNumber, @Address, @City, @AddedBy)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Gender", gender);
                
                command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@AddedBy", AddedBy);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateDataGridView("CUSTOMER");
        }

        // Method to insert a record into the BUILDING table.
       
        private void InsertIntoBuildingTable(SqlConnection connection)
        {
            
            string erfNo = txtBoxID.Text.Trim();
            string buildingType = txtBoxFirstName.Text.Trim();
            string powerGrid = txtBoxLastName.Text.Trim();
            string buildingAddress = txtBoxEmail.Text.Trim();
            string city = txtBoxreplacer.Text.Trim();
            string suburb = txtBoxPhone.Text.Trim();
            string customerID = txtBoxAddress.Text.Trim();
            string numberOfRooms = txtBoxCity.Text.Trim();
            string floorCount = txtBoxFloorCount.Text.Trim();
            string areaInSqm = txtBoxSquare.Text.Trim();

            string query = "INSERT INTO BUILDING (Erf_No, Building_Type, PowerGrid, Building_Address, City, Suburb, Customer_IDNo, Number_of_rooms, Floor_count, Total_squareMeters) " +
                           "VALUES (@ErfNo, @BuildingType, @PowerGrid, @BuildingAddress, @City, @Suburb, @CustomerID, @NumberOfRooms, @FloorCount, @AreaInSqm)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ErfNo", erfNo);
                command.Parameters.AddWithValue("@BuildingType", buildingType);
                command.Parameters.AddWithValue("@PowerGrid", powerGrid);
                command.Parameters.AddWithValue("@BuildingAddress", buildingAddress);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Suburb", suburb);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@NumberOfRooms", numberOfRooms);
                command.Parameters.AddWithValue("@FloorCount", floorCount);
                command.Parameters.AddWithValue("@AreaInSqm", areaInSqm);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateDataGridView("BUILDING");
        }

        // Method to insert a record into the METER table.
        private void InsertIntoMeterTable(SqlConnection connection)
        {
            
            string meterNo = txtBoxID.Text.Trim();
            float meterReading = float.Parse(txtBoxFirstName.Text.Trim());
            string meterType = txtBoxLastName.Text.Trim();
            string erfNo = txtBoxEmail.Text.Trim();

            string query = "INSERT INTO METER (Meter_No, CurrentReading, Meter_Type, Erf_No) " +
                           "VALUES (@MeterNo, @MeterReading, @MeterType, @ErfNo)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MeterNo", meterNo);
                command.Parameters.AddWithValue("@MeterReading", meterReading);
                command.Parameters.AddWithValue("@MeterType", meterType);
                command.Parameters.AddWithValue("@ErfNo", erfNo);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateDataGridView("METER");
        }

        // Method to insert a record into the ACCOUNT table.
        private void InsertIntoAccountTable(SqlConnection connection)
        {
            
            string accountNumber = txtBoxID.Text.Trim();
            string customerID = txtBoxFirstName.Text.Trim();
            decimal billAmount = decimal.Parse(txtBoxLastName.Text.Trim());
            DateTime billDate = DateTime.Parse(txtBoxEmail.Text.Trim());

            string query = "INSERT INTO ACCOUNT (AccountNumber, Customer_IDNo, Bill, Bill_Date) " +
                           "VALUES (@AccountNumber, @CustomerID, @BillAmount, @BillDate)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@BillAmount", billAmount);
                command.Parameters.AddWithValue("@BillDate", billDate);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update a record in the ACCOUNT table.
        private void UpdateAccountTable(SqlConnection connection)
        {
            
            string accountNumber = txtBoxID.Text.Trim();
            string customerID = txtBoxFirstName.Text.Trim();
            decimal billAmount = decimal.Parse(txtBoxLastName.Text.Trim());
            DateTime billDate = DateTime.Parse(txtBoxEmail.Text.Trim());

            string query = "UPDATE ACCOUNT SET Customer_IDNo = @CustomerID, Bill = @BillAmount, Bill_Date = @BillDate " +
                           "WHERE AccountNumber = @AccountNumber";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@BillAmount", billAmount);
                command.Parameters.AddWithValue("@BillDate", billDate);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records found in ACCOUNT table with the provided account number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update a record in the CUSTOMER table.
        private void UpdateCustomerTable(SqlConnection connection)
        {
            
            string customerID = txtBoxID.Text.Trim();
            string firstName = txtBoxFirstName.Text.Trim();
            string lastName = txtBoxLastName.Text.Trim();
            string email = txtBoxEmail.Text.Trim();
            string gender = cmbGender.Text.Trim();
            string contactNumber = txtBoxPhone.Text.Trim();
            string address = txtBoxAddress.Text.Trim();
            string city = txtBoxCity.Text.Trim();

            string query = "UPDATE CUSTOMER SET Customer_FirstName = @FirstName, Customer_LastName = @LastName, " +
                           "Customer_Email = @Email, Customer_Gender = @Gender, ContactNumber = @ContactNumber, " +
                           "Residential_Address = @Address, City = @City WHERE Customer_IDNo = @CustomerID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records found in CUSTOMER table with the provided customer ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update a record in the BUILDING table.
        private void UpdateBuildingTable(SqlConnection connection)
        {
            // Assuming you have TextBoxes for each field in the BUILDING table.
            string erfNumber = txtBoxID.Text.Trim();
            string buildingType = txtBoxFirstName.Text.Trim();
            string powerGrid = txtBoxLastName.Text.Trim();
            string buildingAddress = txtBoxEmail.Text.Trim();
            string city = txtBoxCity.Text.Trim();
            string suburb = txtBoxPhone.Text.Trim();
            string customerID = txtBoxreplacer.Text.Trim();
            int numberOfRooms = int.Parse(txtBoxCity.Text.Trim());
            int floorCount = int.Parse(txtBoxFloorCount.Text.Trim());
            int areaInSqm = int.Parse(txtBoxSquare.Text.Trim());

            string query = "UPDATE BUILDING SET Building_Type = @BuildingType, PowerGrid = @PowerGrid, " +
                           "Building_Address = @BuildingAddress, City = @City, Suburb = @Suburb, " +
                           "Customer_IDNo = @CustomerID, Number_of_rooms = @NumberOfRooms, " +
                           "Floor_count = @FloorCount, Total_squareMeters = @AreaInSqm WHERE Erf_No = @ErfNumber";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BuildingType", buildingType);
                command.Parameters.AddWithValue("@PowerGrid", powerGrid);
                command.Parameters.AddWithValue("@BuildingAddress", buildingAddress);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Suburb", suburb);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@NumberOfRooms", numberOfRooms);
                command.Parameters.AddWithValue("@FloorCount", floorCount);
                command.Parameters.AddWithValue("@AreaInSqm", areaInSqm);
                command.Parameters.AddWithValue("@ErfNumber", erfNumber);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records found in BUILDING table with the provided Erf Number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update a record in the METER table.
        private void UpdateMeterTable(SqlConnection connection)
        {
            
            string meterNumber = txtBoxID.Text.Trim();
            float meterReading = float.Parse(txtBoxFirstName.Text.Trim());
            string meterType = txtBoxLastName.Text.Trim();
            string erfNumber = txtBoxEmail.Text.Trim();

            string query = "UPDATE METER SET CurrentReading = @MeterReading, Meter_Type = @MeterType " +
                           "WHERE Meter_No = @MeterNumber AND Erf_No = @ErfNumber";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MeterReading", meterReading);
                command.Parameters.AddWithValue("@MeterType", meterType);
                command.Parameters.AddWithValue("@MeterNumber", meterNumber);
                command.Parameters.AddWithValue("@ErfNumber", erfNumber);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records found in METER table with the provided Meter Number and Erf Number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {      

                // Check if an item is selected in the ComboBox
                if (cmbEntities.SelectedItem != null)
                {
                    string selectedTable = cmbEntities.SelectedItem.ToString();

                    string connectionString = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString; 

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        switch (selectedTable.ToUpper())
                        {
                            case "CUSTOMER":
                                UpdateCustomerTable(connection);
                                break;

                            case "BUILDING":
                                UpdateBuildingTable(connection);
                                break;

                            case "METER":
                                UpdateMeterTable(connection);
                                break;

                            case "ACCOUNT":
                                UpdateAccountTable(connection);
                                break;

                            default:
                                MessageBox.Show("Invalid Selection");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataGridView(string tableName)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString; 
                string query = "SELECT * FROM " + tableName;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            string searchKeywords = searchTextBox.Text.Trim();
            string selectedTable = tableComboBox.SelectedItem?.ToString();  // Get the selected table from the ComboBox, with null check
            string connectionString = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;

            try
            {
                if (string.IsNullOrEmpty(selectedTable))
                {
                    MessageBox.Show("Please select a table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "";  // Initialize an empty query

                    switch (selectedTable.ToUpper())
                    {
                        case "CUSTOMER":
                            query = "SELECT Customer_IDNo, Customer_FirstName, Customer_LastName, Customer_Email, Customer_Gender, ContactNumber, Residential_Address, City, '' AS AccountNumber, NULL AS Bill, NULL AS Bill_Date, NULL AS Erf_No, NULL AS Building_Type, NULL AS PowerGrid, NULL AS Building_Address, NULL AS Suburb, NULL AS Meter_No, NULL AS Meter_Reading, NULL AS Meter_Type " +
                                       "FROM CUSTOMER " +
                                       "WHERE Customer_IDNo LIKE @SearchKeywords OR Customer_FirstName LIKE @SearchKeywords OR Customer_LastName LIKE @SearchKeywords OR Customer_Email LIKE @SearchKeywords OR ContactNumber LIKE @SearchKeywords OR Residential_Address LIKE @SearchKeywords OR City LIKE @SearchKeywords";
                            break;
                        case "ACCOUNT":
                            query = "SELECT AccountNumber, Customer_IDNo, NULL, NULL, NULL, NULL, NULL, NULL, NULL, Bill, Bill_Date, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL " +
                                       "FROM ACCOUNT " +
                                       "WHERE AccountNumber LIKE @SearchKeywords OR Customer_IDNo LIKE @SearchKeywords OR Bill LIKE @SearchKeywords OR Bill_Date LIKE @SearchKeywords";
                            break;
                        case "BUILDING":
                            query = "SELECT NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, Erf_No, NULL, NULL, Building_Type, PowerGrid, Building_Address, Suburb, Customer_IDNo, NULL, NULL, NULL " +
                                       "FROM BUILDING " +
                                       "WHERE Erf_No LIKE @SearchKeywords OR Building_Type LIKE @SearchKeywords OR PowerGrid LIKE @SearchKeywords OR Building_Address LIKE @SearchKeywords OR Suburb LIKE @SearchKeywords OR Customer_IDNo LIKE @SearchKeywords";
                            break;
                        case "METER":
                            query = "SELECT NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, Meter_No, CurrentReading, Meter_Type " +
                                       "FROM METER " +
                                       "WHERE Meter_No LIKE @SearchKeywords OR CurrentReading LIKE @SearchKeywords OR Meter_Type LIKE @SearchKeywords";
                            break;

                        default:
                            // Handle any other cases or display an error message
                            MessageBox.Show("Invalid table selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchKeywords", "%" + searchKeywords + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // Clear previous contents
                        dataGridView1.DataSource = null;
                        dataGridView1.Columns.Clear();

                        // Display message if no match found
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching records found.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Bind the DataTable to the DataGridView
                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;

                            // Iterate through the rows and cells to highlight the search results
                            // Iterate through the rows and cells to highlight the search results
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchKeywords, StringComparison.OrdinalIgnoreCase) >= 0)
                                    {
                                        cell.Style.BackColor = Color.Yellow;  // Highlight the cell with a yellow background
                                        cell.Style.ForeColor = Color.Black;   // Set the text color to black for better visibility
                                        cell.Selected = true;                  // Select the cell for better visibility
                                        dataGridView1.FirstDisplayedScrollingRowIndex = cell.RowIndex;  // Scroll to the first occurrence of the search keyword
                                        break; // Exit the inner loop since we found a match in this row
                                    }
                                }
                            }

                        }
                    }
                }

                // Call PopulateDataGridView with the selected table name
                PopulateDataGridView(selectedTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //      private void searchButton_Click_1(object sender, EventArgs e) { }
        //        {
        //            string searchKeywords = searchTextBox.Text.Trim();
        //            string connectionString = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;

        //            try
        //            {
        //                using (SqlConnection connection = new SqlConnection(connectionString))
        //                {
        //                    connection.Open();

        //                    string query = "SELECT Customer_IDNo, Customer_FirstName, Customer_LastName, Customer_Email, Customer_Gender, ContactNumber, Residential_Address, City, '' AS AccountNumber, NULL AS Bill, NULL AS Bill_Date, NULL AS Erf_No, NULL AS Building_Type, NULL AS PowerGrid, NULL AS Building_Address, NULL AS Suburb, NULL AS Meter_No, NULL AS Meter_Reading, NULL AS Meter_Type " +
        //                                   "FROM CUSTOMER " +
        //                                   "WHERE Customer_IDNo LIKE @SearchKeywords " +
        //                                   "UNION " +
        //                                   "SELECT AccountNumber, Customer_IDNo, NULL, NULL, NULL, NULL, NULL, NULL, NULL, Bill, Bill_Date, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL " +
        //                                   "FROM ACCOUNT " +
        //                                   "WHERE AccountNumber LIKE @SearchKeywords " +
        //                                   "UNION " +
        //                                   "SELECT NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, Erf_No, NULL, NULL, Building_Type, PowerGrid, Building_Address, Suburb, Customer_IDNo, NULL, NULL, NULL " +
        //                                   "FROM BUILDING " +
        //                                   "WHERE Erf_No LIKE @SearchKeywords " +
        //                                   "UNION " +
        //                                   "SELECT NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, Meter_No, CurrentReading, Meter_Type " +
        //                                   "FROM METER " +
        //                                   "WHERE Meter_No LIKE @SearchKeywords";

        //                    using (SqlCommand command = new SqlCommand(query, connection))
        //                    {
        //                        command.Parameters.AddWithValue("@SearchKeywords", "%" + searchKeywords + "%");

        //                        SqlDataAdapter adapter = new SqlDataAdapter(command);
        //                        DataTable dataTable = new DataTable();

        //                        adapter.Fill(dataTable);

        //                        // Clear previous contents
        //                        dataGridView1.DataSource = null;
        //                        dataGridView1.Columns.Clear();

        //                        // Display message if no match found
        //                        if (dataTable.Rows.Count == 0)
        //                        {
        //                            MessageBox.Show("No matching records found.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        }
        //                        else
        //                        {
        //                            // Bind the DataTable to the DataGridView
        //                            dataGridView1.DataSource = dataTable;
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }


    }
}
