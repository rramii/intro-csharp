using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class AbstractShape
    {
        public abstract string Name { get; }
        public abstract double Area();
        public abstract void Scale(double factor);
        public abstract string Dimensions { get; }
    }
}
