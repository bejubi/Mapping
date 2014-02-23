using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class AccountManager
    {
        public static BankAccount[] GetBankAccounts()
        {
            return new BankAccount[]
            {
                new BankAccount
                {
                    AccountNumber = "0001",
                    BankAccountType = AccountType.Checking,
                    Balance = 29.99M,
                    PrimaryAccountholder = new Accountholder
                    {
                        FirstName = "Jon",
                        LastName = "Doe",
                        ResidenceAddress = new Address
                        {
                            AddressLine1 = "1234 Main St.",
                            AddressLine2 = "Apt. A",
                            City = "Anytown",
                            State = "WI",
                            PostalCode = "12345"
                        }
                    }
                },
                new BankAccount
                {
                    AccountNumber = "0002",
                    BankAccountType = AccountType.Savings,
                    Balance = 129.99M,
                    PrimaryAccountholder = new Accountholder
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                        ResidenceAddress = new Address
                        {
                            AddressLine1 = "1234 Main St.",
                            AddressLine2 = "Apt. A",
                            City = "Anytown",
                            State = "WI",
                            PostalCode = "12345"
                        }
                    }
                },
            };
        }

        public static void UpdateBankAccount(BankAccount account)
        {
            throw new NotImplementedException();
        }
    }
}
