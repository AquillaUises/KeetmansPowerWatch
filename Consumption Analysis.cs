﻿using System;
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
    public partial class Consumption_Analysis : Form
    {
        public Consumption_Analysis()
        {
            InitializeComponent();
        }

        private void RMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Realtime_Monitoring realtime_Monitoring = new Realtime_Monitoring();
            realtime_Monitoring.Show();
        }

        private void CAbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consumption_Analysis consumption_Analysis = new Consumption_Analysis();
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
            Database_Management database_Management = new Database_Management();
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
            Consumption_Analysis consumption_Analysis = new Consumption_Analysis();
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
            Database_Management database_Management = new Database_Management();
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
    }
}