using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : AbstractShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override string Name => "Circle";
        public override string Dimensions => "2 dimentions";
        
        public override double Area()
        {
            return Math.PI * _radius * _radius;            
        }

        public override void Scale(double factor)
        {
            _radius = _radius * factor;
        }



    }
}
