using System;
using System.Collections.Generic;

namespace example19
{
    class Program
    {
        static void Main(string[] args)
        {
            var distributor = new Distributors("onur", "çiftci", "van"); 
            var customer = new Customer("burak", "çiftci", "van");
            var listCustomer = new List<Customer>();
            var listDistributor = new List<Distributors>();
            listCustomer.Add(customer);
            listDistributor.Add(distributor);
            var operation = new Operation();
            operation.Joining(listCustomer, listDistributor);
        }
    }
}
