using AreaCalculateLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculateLibrary.Shapes
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)=>
            _radius = radius;

        public double GetArea() =>
        Math.PI * Math.Pow(_radius, 2);
    }
}
