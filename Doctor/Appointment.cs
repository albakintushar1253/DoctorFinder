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

namespace Doctor
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void mSSend_Click(object sender, EventArgs e)
        {
            if (aPemail.Text == null)
            {
                MessageBox.Show("Pleae Enter your email");
            }
            if (aDemail.Text == null)
            {
                MessageBox.Show("Pleae Enter doctors email");
            }


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            connection.Open();
            string sql = " INSERT into appointment_req (d_email,p_email,message,date) Values ('" + aDemail.Text + "','" + aPemail.Text + "','" + aMassage.Text + "','" + adate.Text + "'); ";
            SqlCommand commend = new SqlCommand(sql, connection);
            int result = commend.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Send successfully");
            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void Appointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
