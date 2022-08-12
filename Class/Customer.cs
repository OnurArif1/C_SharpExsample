using System;
using System.Collections.Generic;
using System.Text;

namespace example19
{
     public class Customer
     {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public Customer(string name,string surname,string city)
        {
            Name = name; Surname = surname; City = city;
        }
     }
}
