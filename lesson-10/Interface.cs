using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    internal interface Interface
    {
        double Max();
        double Min();
        double Count();

        double Add(double x);
        double Remove(double x);
        double[] Get(double[] index);
    }
}
