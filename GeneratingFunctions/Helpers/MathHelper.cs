using System;

namespace GeneratingFunctions.Helpers
{
    public class MathHelper
    {
        public static int Factorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i - 1);
        }

        public static int CombinatorialNumber(int n, int k)
        {
            if (n < 0)
            {
                //Negative combinatorial number
                return (int)Math.Pow(-1, k) * CombinatorialNumber(-n + k - 1, k);
            }
            return Factorial(n) / (Factorial((n - k)) * Factorial(k));
        }

        public static long SummationOperator(Func<int, long> func, int order)
        {
            long result = 0;
            for (var i = order; i >= 0; i--)
            {
                result += func(i);
            }

            return result;
        }
    }
}