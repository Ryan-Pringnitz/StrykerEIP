using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace PfizerEIP
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {   
            InitializeComponent();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
         
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            string SendersAddress = "cisstryker4990@gmail.com"; //The users address
            string ReceiversAddress = "woofy181st@gmail.com"; //Receivers address
            string SendersPassword = "Targowski"; //Users gmail password 
            string subject = "Stryker Dashboard Help Request from " + txtName.ToString(); //Standard subject line
            string body = txtQuestion.ToString(); //Users help request / question.

            try
            {
                //Attempts to send email through gmail
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(SendersAddress, SendersPassword),
                    Timeout = 3000
                };

                MailMessage message = new MailMessage(SendersAddress, ReceiversAddress, subject, body);

                smtp.Send(message);
                MessageBox.Show("Message Sent Successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Closes the form without sending
            this.Close();
        }
    }
}
