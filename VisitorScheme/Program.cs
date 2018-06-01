using System;
using System.Collections.Generic;

namespace VisitorSchema
{
    class MainApp
    {
        static void Main()
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ElementA());
            o.Attach(new ElementB());

            Visitor v1 = new Visitor1();
            Visitor v2 = new Visitor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.ReadKey();
        }
    }
}
