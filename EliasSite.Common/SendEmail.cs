using System.Net.Mail;

namespace Elias.Common
{
    public class SendEmail
    {
        public static void Send(string to,string subject,string body)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("elias.merati@gmail.com", " الیاس مرآتی");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                using (SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587))
                {
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("elias.merati@gmail.com", "fmne xloe brxv ttfs");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                }

            }
        }
    }
}