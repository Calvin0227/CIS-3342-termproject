using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace CIS_3342_TeamProject.Class
{
    public class Email
    {
        private MailMessage objMail = new MailMessage();

        private MailAddress toAddress;

        private MailAddress fromAddress;

        private String subject;

        private String messageBody;

        private String mailHost = "smtp.gmail.com";

        public void SendMail(String recipient, String sender, String subject, String body)
        {
            try
            {
                this.Recipient = recipient;
                this.Sender = sender;
                this.Subject = subject;
                this.Message = body;

                objMail.To.Add(this.toAddress);
                objMail.From = this.fromAddress;
                objMail.Subject = this.subject;
                objMail.Body = this.messageBody;

                SmtpClient smtpMailClient = new SmtpClient(this.mailHost);
                smtpMailClient.Credentials = new System.Net.NetworkCredential("cis3342teamproject@gmail.com", "LovePascucci");
                smtpMailClient.Send(objMail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public String Recipient
        {
            get { return this.toAddress.ToString(); }
            set { this.toAddress = new MailAddress(value); }
        }

        public String Sender
        {
            get { return this.fromAddress.ToString(); }
            set { this.fromAddress = new MailAddress(value); }
        }

        public String Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        public String Message
        {
            get { return this.messageBody; }
            set { this.messageBody = value; }
        }

        public String MailHost
        {
            get { return this.mailHost; }
            set { this.mailHost = value; }
        }

    }
}