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
using System.Windows.Forms.DataVisualization.Charting;

namespace KHP_PowerWatch
{
    public partial class RealTimeMonitoring : Form
    {
        string connec_string = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;
     
        private const float Threshold = 1000; // Threshold to detect unusual load (in kilowatts)
        private Chart consumptionChart;
        private int insertionCount = 0;

        public RealTimeMonitoring()
        {

            InitializeComponent();
            InsertRows();
            InitializeChart();

            StartMonitoring();
        }

        private void lblStaff_Load(object sender, EventArgs e)
        {
            lblStaff.Text = Login.loggedInStaff.ToString();
        }
        private bool AdjustElectricityConsumption(string connec_string, string meterNumber)
        {
            bool isAdjusted = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connec_string))
                {
                    var command = new SqlCommand("INSERT INTO ADJUSTMENT_LOG (Timestamp, Meter_No, Description) VALUES (@Timestamp, @MeterNumber, @Description)", connection);
                    command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                    command.Parameters.AddWithValue("@MeterNumber", meterNumber);
                    command.Parameters.AddWithValue("@Description", "Unusual load detected. Adjusting electricity consumption");

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isAdjusted = true;

                        // Reset consumption threshold
                        ResetConsumptionThreshold(connec_string, meterNumber);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                MessageBox.Show("Error during adjustment: " + ex.Message);
            }

            return isAdjusted;
        }

        private void ResetConsumptionThreshold(string connec_string, string meterNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connec_string))
                {
                    string query = "UPDATE ELECTRICITY_DATA SET Consumption = @Threshold WHERE Meter_No = @MeterNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Threshold", Threshold); // Set the normal threshold value
                        command.Parameters.AddWithValue("@MeterNumber", meterNumber);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                MessageBox.Show("Error resetting consumption threshold: " + ex.Message);
            }
        }

        private void InsertRows()
        {
            string connec_string = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;
            string[] meterNumbers = { "MO56H", "MO56K", "MO56Y", "MO90R" };
            DateTime currentDate = DateTime.Today;
            Random random = new Random();

            try
            {
                using (SqlConnection connection = new SqlConnection(connec_string))
                {
                    connection.Open();

                    string query = "INSERT INTO ELECTRICITY_DATA (Meter_No, Timestamp, Consumption) VALUES (@MeterNumber, @Timestamp, @Consumption)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@MeterNumber", SqlDbType.VarChar);
                        command.Parameters.Add("@Timestamp", SqlDbType.Date);
                        command.Parameters.Add("@Consumption", SqlDbType.Int);

                        for (int i = 0; i < 10; i++)
                        {
                            string meterNumber = meterNumbers[random.Next(0, meterNumbers.Length)];
                            DateTime timestamp = currentDate;
                            int consumption = random.Next(1001, 2000); // Generates a random value between 201 and 1000

                            command.Parameters["@MeterNumber"].Value = meterNumber;
                            command.Parameters["@Timestamp"].Value = timestamp;
                            command.Parameters["@Consumption"].Value = consumption;

                            command.ExecuteNonQuery();
                        }
                    }
                }

                //MessageBox.Show("Rows inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting rows: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initialize the chart control
        private void InitializeChart()
        {
            consumptionChart = new Chart();
            consumptionChart.Parent = this; // Set the parent form or container
            consumptionChart.Size = new Size(600, 400);
            consumptionChart.Location = new Point((this.ClientSize.Width - consumptionChart.Width) / 2, (this.ClientSize.Height - consumptionChart.Height) / 2);
            ChartArea chartArea = new ChartArea("Consumption"); // Create a new ChartArea
            consumptionChart.ChartAreas.Add(chartArea); // Add the ChartArea to the chart
            consumptionChart.Series.Add(new Series("ConsumptionSeries"));
            consumptionChart.Series["ConsumptionSeries"].ChartType = SeriesChartType.Line;
            consumptionChart.Series["ConsumptionSeries"].Points.Clear();
        }

        // Update the consumption chart with the ongoing consumption values
        private void UpdateConsumptionChart(float consumption)
        {
            consumptionChart.Series["ConsumptionSeries"].Points.AddY(consumption);
            
        }

        // Update the insertion count on the chart
        private void UpdateInsertionCount(int count)
        {
            consumptionChart.Series["ConsumptionSeries"].Points.AddXY("Total Adjustments", count);
            lblCount.Text = count.ToString();
        }

        // Modify the StartMonitoring method to update the chart
        private void StartMonitoring()
        {
            string connec_string = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;

            var timer = new Timer();
            timer.Interval = 10000; // Adjust the interval as per your requirements

            timer.Tick += (s, e) =>
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connec_string))
                    {
                        connection.Open();

                        string commandText = "SELECT Meter_No, Consumption FROM ELECTRICITY_DATA";
                        using (SqlCommand command = new SqlCommand(commandText, connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                string meterNumber = reader["Meter_No"].ToString();
                                float consumption = float.Parse(reader["Consumption"].ToString());
                                
                                if (consumption > Threshold)
                                {
                                   
                                    AdjustElectricityConsumption(connec_string, meterNumber);
                                    ResetConsumptionThreshold(connec_string, meterNumber);
                                    insertionCount++;
                                }

                                // Update the consumption chart
                                UpdateConsumptionChart(consumption);

                                // Update the insertion count on the chart
                                UpdateInsertionCount(insertionCount);
                            }

                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception or log the error
                    MessageBox.Show("Error during monitoring: " + ex.Message);
                }
            };

            timer.Start();
            InsertRows();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
           // StartMonitoring();
        }
    }
}
