using System;
using System.Collections.Generic;
using System.Text;

namespace example19
{
    interface IOperation
    {
        /// <summary>
        ///  Bu metod listeleme işlemi yapar
        /// </summary>
        public void Listele(List<Customer> customer, List<Distributors> distributors);
        public void Joining(List<Customer> customer, List<Distributors> distributors);
    }
}
