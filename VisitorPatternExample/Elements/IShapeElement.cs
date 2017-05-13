using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample.Elements
{
    interface IShapeElement
    {
        void Accept(IShapesVisitor visitor);
    }
}
