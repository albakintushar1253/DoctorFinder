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
    public partial class DoctorReg : Form
    {
        public DoctorReg()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoctorReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dRSign_Click(object sender, EventArgs e)
        {
            string name = dRName.Text;
            string userName = dRUName.Text;
            string pass = dRPass.Text;
            string email = dREmail.Text;
            string area = dRArea.Text;
            string gender = dRGender.Text;
            string conPass = dRCPass.Text;
            string special = dRSpecialist.Text;

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
            else if (special == "")
            {
                MessageBox.Show("Please enter your Specialest");
            }
            else
            {
                try
                { 
                    string sql3 = "SELECT Username FROM doctor_reg  WHERE Username ='" + userName + "' ;";

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
                        string sql = "INSERT INTO doctor_reg(Name,Username,Password,Email,Area,Specialest,Gender,Status) " +
                        "VALUES('" + name + "','" + userName + "','" + pass + "','" + email + "','" + area + "','" + special + "','" + gender + "','" + "doctor" + "')";

                        string sql2 = "INSERT INTO Users (Username,Password,Status) " +
                            "VALUES('" + userName + "','" + pass + "','" + "doctor" + "')";

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

        private void dRBack_Click(object sender, EventArgs e)
        {
            RegAs reg = new RegAs();
            reg.Show();
            this.Hide();
        }

        private void dRSpecialist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
