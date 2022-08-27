using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    internal class SortedArray : SortedContainer
    {
        private double[] _array = new double[] { };

        public bool Add(double x)
        {
            var before = Count();
            var here = FindLocation(x);
            _array[here] = x;
            return Count() > before;
        }
        
        public bool Remove(double x)
        {
            var before = Count();
            var here = FindLocation(x);
            _array.Where(x => x != here).ToArray();
            return Count() < before;
        }

        public int Count() => _array.Length;

        private int FindLocation(double x)
        {

            if (Count() == 0)
            {
                return Count();
            }

            int low = 0;
            int high = Count() - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                var element = Get(mid);
                if (x > element)
                {
                    low = mid + 1;
                }
                else if (x < element)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return Count();
        }

        public double Get(int index) => _array[index];

        public double Max() => _array[Count() - 1];

        public double Min() => _array[0];

        public void Sorting() => Array.Sort(_array);
    }
}
