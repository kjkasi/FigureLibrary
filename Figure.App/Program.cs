using Figure.Library;
using System;
using System.Collections.Generic;

namespace Figure.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(10.0);
            Triangle triangle = new(4.0, 3.0, 2.0);
            Triangle rightTriangle = new(3.0, 5.0, 4.0);

            Console.WriteLine($"{ rightTriangle }.IsRight: { rightTriangle.IsRight() }");

            List<Shape> items = new List<Shape> ();

            items.Add(circle);
            items.Add(triangle);
            items.Add(rightTriangle);

            foreach(Shape item in items)
            {
                Console.WriteLine($"{ item }, have area: { item.Area()  }");
            }

            Console.ReadKey();
        }
    }
}
