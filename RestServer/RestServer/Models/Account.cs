using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServer.Models
{
    public class Account
    {
        public long id { get; set; }
        public string accountName { get; set; }
        public long accountNumber { get; set; }
        public long accountBalance { get; set; }
               

    }
}