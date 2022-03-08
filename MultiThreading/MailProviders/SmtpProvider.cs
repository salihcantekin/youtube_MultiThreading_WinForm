using MultiThreading.MailProviders.Base;
using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.MailProviders
{
    public class SmtpProvider : BaseProvider
    {
        public override async Task Send(MailObject mailObject)
        {
            // Send email

            await Task.Delay(10);
            LogManager.Default.Log($"SmtpMail has sent to {mailObject.To}");
        }
    }
}
