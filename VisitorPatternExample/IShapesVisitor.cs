using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample
{
    interface IShapesVisitor
    {
        void PrintShapeDetails(Circle circle);

        void PrintShapeDetails(Line line);        
    }
}
