using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace MTGWebsite.Models
{
    public class GmailEmailRepository : IEmailRepository
    {
        string emailAccount = System.Environment.GetEnvironmentVariable("GatheringEmailAccount");
        string emailPassword = System.Environment.GetEnvironmentVariable("GatheringEmailPassword");
        public void Send(string to, string subject, string body)
        {
            try
            {
                MailMessage email = new MailMessage();
                email.From = new MailAddress(emailAccount);
                email.To.Add(to);
                email.Subject = subject;
                email.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(emailAccount, emailPassword);
                smtp.EnableSsl = true;
                smtp.Send(email);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
