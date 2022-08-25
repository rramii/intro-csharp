using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Ring : AbstractShape
    {
        private double _inner;
        private double _outer;

        public Ring(double innerRad, double outerRad)
        {
            _inner = innerRad;
            _outer = outerRad;

        }

        public override string Name => "Ring";
        public override string Dimensions => "2 dimentions";

        public override double Area()
        {
            var outer = new Circle(_outer);
            var inner = new Circle(_inner);
            double area = outer.Area() - inner.Area();
            return area;
        }

        public override void Scale(double factor)
        {
            _inner *= factor;
            _outer *= factor;
        }
    }
}
