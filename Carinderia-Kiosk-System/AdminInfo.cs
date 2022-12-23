using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carinderia_Kiosk_System
{
    public class AdminInfo
    {
        public int ID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string StoreName { get; set; }

        public string Location { get; set; }

        public string ContactNum { get; set; }

        public static string EmailAddress { get; set; }

        public string Password { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }
    }
}
