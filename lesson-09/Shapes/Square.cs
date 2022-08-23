using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : AbstractShape
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }

        public override string Name => "SquarePants";

        public override double Area()
        {
            return _side * _side;
        }
    }
}
