using System;
using System.Collections.Generic;
using System.Text;

namespace taxi
{
    class Taxi1 : Taxi
    {
        public override void VisitCustomer(TaxiCustomer customer)
        {
            Console.WriteLine("Customer " + customer.name + " has been visited by " + GetType().Name);
        }

        public override void VisitCustomer(PoorCustomer poorCustomer)
        {
            Console.WriteLine("Customer " + poorCustomer.name + " can only pay 20$ for " + GetType().Name);
        }

        public override void VisitCustomer(RichCustomer richCustomer)
        {
            Console.WriteLine("Customer " + richCustomer.name + " can pay 100$ for " + GetType().Name);
        }
    }
}
