using System;

namespace VisitorPatternExample
{

    // taken the main idea from https://en.wikipedia.org/wiki/Visitor_pattern
    public class Program
    {
        public static void Main(string[] args)
        {
            var circle = new Circle(5, new Point(1, 1));
            var shapeDetailsPrinter = new ShapeDetailsPrinter();
            circle.Accept(shapeDetailsPrinter);
            Console.ReadKey();
        }
    }
}