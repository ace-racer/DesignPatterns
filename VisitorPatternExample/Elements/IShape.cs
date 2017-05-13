using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample
{
    interface IShape
    {
        ConsoleColor GetShapeColor();

        double GetArea();

        List<Point> GetPosition();

    }
}
