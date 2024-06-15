
using System.Net;
using System.Net.Mail;

namespace EcommerceMVC.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "ngtienanh202@gmail.com";
            var password = "sais bqmr bbrp eeap";

            var client = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, password),
            };

            return client.SendMailAsync(new MailMessage(from: mail, to: email, subject, message) { IsBodyHtml = true });
        }
    }
}
