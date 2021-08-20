using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Weixight.CExchange.Entity.Model;

namespace Weixight.CExchange.Infrastructure.Implemetation
{
    public class EmailDataWithAttachment : EmailData
    {
        public IFormFileCollection EmailAttachments { get; set; }
    }
}
