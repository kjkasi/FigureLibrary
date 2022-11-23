using System;
using Xunit;
using Figure.Library;

namespace Figure.Test
{
    public class FigureTest
    {
        [Fact]
        public void TestCircle()
        {
            double r = 10.0;
            double expected = 628.3185307179587;

            double actual = FigureLibrary.GetCircleArea(10.0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTrianglee()
        {
            double a = 4.0;
            double b = 3.0;
            double c = 2.0;
            double expected = 2.9047375096555625;

            double actual = FigureLibrary.GetTrangleArea(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}
