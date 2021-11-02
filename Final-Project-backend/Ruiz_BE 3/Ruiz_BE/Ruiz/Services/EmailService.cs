using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Services
{


    public interface IEmailService
    {
        void Send(string to, string subject, string html);
    }

    public class EmailService : IEmailService
    {
        public void Send(string to, string subject, string html)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("ruiz2021@yandex.com"));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.yandex.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("ruiz2021@yandex.com", "Kamil1812");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }

}
