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
    public partial class PatientProfile : Form
    {
        public string userName;
        public PatientProfile(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            connection.Open();
            SqlCommand com = new SqlCommand("Select * from patientsignup where Username = '" + userName + "' ", connection);
            SqlDataReader pr = com.ExecuteReader();
            while (pr.Read())
            {

                pPName.Text = pr.GetValue(1).ToString();
                pPUsername.Text = pr.GetValue(2).ToString();
                pPPassword.Text = pr.GetValue(3).ToString();
                pPEmail.Text = pr.GetValue(4).ToString();
                pPArea.Text = pr.GetValue(5).ToString();
                //pPSpecialist.Text = dr.GetValue(6).ToString();
                pPGender.Text = pr.GetValue(6).ToString();
            }
        }

        private void PatientProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pEditButton_Click(object sender, EventArgs e)
        {
            PatientClass pc = new PatientClass();
            pc.P_name = pPName.Text;
            pc.P_username = pPUsername.Text;
            pc.P_password = pPPassword.Text;
            pc.P_email = pPEmail.Text;
            pc.P_area = pPArea.Text;
            //dc.P_specialist = dPSpecialist.Text;
            pc.P_gender = pPGender.Text;


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            connection.Open();
            string sql = "UPDATE patientsignup SET Name ='" + pc.P_name + "',  Password='" + pc.P_password + "', Email='" + pc.P_email + "' , Gender='" + pc.P_gender + "',Area='" + pc.P_area + "' WHERE Username= '" +pc.P_username + "' ";
            string sql2 = "UPDATE Users SET Password ='" + pc.P_password + "' WHERE Username= '" + pc.P_username + "'";


            SqlCommand commend = new SqlCommand(sql, connection);
            SqlCommand commend2 = new SqlCommand(sql2, connection);

            int result = commend.ExecuteNonQuery();
            int result2 = commend2.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("error");
            }
            if (result2 > 0)
            {
                MessageBox.Show("Updated");
                //Login log = new Login();
                //log.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void pDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM patientsignup WHERE Username='" + pPUsername.Text + "'";

            string sql2 = "DELETE  FROM Users WHERE Username='" + pPUsername.Text + "'";
            SqlCommand commend = new SqlCommand(sql, connection);
            SqlCommand commend2 = new SqlCommand(sql2, connection);

            int result = commend.ExecuteNonQuery();
            int result2 = commend2.ExecuteNonQuery();
            if (result > 0)
            {
                // MessageBox.Show("deleted");
            }
            else
            {
                // MessageBox.Show("error");
            }
            if (result2 > 0)
            {
                MessageBox.Show("Deleted");
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void pBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void ppSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pEmail = pPEmail.Text;
            AppointmentStatus show = new AppointmentStatus(pEmail);
            show.Show();
            this.Hide();
        }
    }
}
