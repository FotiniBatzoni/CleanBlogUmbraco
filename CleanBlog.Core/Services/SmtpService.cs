﻿using CleanBlog.Core.Controllers;
using CleanBlog.Core.ViewModels;
using Umbraco.Core.Logging;
using System;
using System.Net.Mail;


namespace CleanBlog.Core.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly ILogger _logger;
        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }

        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                string toAddress = "to@test.com";
                string fromAddress = "from@test.com";
                message.Subject = $"Enquiry from : {model.Name} - {model.Email}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);

                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(typeof(ContactSurfaceController), ex, "Error sending Contact Form");
                return false;
            }
        }
    }
}
