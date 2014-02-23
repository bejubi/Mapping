using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Mappers
{
    public static class AccountMapper
    {
        public static Models.Account Map(this Domain.BankAccount source)
        {
            if (source == null) return null;

            var target = new Account
            {
                AcctNumber = source.AccountNumber,
                AcctBalance = source.Balance,
                AcctType = source.BankAccountType.Map(),
                AcctHolder = source.PrimaryAccountholder.Map(),
            };

            return target;
        }

        public static Models.Account[] Map(this Domain.BankAccount[] source)
        {
            if (source == null) return null;

            var target = new List<Models.Account>();
            foreach (var item in source)
            {
                target.Add(item.Map());
            }

            return target.ToArray();
        }

        public static Domain.BankAccount Map(this Account source)
        {
            if (source == null) return null;

            var target = new Domain.BankAccount
            {
                AccountNumber = source.AcctNumber,
                BankAccountType = source.AcctType.MapToAccountType(),
                Balance = source.AcctBalance,
                PrimaryAccountholder = source.AcctHolder.Map(),
            };

            return target;
        }

        public static void MapToExisting(this Domain.BankAccount source, Account target)
        {
            if (source == null) target = null;
            else if (target == null)
                target = new Account();

            target.AcctNumber = source.AccountNumber;
            target.AcctType = source.BankAccountType.Map();
            target.AcctBalance = source.Balance;
            source.PrimaryAccountholder.MapToExisting(target.AcctHolder);
        }
    }
}