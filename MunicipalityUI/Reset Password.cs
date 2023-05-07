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
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        StaffLogin stf = new StaffLogin();
        UserDAL dal = new UserDAL();

        private void button1_Click(object sender, EventArgs e)
        {
            stf.username = usernametxtbox.Text.Trim();
            stf.password = textBox1.Text.Trim();
            stf.password = textBox2.Text.Trim();

            bool success = false;

            if (textBox1.Text.Equals(textBox2.Text))
            {
                success = dal.resetPassword(stf);
            }
            else if (!textBox1.Text.Equals(textBox2.Text))
            {
                MessageBox.Show("Unmatched Passwords!!");
            }

            if (success == true)
            {
                MessageBox.Show("Password Reset successfully!!");
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            textBox3.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
