using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace example19
{
    public class Operation : IOperation
    {
        public void Listele(List<Customer> customer, List<Distributors> distributors)
        {
            foreach (var item in customer)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.City);

            }
            foreach (var item in distributors)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.City);

            }
        }
        public void Joining(List<Customer> customer, List<Distributors> distributors)
        {
            var joinQuery = from customers in customer
                            join distributorss in distributors on customers.City equals distributorss.City
                            select new
                            {
                                City = customers.City,
                                CustomerName = customers.Name,
                                DistributorsName = distributorss.Name
                            };
            Console.WriteLine("Şehir, Dağıtıcı - Müşteri");
            Console.WriteLine("-------------------------");
            foreach (var item in joinQuery)
            {
                Console.WriteLine("{0},{1}-{2} ",item.City,
                                                 item.DistributorsName,
                                                 item.CustomerName);
            }
        }
    }
}
