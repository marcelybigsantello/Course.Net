using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Delegates_LINQ.Services
{
    class CalculationService
    {
        public static float Max(float x, float y)
        {
            return (x > y) ? x : y;
        }

        public static float Sum(float x, float y)
        {
            return x + y;
        }

        public static float Square(float l)
        {
            return l * l;
        }

        public static float Min(float x, float y)
        {
            return (x < y) ? x : y;
        }

        public static float Dif(float x, float y)
        {
            return x - y;
        }
    }
}
