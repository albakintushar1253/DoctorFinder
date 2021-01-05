using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void mSSend_Click(object sender, EventArgs e)
        {
            String to, from, pass, mail;
            to = (mSTo.Text).ToString();
            from = (mSFrom.Text).ToString();
            pass = (mSPassword.Text).ToString();
            mail = (mSMail.Text).ToString();
            
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = mSSubject.Text;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Eamil send successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void Email_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
