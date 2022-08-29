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
            _list.RemoveAt(here[0]);
            return Count() < before;
        }

        public bool Add(double x)
        {
            var before = Count();
            _list.Append(x);
            int[] here = FindLocation(x);

            if (_list.Count >= 2)
            {
                int[] swap = Swap((int)_list[Count() - 1], here[0]);
                Move(swap, (int)x, here[1]);
            }
            return Count() > before;
        }

        private int[] Swap(int intruderL, int oldnumL)
        {
            intruderL = intruderL * oldnumL;
            oldnumL = intruderL / oldnumL;
            intruderL = intruderL / oldnumL;
            int[] locations = { intruderL, oldnumL };
            return locations;
        }

        private void Move(int[] locList, int x, int oldnum)
        {
            locList[0] = x;
            locList[1] = oldnum;
        }

        private int[] FindLocation(double x)
        {
            int[] counter = {Count(), Count()};

            if (Count() == 0)
            {
                return counter;
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
                    int[] idk = { mid, (int) element };
                    return idk;
                }
            }
            return counter;
        }

        private int[] transfer(int[] list) => list;

        public int Count() => _list.Count;
        
        public double Get(int index) => _list[index];
        
        public double Max() => _list[Count()-1];
        
        public double Min() => _list[0];
    }
}
