using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailSend
{
    public partial class Form1 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage mail;

        public Form1()
        {
            InitializeComponent();
            
        }


        public void ResetText()
        {
            txtTo.ResetText();
            txtCC.ResetText();
            txtID.ResetText();
            txtName.ResetText();
            txtSubject.ResetText();
            txtMessage.ResetText();

            txtEmailSender.ResetText();
            txtEmailPassowrd.ResetText();
            chkSSL.Checked=false;
        }

        private void btnSend_MouseClick(object sender, MouseEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Send a Message", "Are you sure ?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    login = new NetworkCredential(txtEmailSender.Text,txtEmailPassowrd.Text);
                    client = new SmtpClient(txtSmpt.Text);
                    client.Port = Convert.ToInt32(txtPort.Text);
                    //client.EnableSsl = true;
                    client.EnableSsl = chkSSL.Checked;
                    client.Credentials = login;

                    mail = new MailMessage();
                    mail.From = new MailAddress(txtEmailSender.Text);

                    mail.To.Add(txtTo.Text);

                    if(!string.IsNullOrEmpty(txtCC.Text))
                    {
                        mail.To.Add(txtCC.Text);
                    }

                    mail.Subject = txtSubject.Text;
                    mail.Body = "<p>" + label1.Text.ToString() + " : " + txtID.Text.ToString() +
                                "<br>" + label2.Text.ToString() + " : " + txtName.Text.ToString() +
                                "<br>" + label4.Text.ToString() + " : " + txtMessage.Text.ToString() + " </p> ";

                    mail.BodyEncoding = Encoding.UTF8;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.Normal;
                    client.Send(mail);
                    //mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    //client.SendCompleted+=new SendCompletedEventHandler(SendCompletedStatus);

                    //string userstate = "Sending...";
                    MessageBox.Show("Your Message has been Successfully Sent !!!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message did not sent !!!");
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Send Canceled.", "Cancel Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            ResetText();
        }

        private void btnAccept_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Send a Reply Message", "Are you sure ?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    login = new NetworkCredential(txtEmailSender.Text, txtEmailPassowrd.Text);
                    client = new SmtpClient(txtSmpt.Text);
                    client.Port = Convert.ToInt32(txtPort.Text);
                    //client.EnableSsl = true;
                    client.EnableSsl = chkSSL.Checked;
                    client.Credentials = login;

                    mail = new MailMessage();
                    mail.From = new MailAddress(txtEmailSender.Text);

                    mail.To.Add(txtTo.Text);

                    if (!string.IsNullOrEmpty(txtCC.Text))
                    {
                        mail.To.Add(txtCC.Text);
                    }

                    mail.Subject = txtSubject.Text;
                    mail.Body = "<p>" + label1.Text.ToString() + " : " + txtID.Text.ToString() +
                                "<br>" + label2.Text.ToString() + " : " + txtName.Text.ToString() +
                                "<br> Your Request has been Accepted !!! </p> ";

                    mail.BodyEncoding = Encoding.UTF8;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.Normal;
                    client.Send(mail);
                    //mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    //client.SendCompleted+=new SendCompletedEventHandler(SendCompletedStatus);

                    //string userstate = "Sending...";
                    MessageBox.Show("Your Message has been Successfully Sent !!!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message did not sent !!!");
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Send Canceled.", "Cancel Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ResetText();
        }

        private void btnReject_MouseClick(object sender, MouseEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Send a Reply Message", "Are you sure ?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    login = new NetworkCredential(txtEmailSender.Text, txtEmailPassowrd.Text);
                    client = new SmtpClient(txtSmpt.Text);
                    client.Port = Convert.ToInt32(txtPort.Text);
                    //client.EnableSsl = true;
                    client.EnableSsl = chkSSL.Checked;
                    client.Credentials = login;

                    mail = new MailMessage();
                    mail.From = new MailAddress(txtEmailSender.Text);

                    mail.To.Add(txtTo.Text);

                    if (!string.IsNullOrEmpty(txtCC.Text))
                    {
                        mail.To.Add(txtCC.Text);
                    }

                    mail.Subject = txtSubject.Text;
                    mail.Body = "<p>" + label1.Text.ToString() + " : " + txtID.Text.ToString() +
                                "<br>" + label2.Text.ToString() + " : " + txtName.Text.ToString() +
                                "<br> Your Request has been Rejected !!! </p> ";

                    mail.BodyEncoding = Encoding.UTF8;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.Normal;
                    client.Send(mail);
                    //mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    //client.SendCompleted+=new SendCompletedEventHandler(SendCompletedStatus);

                    //string userstate = "Sending...";
                    MessageBox.Show("Your Message has been Successfully Sent !!!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message did not sent !!!");
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Send Canceled.", "Cancel Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ResetText();
        }


    }
}
