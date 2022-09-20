using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Algebra
    {
        static void Main(string[] args) { }

        public int Mul(int first, int second) 
        {
            int a, b;
            if(first < second)
            {
                a = first;
                b = second;
            }
            else
            {
                a = second;
                b = first;
            }

            
            var sign = +1;
            if( a < 0 && b > 0) sign  = -1;
            if (b < 0 && a > 0) sign = -1;

            a = Math.Abs(a);
            b = Math.Abs(b);

            int result = 0;
            for (int i = 0; i <a; i++)
            {
                result = Add(result, b);
            }
            
            

            return sign*result;
        }
        public int Add(int a, int b) 
        { 
            if(b < a)
            {
                var t = a;
                a = b;
                b = t;
            }

            var delta = a < 0 ? -1 : 1;
            a = a < 0 ? -a : a;
            int result = b;
            for (int i = 0; i < a; i++)
            {
                result += delta;
            }

            return result;
        }

        public double Power(int a, double pow)
        {
            var r = 1;
            if (a == 0)
            {
                return 0;
            }
            if (pow == 0)
            {
                return 1;
            }
            
            for (int i = 0; i < Math.Abs(pow); i++)
            {
                r = Mul(r, a);
            }
            
            if (pow < 0)
            {
                return (double) 1 / r;
            }
            else
            {
                return r;
            }

        }

        public double SquareRoot(int a) 
        {
            if (a > 0)
            {
                double root = a / 3;
                for (int i = 0; i < 32; i++)
                {
                    root = (root + (a / root)) / 2;
                }
                return root;
            }
            else
            {
                return double.NaN;
            }
        }
    }
}
