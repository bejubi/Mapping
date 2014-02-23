using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public Accountholder PrimaryAccountholder { get; set; }
        public AccountType BankAccountType { get; set; }
        public decimal Balance { get; set; }
    }
}
