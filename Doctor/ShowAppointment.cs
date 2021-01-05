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
   
    public partial class ShowAppointment : Form
    {
        public string dEmail;
        public ShowAppointment(string dEmail)
        {
            InitializeComponent();
            this.dEmail = dEmail;

            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            //connection.Open();
            string query = "SELECT  d_email,p_email,message,date FROM appointment_req WHERE d_email='" + dEmail + "' ;";
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

        private void ShowAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["doctorfinder"].ConnectionString);
            connection.Open();
            string sql = "UPDATE appointment_req SET status ='" + "Approved" + "'";

            SqlCommand commend = new SqlCommand(sql, connection);
            int result = commend.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("successfull");
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
