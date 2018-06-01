using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSchema
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
