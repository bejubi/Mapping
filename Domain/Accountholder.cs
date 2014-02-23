using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Accountholder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ResidenceAddress { get; set; }
    }
}
