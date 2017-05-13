using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternExample.Elements;

namespace VisitorPatternExample
{
    class Circle : IShape, IShapeElement
    {
        private int radius;

        private Point centre;

        public Circle(int radius, Point centre)
        {
            this.radius = radius;
            this.centre = centre;
        }

        public double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public List<Point> GetPosition()
        {
            return new List<Point>()
            {
                { centre },
                { new Point(centre.x + this.radius, centre.y) }
            };
        }

        public ConsoleColor GetShapeColor()
        {
            return ConsoleColor.DarkGreen;
        }

        public void Accept(IShapesVisitor visitor)
        {
            visitor.PrintShapeDetails(this);
        }
    }
}
