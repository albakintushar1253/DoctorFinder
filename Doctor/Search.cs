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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string special = sSpecialist.Text;
            string area = sArea.Text;

            string query = "SELECT Name,Email,Area,Specialest,Gender FROM doctor_reg  WHERE Specialest ='"+special+ "' and Area ='"+area+"' ;";
            

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

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void appoinment_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Appointment search = new Appointment();
            search.Show();
            this.Hide();
        }
    }
}
