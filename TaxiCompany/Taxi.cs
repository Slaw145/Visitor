using System;
using System.Collections.Generic;
using System.Text;

namespace taxi
{
    abstract class Taxi
    {
        public abstract void VisitCustomer(TaxiCustomer customer);
        public abstract void VisitCustomer(PoorCustomer poorCustomer);
        public abstract void VisitCustomer(RichCustomer richCustomer);
    }
}
