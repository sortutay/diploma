using System;

namespace GeneratingFunctions.Helpers
{
    public class CombinatorialNumber
    {
        private int _n;
        private int _k;

        public CombinatorialNumber(int n, int k)
        {
            _n = n;
            _k = k;
        }

        public int Eval()
        {
            return Eval(_n, _k);
        }

        public override string ToString()
        {
            return $"CN({_n},{_k})";
        }

        private int Eval(int n, int k)
        {
            if (_n < 0)
            {
                //Negative combinatorial number
                return (int)Math.Pow(-1, _k) * Eval(-_n + _k - 1, _k);
            }
            return MathHelper.Factorial(_n) / (MathHelper.Factorial((_n - _k)) * MathHelper.Factorial(_k));
        }
    }
}