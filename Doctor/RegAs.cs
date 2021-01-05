using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public partial class RegAs : Form
    {
        public RegAs()
        {
            InitializeComponent();
        }

        private void RegAs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lDoc_Click(object sender, EventArgs e)
        {
            DoctorReg dreg = new DoctorReg();
            dreg.Show();
            this.Hide();
        }

        private void lPat_Click(object sender, EventArgs e)
        {
            PatientRegistration prg = new PatientRegistration();
            prg.Show();
            this.Hide();

        }

        private void lLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
