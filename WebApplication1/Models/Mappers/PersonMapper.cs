using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Mappers
{
    public static class PersonMapper
    {
        public static Person Map(this Domain.Accountholder source)
        {
            if (source == null) return null;

            var target = new Person
            {
                FName = source.FirstName,
                LName = source.LastName,
            };

            source.ResidenceAddress.MapToExisting(target);

            return target;
        }

        public static Domain.Accountholder Map(this Person source)
        {
            if (source == null) return null;

            var target = new Domain.Accountholder
            {
                FirstName = source.FName,
                LastName = source.LName,

                ResidenceAddress = source.MapToAddress(),
            };

            return target;
        }

        public static void MapToExisting(this Domain.Accountholder source, Person target)
        {
            if (source == null) target = null;
            else if (target == null)
                target = new Person();

            target.FName = source.FirstName;
            target.LName = source.LastName;

            source.ResidenceAddress.MapToExisting(target);
        }
    }
}