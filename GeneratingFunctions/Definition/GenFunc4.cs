using System;
using System.Collections.Generic;

namespace GeneratingFunctions.Definition
{
    public class GenFunc4
    {
        private int _coefParameter;

        private List<Term> _arrayOfTerms;
        private Func<int, int> coef;
        private Func<int, int> exp;

        private Term _term;

        public GenFunc4(int coefParameter)
        {
            _coefParameter = coefParameter;
            _arrayOfTerms = new List<Term>();

            coef = k => (int)Math.Pow(_coefParameter, k);
            exp = k => k;
            InitTerms();
        }

        public override string ToString()
        {
            return $"1 / (1 - ax) => 1 / (1 - {_coefParameter}x) : {ArrayOfTermsToString()} ";
        }

        protected string ArrayOfTermsToString()
        {
            var result = "";
            foreach (var term in _arrayOfTerms)
            {
                result += $"[{term}] + ";
            }

            result = result.Substring(0, result.Length - 3) + " + ...";

            return result;
        }

        private void InitTerms()
        {
            for (int i = 0; i <= 10; i++)
            {
                _arrayOfTerms.Add(new Term(coef, exp, i));
            }
        }
    }
}