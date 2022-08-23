using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Sphere : AbstractShape
    {
        private double _rad;

        public Sphere(double radius)
        {
            _rad = radius;
        }

        public override string Name => "spherical";
        public override string Dimensions => "3 dimentions";

        public override double Area()
        {
            var c = new Circle(_rad);
            return c.Area()*4;
        }
        public override void Scale(double factor)
        {
            _rad = _rad * factor;
        }
    }
}
