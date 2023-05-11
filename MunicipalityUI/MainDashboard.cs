using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHP_PowerWatch
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Logo.Text = Login.loggedInStaff.ToString();
            this.Hide();
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
        }

        private void Logoutbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            lblStaff.Text = Login.loggedInStaff.ToString();
        }
    }
}
