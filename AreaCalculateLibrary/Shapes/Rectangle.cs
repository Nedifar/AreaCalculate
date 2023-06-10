using AreaCalculateLibrary.Exceptions;
using AreaCalculateLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculateLibrary.Shapes
{
    public class Rectangle : IShape
    {
        private double _a;
        private double _b;
        private double _c;

        public Rectangle(double a, double b, double c)
        {
            (_a, _b, _c) = (a, b, c);
            if (_a > _b + _c
                || _b > _a + _c
                || _c > _a + _b)
            {
                throw new RectangleException("Треугольника с указанными сторонами не существует.");
            }
        }

        public double GetArea()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        private double Perimeter() =>
            _a + _b + _c;

        public bool IsRectangular()
        {
            bool result1 = Math.Pow(_a, 2) == Math.Pow(_b, 2) + Math.Pow(_c, 2);
            bool result2 = Math.Pow(_b, 2) == Math.Pow(_a, 2) + Math.Pow(_c, 2);
            bool result3 = Math.Pow(_c, 2) == Math.Pow(_b, 2) + Math.Pow(_a, 2);
            if (result1 || result2 || result3)
            {
                return true;
            }
            return false;
        }
    }
}
