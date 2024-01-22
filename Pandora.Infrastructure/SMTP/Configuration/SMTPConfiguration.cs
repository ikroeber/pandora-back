using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Infrastructure.SMTP.Configuration
{
    public class SMTPConfiguration
    {
        public string? FromEmail { get; set; }
        public string? Host { get; set; } = "localhost";
        public int Port { get; set; } = 25;
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool EnableSSL { get; set; } = false;
    }
}
