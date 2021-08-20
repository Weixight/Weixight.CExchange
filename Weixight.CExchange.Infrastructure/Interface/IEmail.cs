using System;
using System.Collections.Generic;
using System.Text;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Infrastructure.Implemetation;

namespace Weixight.CExchange.Service.Interface
{
     public  interface IEmail
    {
        bool SendEmail(EmailData emailData);
        bool SendEmailWithAttachment(EmailDataWithAttachment emailData);
        bool SendUserEmailTemplate(UserData userData);
    }
}
