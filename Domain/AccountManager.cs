using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // HACK: this is a pretty silly, one-instance implementation, but I'm not interested in this management logic at the moment
    public static class AccountManager
    {
        private static BankAccount[] _bankAccounts;

        public static BankAccount[] GetBankAccounts()
        {
            if (_bankAccounts != null) return _bankAccounts;

            _bankAccounts = new BankAccount[]
            {
                new BankAccount
                {
                    AccountNumber = 1,
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
                    AccountNumber = 2,
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

            return _bankAccounts;
        }

        public static BankAccount GetBankAccount(int accountNumber)
        {
            var bankAccounts = GetBankAccounts();
            var bankAccount = bankAccounts.SingleOrDefault(x => x.AccountNumber == accountNumber);

            return bankAccount;
        }

        public static void AddBankAccount(BankAccount newBankAccount)
        {
            var bankAccounts = GetBankAccounts().ToList();
            bankAccounts.Add(newBankAccount);

            _bankAccounts = bankAccounts.ToArray();
        }

        public static void UpdateBankAccount(BankAccount source)
        {
            var bankAccount = GetBankAccount(source.AccountNumber);

            bankAccount.Balance = source.Balance;
            bankAccount.BankAccountType = source.BankAccountType;
            bankAccount.PrimaryAccountholder = source.PrimaryAccountholder;
        }

        public static void DeleteBankAccount(int id)
        {
            var bankAccounts = GetBankAccounts().ToList();
            bankAccounts.Remove(GetBankAccount(id));

            _bankAccounts = bankAccounts.ToArray();
        }
    }
}
