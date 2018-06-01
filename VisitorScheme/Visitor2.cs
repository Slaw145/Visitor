using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSchema
{
    class Visitor2 : Visitor
    {
        public override void VisitElement(
          ElementA elementA)
        {
            Console.WriteLine(elementA.GetType().Name + " visited by " + GetType().Name);
        }

        public override void VisitElement(
          ElementB elementB)
        {
            Console.WriteLine(elementB.GetType().Name + " visited by " + GetType().Name);
        }
    }
}
