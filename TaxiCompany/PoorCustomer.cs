using System;
using System.Collections.Generic;
using System.Text;

namespace taxi
{
    class PoorCustomer : Customer
    {
        public PoorCustomer(string Name)
        {
            name = Name;
        }

        public override void Accept(Taxi taxi)
        {
            taxi.VisitCustomer(this);
        }
    }
}
