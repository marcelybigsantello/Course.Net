using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Delegates_LINQ.Services
{
    class CalculationService2
    {
        public static void ShowMax(float a, float b)
        {
            float max = (a > b) ? a : b;
            Console.WriteLine(max);
        }

        public static void ShowSum(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
