using System;

namespace GeneratingFunctions.Definition
{
    public class Term
    {
        private Func<int, int> _coeficient;
        private Func<int, int> _exponent;
        private int _order;

        public Term(Func<int, int> coeficient, Func<int, int> exponent, int order)
        {
            _coeficient = coeficient;
            _exponent = exponent;
            _order = order;
            Node = "x";
        }

        public string Node { get; set; }

        public int GetCoef()
        {
            return _coeficient(_order);
        }

        public int GetExponent()
        {
            return _exponent(_order);
        }

        public override string ToString()
        {
            return $"{GetCoef()}+{Node}*{GetExponent()}";
        }
    }
}