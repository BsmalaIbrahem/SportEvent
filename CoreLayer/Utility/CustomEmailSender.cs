using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Utility
{
    public class CustomEmailSender : IEmailSender, ICustomEmailSender
    {
        private readonly string _smtpServer = "smtp.gmail.com";
        private readonly int _smtpPort = 587;
        private readonly string _fromEmail = "bosiebrahem487@gmail.com";
        private readonly string _password = "yixy brdi xfvs gwip";

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return SendEmailAsync(email, subject, htmlMessage, null, null);
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage, List<byte[]> attachments = null, List<string> attachmentNames = null)
        {
            var client = new SmtpClient(_smtpServer, _smtpPort)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(_fromEmail, _password)
            };

            var mailMessage = new MailMessage(_fromEmail, email, subject, htmlMessage)
            {
                IsBodyHtml = true
            };

            if (attachments != null && attachments.Any() && attachmentNames != null && attachmentNames.Count == attachments.Count)
            {
                for (int i = 0; i < attachments.Count; i++)
                {
                    var attachment = new Attachment(new MemoryStream(attachments[i]), attachmentNames[i] ?? $"ticket_{i + 1}.pdf");
                    mailMessage.Attachments.Add(attachment);
                }
            }

            return client.SendMailAsync(mailMessage);
        }
    }
}
