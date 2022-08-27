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
            var here = FindLocation(x);
            _list.Insert(here, x);            
            return Count() > before;
        }

        private int FindLocation(double x)
        {
            
            if (Count() == 0)
            {
                return Count();
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
            return Count();
        }

        public int Count() => _list.Count;
        
        public double Get(int index) => _list[index];
        
        public double Max() => _list[Count()-1];
        
        public double Min() => _list[0];

        public void Sorting(List<int> new_list) => _list.Sort();
    }
}
