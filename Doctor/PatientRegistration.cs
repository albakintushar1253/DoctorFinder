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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void pRBack_Click(object sender, EventArgs e)
        {
            RegAs reg = new RegAs();
            reg.Show();
            this.Hide();
        }

        private void PatientRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void pRSign_Click(object sender, EventArgs e)
        {
            string name = pRName.Text;
            string userName = pRUName.Text;
            string pass = pRPass.Text;
            string email = pREmail.Text;
            string area = pRArea.Text;
            string gender = pRGender.Text;
            string conPass = pRCPass.Text;


            if (name == "")
            {
                MessageBox.Show("Please enter you name");
            }
            else if (userName == "")
            {
                MessageBox.Show("Please enter your User name");
            }
            else if (pass == "")
            {
                MessageBox.Show("Please enter your Password");
            }
            else if (conPass != pass)
            {
                MessageBox.Show("Password is not same");
            }
            else if (email == "")
            {
                MessageBox.Show("Please enter your Email");
            }
            else if (!email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Email is invalid");
            }
            else if (area == "")
            {
                MessageBox.Show("Please enter your Area");
            }
            else if (gender == "")
            {
                MessageBox.Show("Please enter your Gender");
            }
            else
            {
                try
                {
                    string sql3 = "SELECT Username FROM patientsignup  WHERE Username ='" + userName + "' ;";

                    DataTable table = new DataTable();
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
                    SqlCommand command = new SqlCommand(sql3, connection);
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("Already use this username");
                    }
                    else
                    {
                        string sql = "INSERT INTO patientsignup(Name,Username,Password,Email,Area,Gender,Status) " +
                        "VALUES('" + name + "','" + userName + "','" + pass + "','" + email + "','" + area + "','" + gender + "','" + "patient" + "')";

                        string sql2 = "INSERT INTO Users (Username,Password,Status) " +
                            "VALUES('" + userName + "','" + pass + "','" + "patient" + "')";

                        SqlCommand commend = new SqlCommand(sql, connection);
                        SqlCommand commend2 = new SqlCommand(sql2, connection);
                        int result = commend.ExecuteNonQuery();
                        int result2 = commend2.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("successfull");
                        }
                        else
                        {
                            MessageBox.Show("error");
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
