﻿
namespace Services.MailService
{
    public interface IMailService
    {
        void SendEmail(string toEmail, string message, string fromTitle = "", string Subject = "");
    }
}
