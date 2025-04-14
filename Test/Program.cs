using System.Net;
using System.Net.Mail;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SendEmail("quachthekiet.private@gmail.com", "Lộ mail trong project rồi bạn", "This is a test email.");
        }
        static void SendEmail(string toEmail, string subject, string body)
        {
            string smtpHost = "smtp.gmail.com";
            int smtpPort = 587;
            string senderEmail = "vuthanhtruong1280@gmail.com";
            string senderPassword = "zmtvwgnoysvmsjyo";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed to send email: " + ex.Message);
            }
        }
    }
}
