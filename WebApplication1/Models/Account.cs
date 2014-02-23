using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Account
    {
        public string AcctNumber { get; set; }
        public decimal AcctBalance { get; set; }
        public string AcctType { get; set; }
        public Person AcctHolder { get; set; }
    }
}