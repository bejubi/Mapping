using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Mappers
{
    public static class AcctTypeMapper
    {
        public static string Map(this Domain.AccountType source)
        {
            string target;

            switch (source)
            {
                case Domain.AccountType.Checking:
                    target = "Checking";
                    break;
                case Domain.AccountType.Savings:
                    target = "Savings";
                    break;
                default:
                    target = "Other";
                    break;
            }

            return target;
        }

        public static Domain.AccountType MapToAccountType(this string source)
        {
            if (string.IsNullOrEmpty(source)) throw new ArgumentNullException("source");

            var target = Domain.AccountType.Unknown;

            switch (source)
            {
                case "Checking":
                    target = Domain.AccountType.Checking;
                    break;
                case "Savings":
                    target = Domain.AccountType.Savings;
                    break;
                default:
                    target = Domain.AccountType.Unknown;
                    break;
            }

            return target;
        }
    }
}