using KHP_PowerWatch.DAL;
using KHP_PowerWatch.StaffLL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        StaffLogin stf = new StaffLogin();
        UserDAL dal = new UserDAL();
        public static string loggedInStaff;

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            stf.username = txtBoxUsername.Text.Trim();
            stf.password = txtBoxPassword.Text.Trim();

            bool success = dal.loginCheck(stf);

            if (success == true)
            {
                loggedInStaff = stf.username;
                this.Hide();
                MainDashboard mainDashboard = new MainDashboard();
                mainDashboard.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials Provided!!");
                txtBoxUsername.Clear();
                txtBoxPassword.Clear();
                txtBoxUsername.Focus(); 
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Reset_Password reset_Password = new Reset_Password();
            reset_Password.Show();
            // Forgot_password forgot_Password = new Forgot_password();
            // forgot_Password.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loginbtn.PerformClick();
            }
        }
    }
}
