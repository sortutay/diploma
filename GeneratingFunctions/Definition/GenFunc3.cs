using System;
using System.Collections.Generic;

namespace GeneratingFunctions.Definition
{
    public class GenFunc3 : BaseGeneratingFunction
    {
        private int _finalExponent;

        private List<Term> _arrayOfTerms;
        private Func<int, int> coef;
        private Func<int, int> exp;

        private Term _term;

        public GenFunc3(int finalExponent)
        {
            _finalExponent = finalExponent;

            _arrayOfTerms = new List<Term>();

            coef = k => 1;
            exp = k => k;
            InitTerms();
        }

        public override string ToString()
        {
            return $"(1 - x^(n + 1)) / (1 - x) => (1 + (1 - x^({_finalExponent} + 1)) / (1 - x) : {ArrayOfTermsToString()}";
        }

        private void InitTerms()
        {
            for (int i = 0; i <= _finalExponent; i++)
            {
                _arrayOfTerms.Add(new Term(coef, exp, i));
            }
        }

        private string ArrayOfTermsToString()
        {
            var result = "";
            foreach (var term in _arrayOfTerms)
            {
                result += $"[{term}] + ";
            }

            return result.Substring(0, result.Length - 3);
        }
    }
}