using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSchema
{
    class ElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElement(this);
        }
    }
}
