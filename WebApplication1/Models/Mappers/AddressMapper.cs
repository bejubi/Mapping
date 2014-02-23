using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Mappers
{
    public static class AddressMapper
    {
        public static Domain.Address MapToAddress(this Person source)
        {
            if (source == null) return null;

            var target = new Domain.Address
            {
                AddressLine1 = source.Address1,
                AddressLine2 = source.Address2,
                City = source.City,
                State = source.State,
                PostalCode = source.Zip,
            };

            return target;
        }

        public static void MapToExisting(this Domain.Address source, Person target)
        {
            if (target == null) throw new ArgumentNullException("target");

            if (source == null)
            {
                target.Address1 = null;
                target.Address2 = null;
                target.City = null;
                target.State = null;
                target.Zip = null;
                target.Country = null;
            }
            else
            {
                target.Address1 = source.AddressLine1;
                target.Address2 = source.AddressLine2;
                target.City = source.City;
                target.State = source.State;
                target.Zip = source.PostalCode;
                // don't map Country this because  it's not mapping... it's a defaulting decision
            }
        }
    }
}