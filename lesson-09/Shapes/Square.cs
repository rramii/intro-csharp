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

        public override string Name => "Square";
        public override string Dimensions => "2 dimentions";

        public override double Area()
        {
            return _side * _side;
        }
        public override void Scale(double factor)
        {
            _side = _side * factor;
        }
    }
}
