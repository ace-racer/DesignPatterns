using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample
{
    class ShapeDetailsPrinter : IShapesVisitor
    {
        public void PrintShapeDetails(Line line)
        {
            Console.WriteLine("Details for the line...");
            if(line != null)
            {
                foreach (var item in line.GetPosition())
                {
                    Console.WriteLine("X = " + item.x.ToString() + ", Y = " + item.y.ToString());
                }
            }
        }

        public void PrintShapeDetails(Circle circle)
        {
            Console.WriteLine("Details for the circle...");
            if (circle != null)
            {
                foreach (var item in circle.GetPosition())
                {
                    Console.WriteLine("X = " + item.x.ToString() + ", Y = " + item.y.ToString());
                }
            }
        }
    }
}
