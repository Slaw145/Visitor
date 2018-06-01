using System;
using System.Collections.Generic;
using System.Text;

namespace taxi
{
    class TaxiCustomer : Customer
    {
        public TaxiCustomer(string Name)
        {
            name = Name;
        }

        public override void Accept(Taxi taxi)
        {
            taxi.VisitCustomer(this);
        }
    }
}
