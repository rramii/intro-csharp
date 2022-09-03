using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
   
    internal class SortedList : SortedContainer
    {
        private List<double> _list = new List<double>();

        public bool Remove(double x)
        {
            var before = Count();
            var here = FindLocation(x);
            _list.RemoveAt(here);
            return Count() < before;
        }

        
        public bool Add(double x)
        {
            var before = Count();

            _list.Add(x);

            for (int i = Count() - 1; i > 0; --i)
            {
                var b = Get(i);
                var a = Get(i-1);

                if( a > b)
                {
                    Swap(i, i - 1);
                }
                else
                {
                    break;
                }
            }
            return Count() > before;
        }

        private void Swap(int i, int j)
        {
            var t = Get(i);
            _list[i] = _list[j];
            _list[j] = t;
        }

        private int FindLocation(double x)
        {            
            if (Count() == 0)
            {
                return 0;
            }

            int low = 0;
            int high = Count() - 1;

            while(low <= high)
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

            return low;
        }

        public int Count() => _list.Count;
        
        public double Get(int index) => _list[index];
        
        public double Max() => _list[Count()-1];
        
        public double Min() => _list[0];
    }
}
