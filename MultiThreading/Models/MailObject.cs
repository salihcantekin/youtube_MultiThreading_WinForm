using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.Models
{
    public class MailObject
    {
        public string To { get; set; }

        public string From { get; set; } = "salihcantekin@gmail.com";

        public MailProviderType ProviderType { get; set; }
    }

    public enum MailProviderType
    {
        Smtp = 1,
        GoogleMail = 2
    }
}
