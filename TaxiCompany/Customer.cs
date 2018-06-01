using System;
using System.Collections.Generic;
using System.Text;

namespace taxi
{
    abstract class Customer
    {
        public string name;
        public abstract void Accept(Taxi taxi);
    }
}
