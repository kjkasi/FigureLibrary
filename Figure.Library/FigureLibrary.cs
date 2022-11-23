using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Figure.Library
{
    class ShapeException : ArgumentException
    {
        public double Value { get; }
        public ShapeException(string message, double value) : base(message)
        {
            this.Value = value;
        }
    }

    abstract class Shape
    {
        public abstract double Area();
    }

    class Circle : Shape
    {
        private double _radius;

        public double R
        {
            get => _radius;
            set
            {
                if (value < 1) 
                    throw new ShapeException("The radius must be greater than zero", value);
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            this.R = radius;
        }

        public override double Area()
        {
            return 2.0 * Math.PI * Math.Pow(R, 2.0);
        }

        public override string ToString()
        {
            return $"Circle with radius {this.R}";
        }
    }

    class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double A
        {
            get => _sideA;
            set
            {
                if (value < 1)
                    throw new ShapeException("The sideA must be greater than zero", value);
                _sideA = value;
            }
        }
        public double B 
        {
            get => _sideB;
            set
            {
                if (value < 1)
                    throw new ShapeException("The sideB must be greater than zero", value);
                _sideB = value;
            }
        }
        public double C 
        { 
            get => _sideC; 
            set
            {
                if (value < 1)
                    throw new ShapeException("The sideC must be greater than zero", value);
                _sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC)
                throw new ShapeException("The sum sideA and sideB must be greater than the last sideC", sideC);
            if (sideB + sideC <= sideA)
                throw new ShapeException("The sum sidB and sideC must be greater than the last sideA", sideA);
            if (sideA + sideC <= sideB)
                throw new ShapeException("The sum sideA and sideC must be greater than the last sideB", sideB);
            this.A = sideA;
            this.B = sideB;
            this.C = sideC;
        }

        public override double Area()
        {
            double p = (1.0 / 2.0) * (_sideA + _sideB + _sideC);
            double s = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            return s;
        }

        public override string ToString()
        {
            return $"Triangle with side ({this.A}, {this.B}, {this.C})";
        }
    }

    public static class FigureLibrary
    {
        public static double GetCircleArea(double radius)
        {
            try
            {
                Circle circle = new(radius);
                return circle.Area();
            }
            catch (ShapeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
                return double.NaN;
            }
        }

        public static double GetTrangleArea(double sideA, double sideB, double sideC)
        {
            try
            {
                Triangle triangle = new(sideA, sideB, sideC);
                return triangle.Area();
            }
            catch (ShapeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
                return double.NaN;
            }
        }

    }
}
