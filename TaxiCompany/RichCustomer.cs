using System;
using System.Collections.Generic;
using System.Text;

namespace taxi
{
    class RichCustomer : Customer
    {
        public RichCustomer(string Name)
        {
            name = Name;
        }

        public override void Accept(Taxi taxi)
        {
            taxi.VisitCustomer(this);
        }
    }
}
