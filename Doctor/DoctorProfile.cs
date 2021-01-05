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
    public partial class DoctorProfile : Form
    {
        public string userName;
        public DoctorProfile(string userName )
        {
            InitializeComponent();
            this.userName = userName;
            //MessageBox.Show(userName);

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            connection.Open();
            SqlCommand com = new SqlCommand("Select * from doctor_reg where Username = '"+ userName + "' ",connection);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                
                dPName.Text = dr.GetValue(1).ToString();
                dPUsername.Text = dr.GetValue(2).ToString();
                dPPassword.Text = dr.GetValue(3).ToString();
                dPEmail.Text = dr.GetValue(4).ToString();
                dPArea.Text = dr.GetValue(5).ToString();
                dPSpecialist.Text = dr.GetValue(6).ToString();
                dPGender.Text = dr.GetValue(7).ToString();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM doctor_reg WHERE Username='" + dPUsername.Text + "'";

            string sql2 = "DELETE  FROM Users WHERE Username='" + dPUsername.Text + "'";
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

        private void DoctorProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DoctorProfile_Load(object sender, EventArgs e)
        {

        }

        private void dPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dPLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void dPEdit_Click(object sender, EventArgs e)
        {
            DoctorClass dc = new DoctorClass();
            dc.D_name = dPName.Text;
            dc.D_username = dPUsername.Text;
            dc.D_password = dPPassword.Text;
            dc.D_email = dPEmail.Text;
            dc.D_area = dPArea.Text;
            dc.D_specialist = dPSpecialist.Text;
            dc.D_gender = dPGender.Text;


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            connection.Open();
            string sql = "UPDATE doctor_reg SET Name ='" + dc.D_name + "',  Password='" + dc.D_password + "', Email='" + dc.D_email + "' , Gender='" + dc.D_gender + "',Specialest='" + dc.D_specialist + "',Area='" + dc.D_area + "' WHERE Username= '" + dc.D_username + "' ";
            string sql2 = "UPDATE Users SET Password ='" + dc.D_password + "' WHERE Username= '" + dc.D_username + "'";

           
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

        private void button1_Click(object sender, EventArgs e)
        {
            string dEmail = dPEmail.Text;
            ShowAppointment show = new ShowAppointment(dEmail);
            show.Show();
            this.Hide();
        }
    }
}
