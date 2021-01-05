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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lLogin_Click(object sender, EventArgs e)
        {
            string userName = lUName.Text;
            string pass = lUPass.Text;
            if (userName == "")
            {
                MessageBox.Show("Please enter your User name");

            }
            else if (pass == "")
                {
                    MessageBox.Show("Please enter your Password");
                }
            else
                {
                try
                {
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
                    connection.Open();

                    string query1 = "Select * from Users where Username= '" + userName + "' AND Password='" + pass + "';";
                    SqlDataAdapter com = new SqlDataAdapter(query1, connection);
                    DataTable dt = new DataTable();
                    com.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        string query = "Select Status from Users where Username= '" + userName + "' AND Password='" + pass + "';";
                        SqlCommand comm = new SqlCommand(query, connection);
                        SqlDataReader dr = comm.ExecuteReader();
                        while (dr.Read())
                        {
                            var gstat = dr.GetValue(0);
                            if ((string)gstat == "patient")
                            {
                                PatientProfile ptreg = new PatientProfile(userName);
                                ptreg.Show();
                                this.Hide();

                            }
                            else if ((string)gstat == "doctor")
                            {
                                DoctorProfile dp = new DoctorProfile(userName);
                                dp.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Error in status");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("please check your user name and password or create a new account");
                    }

                    
                         

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
            
        }

        private void lReg_Click(object sender, EventArgs e)
        {
            RegAs reg = new RegAs();
            reg.Show();
            this.Hide();
        }

        private void lUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
