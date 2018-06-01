using System;
using System.Collections.Generic;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerStructure o = new CustomerStructure();

            o.Attach(new TaxiCustomer("Sam"));
            o.Attach(new TaxiCustomer("John"));
            o.Attach(new TaxiCustomer("Carl"));
            o.Attach(new PoorCustomer("David"));
            o.Attach(new RichCustomer("McOnnel"));

            Taxi t1 = new Taxi1();
            Taxi t2 = new Taxi2();

            o.Accept(t1);

            Console.WriteLine();

            o.Accept(t2);

            Console.ReadKey();
        }
    }
}
