using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DomainClasses
{
    public class Customer
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public string Streetname { get; set; }
        public int Housenr { get; set; }

        public Customer(string name, Country country, string streetname, int housenr)
        {
            Name = name;
            Country = country;
            Streetname = streetname;
            Housenr = housenr;
        }
    }
}
