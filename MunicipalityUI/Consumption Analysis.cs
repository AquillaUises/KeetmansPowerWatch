using KHP_PowerWatch;
using LiveCharts.Wpf;
using LiveCharts;
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
    public partial class ConsumptionAnalysis : Form
    {
        static string connec_string = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;
        public ConsumptionAnalysis()
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

        private void txtView_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();

            FillDataGridView1();
            try
            {
                SeriesCollection series = new SeriesCollection();
                var years = (from o in yearlyConsumptionBindingSource.DataSource as List<YearlyConsumption> select new { Year = o.Year }).Distinct();

                foreach (var year in years)
                {
                    List<float> values = new List<float>();
                    for (int month = 1; month <= 12; month++)
                    {
                        float value = 0;
                        var data = from o in yearlyConsumptionBindingSource.DataSource as List<YearlyConsumption>
                                   where o.Year.Equals(year.Year) && o.Month.Equals(month)
                                   orderby o.Month ascending
                                   select new { o.Units_Purchased, o.Month };

                        if (data.SingleOrDefault() != null)
                        {
                            value = data.SingleOrDefault().Units_Purchased;
                        }
                        values.Add(value);
                    }
                    series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<float>(values) });

                }
                cartesianChart1.Series = series;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FillDataGridView()
        {
            SqlConnection conn = new SqlConnection(connec_string);

            try
            {
                conn.Open();

                string query = "SELECT * FROM PURCHASE_HISTORY WHERE AccountNumber = @AccountNumber ORDER BY Purchase_Date ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountNumber", txtBoxAccount.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                DGVPurchaseHist.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void ViewBill()
        {
            SqlConnection conn = new SqlConnection(connec_string);

            try
            {
                conn.Open();

                string query = "SELECT * FROM ACCOUNT WHERE AccountNumber = @AccountNumber";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountNumber", txtBoxAccount.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                DGVPurchaseHist.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FillDataGridView1()
        {
            SqlConnection conn = new SqlConnection(connec_string);
            conn.Open();

            string query = "SELECT Purchase_Date, Units_purchased " +
                           "FROM PURCHASE_HISTORY " +
                           "WHERE AccountNumber = @AccountNumber " +
                           "ORDER BY Purchase_Date ASC";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AccountNumber", txtBoxAccount.Text.Trim());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            Dictionary<int, Dictionary<int, float>> yearlyConsumptions = new Dictionary<int, Dictionary<int, float>>();

            // Populate the YearlyConsumption dictionary
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime purchaseDate = (DateTime)row["Purchase_Date"];
                int year = purchaseDate.Year;
                int month = purchaseDate.Month;
                float unitsPurchased = Convert.ToSingle(row["Units_purchased"]);

                if (!yearlyConsumptions.ContainsKey(year))
                {
                    yearlyConsumptions[year] = new Dictionary<int, float>();
                }

                if (!yearlyConsumptions[year].ContainsKey(month))
                {
                    yearlyConsumptions[year][month] = unitsPurchased;
                }
                else
                {
                    yearlyConsumptions[year][month] += unitsPurchased;
                }
            }

            conn.Close();

            List<YearlyConsumption> consumptionList = new List<YearlyConsumption>();

            // Convert the dictionary to a list of YearlyConsumption objects
            foreach (var yearEntry in yearlyConsumptions)
            {
                int year = yearEntry.Key;
                foreach (var monthEntry in yearEntry.Value)
                {
                    int month = monthEntry.Key;
                    float unitsPurchased = monthEntry.Value;

                    consumptionList.Add(new YearlyConsumption(year, month, unitsPurchased));
                }
            }

            // Set the consumptionList as the data source for the bindingSource
            yearlyConsumptionBindingSource.DataSource = consumptionList;

            // Set the bindingSource as the data source for the dataGridView1
            dataGridView1.DataSource = yearlyConsumptionBindingSource;

            // Auto-fill Year, Month, and Units_purchased columns if they exist
            if (dataGridView1.Columns.Contains("Year"))
            {
                dataGridView1.Columns["Year"].DataPropertyName = "Year";
                dataGridView1.Columns["Year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (dataGridView1.Columns.Contains("Month"))
            {
                dataGridView1.Columns["Month"].DataPropertyName = "Month";
                dataGridView1.Columns["Month"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (dataGridView1.Columns.Contains("Units_purchased"))
            {
                dataGridView1.Columns["Units_purchased"].DataPropertyName = "Units_Purchased";
                dataGridView1.Columns["Units_purchased"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }



        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            FillDataGridView();
            
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            ViewBill();
        }

        private void btnViewBill_Click_1(object sender, EventArgs e)
        {
            ViewBill();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
        }

        private void DGVPurchaseHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsumptionAnalysis_Load(object sender, EventArgs e)
        {
            lblStaff.Text = Login.loggedInStaff.ToString();

            txtBoxAccount.Focus();
            yearlyConsumptionBindingSource.DataSource = new List<YearlyConsumption>();

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {

                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Yearly Consumption",
                LabelFormatter = value => value.ToString("kwh")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        static string connec = ConfigurationManager.ConnectionStrings["connec_string"].ConnectionString;

        private void YearlyConsumption_Load(object sender, EventArgs e)
        {
        }

        private void Populategrid()
        {
            SqlConnection conn = new SqlConnection(connec);

            try
            {
                conn.Open();

                string query = "SELECT * FROM PURCHASE_HISTORY WHERE AccountNumber = @AccountNumber ORDER BY Purchase_Date ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountNumber", txtBoxAccount.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                DGVPurchaseHist.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnViewUsagePurchase_Click(object sender, EventArgs e)
        {
            Populategrid();
        }

        private void txtBoxAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnViewHistory.PerformClick();
            }
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

        private void PGbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PowerGrid_Simulator powerGrid_Simulator = new PowerGrid_Simulator();
            powerGrid_Simulator.Show();
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

        private void PGbtn_Click_2(object sender, EventArgs e)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
