using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Process
{
    public class EmailManager
    {
        public void SendEmail(string subject, string body, string Screenshotpath)
        {
            SmtpClient smtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage { From = new MailAddress("myEmailAdress@hotmail.com") };
            mail.To.Add("recipientEmail@gmail.com");
            mail.Subject = subject;
            mail.Body = body;
            mail.Attachments.Add(new Attachment(Screenshotpath));
            smtpServer.Port = 587;
            smtpServer.UseDefaultCredentials = false;
            smtpServer.Credentials = new System.Net.NetworkCredential("myEmailAdress@hotmail.com", "MyPassword");
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);
        }
    }
}
