using Figure.Library;
using System;

namespace Figure.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FigureLibrary.GetCircleArea(10.0));
            Console.WriteLine(FigureLibrary.GetTrangleArea(4.0, 3.0, 2.0));

            Console.ReadKey();
        }
    }
}
