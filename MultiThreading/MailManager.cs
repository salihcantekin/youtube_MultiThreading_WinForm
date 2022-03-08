using MultiThreading.MailProviders;
using MultiThreading.MailProviders.Base;
using MultiThreading.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class MailManager
    {
        private readonly ConcurrentQueue<MailObject> mailObjects = new ConcurrentQueue<MailObject>();
        private readonly ConcurrentDictionary<MailProviderType, BaseProvider> 
            mailProviders = new ConcurrentDictionary<MailProviderType, BaseProvider>();


        public void AddMails(IEnumerable<MailObject> mails)
        {
            foreach (var mail in mails)
            {
                mailObjects.Enqueue(mail);
            }
        }

        public async Task SendAllMails()
        {
            LogManager.Default.Log("SendAllMails started!");
            LogManager.Default.Log($"{mailObjects.Count} mails found!");

            var smtpProvider = new SmtpProvider();

            while (mailObjects.Count > 0)
            {
                mailObjects.TryDequeue(out MailObject mail);
                var provider = GetProvider(mail.ProviderType);
                await provider.Send(mail);
            }

            LogManager.Default.Log("SendAllMails finished!");
        }

        private BaseProvider GetProvider(MailProviderType mailProviderType)
        {
            return mailProviders.GetOrAdd(mailProviderType, (x) => MailProviderFactory.CreateProvider(mailProviderType));
        }

    }
}
