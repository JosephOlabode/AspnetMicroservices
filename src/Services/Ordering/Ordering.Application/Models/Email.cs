using System;
using System.Security.Cryptography;

namespace Ordering.Application.Models
{
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public Email()
        {
        }
    }
}
