using System;

namespace GeneratingFunctions.Definition.Base
{
    public class Term
    {
        private readonly Func<int, long> _coeficient;
        private readonly Func<int, long> _exponent;
        private readonly int _order;

        public Term(Func<int, long> coeficient, Func<int, long> exponent, int order)
        {
            _coeficient = coeficient;
            _exponent = exponent;
            _order = order;
            Node = "x";
        }

        public string Node { get; set; }

        public long GetCoef()
        {
            return _coeficient(_order);
        }

        public long GetExponent()
        {
            return _exponent(_order);
        }

        public override string ToString()
        {
            return $"{GetCoef()}+{Node}*{GetExponent()}";
        }
    }
}