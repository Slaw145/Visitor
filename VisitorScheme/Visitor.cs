using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSchema
{
    abstract class Visitor
    {
        public abstract void VisitElement(
          ElementA elementA);
        public abstract void VisitElement(
          ElementB elementB);
    }
}
