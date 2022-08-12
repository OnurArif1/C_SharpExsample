using System;
using System.Collections.Generic;
using System.Text;

namespace example19
{
    public class Distributors:Customer
    {
        public Distributors(string name, string surname, string city):base(name,surname,city)
        {
            Name = name; Surname = surname; City = city;
        }
    }
    
}
