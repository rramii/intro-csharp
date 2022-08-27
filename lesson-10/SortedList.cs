using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    internal class SortedList : SortedContainer
    {
        //private int Find(int x, double[] index)
        //{
        //        if (index[i] == x)
        //        {
        //            return i;
        //        }
        //        else
        //        {
        //            Add(x, index);
        //        }
        //}

        //public double[] Add(double x, double[] index)
        //{
        //    double[] list = new double[0];
        //    for (int i = 1; i < index.Length + 1; i++)
        //    {
        //        list.Append(index[i]);
        //    }
        //    list.Append(x);
        //    return list;
        //}

        //private double Count(double[] index)
        //{
        //    double counter = 0;
        //    for (int i = 0; i < index.Length + 1; i++)
        //    {
        //        counter += 1;
        //    }
        //    return counter;
        //}

        //public void Get(double[] index)
        //{
        //    Max(index);
        //    Min(index);
        //    Count(index);
        //}

        //private double Max(double[] index)
        //{
        //    double new_max = 0 ;
        //    foreach (double number in index)
        //    {
        //        if (new_max < number)
        //        {
        //            new_max = number ;
        //        }
        //    }
        //    return new_max;
        //}

        //private double Min(double[] index)
        //{
        //    double new_min = 0;
        //    foreach (double number in index)
        //    {
        //        if (new_min > number)
        //        {
        //            new_min = number;
        //        }
        //    }
        //    return new_min;
        //}

        //public double[] Remove(int x, double[] index)
        //{
        //    int location= Find(x, index);

        //    index.RemoveAt(location);

        //    double[] new_index = new double[0];
        //    foreach (double item in index)
        //    {
        //        new_index.Append(item);
        //    }

        //    return new_index;
        //}


        private List<double> _list = new List<double>();

        public bool Add(double x)
        {
            var before = Count();
            var here = findWhereToAdd(x);
            _list.Insert(here, x);            
            return Count() > before;
        }

        private int findWhereToAdd(double x)
        {
            //TODO: binary search
            return 0;
        }

        public int Count() => _list.Count;
        
        public double Get(int index) => _list[index];
        
        public double Max() => _list[Count()-1];
        
        public double Min() => _list[0];
        

        public bool Remove(double x)
        {
            throw new NotImplementedException();
        }
    }
}
