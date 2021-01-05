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
    public partial class AppointmentStatus : Form
    {
        public string pEmail;
        public AppointmentStatus(string pEmail)
        {
            InitializeComponent();
            this.pEmail = pEmail;
            string query = "SELECT  d_email,p_email,message,date,status FROM appointment_req WHERE p_email='" + pEmail + "' ;";
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(command);
                    table.Load(dataReader);
                }
                else
                {
                    MessageBox.Show("No one Available");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.DataSource = table;
        }

        private void AppointmentStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
