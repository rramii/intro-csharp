using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson_14
{
    public class Calculator
    {
        public Calculator()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string Square(string t) 
        {
            if (double.TryParse(t, out double result))
            {
                return $"{result * result}";
            }
            else
            {
                return "error";
            }
        }

        public string Sqrt(string t)
        {
            if (double.TryParse(t, out double result))
            {
                if (result >= 0)
                {
                    return $"{Math.Sqrt(result)}";
                }
                else
                {
                    return $"{double.NaN}";
                }
            }
            else
            {
                return "error";
            }
        }
    }
}