using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    internal interface SortedContainer
    {
        double Max();
        double Min();
        int Count();

        bool Add(double x);
        bool Remove(double x);

        double Get(int index);
    }
}
