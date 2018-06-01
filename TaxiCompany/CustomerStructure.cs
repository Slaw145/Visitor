using System;
using System.Collections.Generic;
using System.Text;

namespace taxi
{
    class CustomerStructure
    {
        private List<Customer> _customers = new List<Customer>();

        public void Attach(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Detach(Customer customer)
        {
            _customers.Remove(customer);
        }

        public void Accept(Taxi taxi)
        {
            foreach (Customer customer in _customers)
            {
                customer.Accept(taxi);
            }
        }
    }
}
