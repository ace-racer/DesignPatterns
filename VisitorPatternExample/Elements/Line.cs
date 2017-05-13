using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternExample.Elements;

namespace VisitorPatternExample
{
    class Line : IShape, IShapeElement
    {
        Point start;

        Point end;

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }
        public double GetArea()
        {
            return 0;
        }

        public List<Point> GetPosition()
        {
            return new List<Point>()
            {
                this.start,
                this.end
            };
        }

        public ConsoleColor GetShapeColor()
        {
            return ConsoleColor.DarkRed;
        }

        public void Accept(IShapesVisitor visitor)
        {
            visitor.PrintShapeDetails(this);
        }
    }
}
