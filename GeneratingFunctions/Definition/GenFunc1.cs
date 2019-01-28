using GeneratingFunctions.Helpers;
using System;
using System.Collections.Generic;

namespace GeneratingFunctions.Definition
{
    public class GenFunc1 : BaseGeneratingFunction
    {
        private int _finalExponent;
        private int _coefParameter;
        private List<Term> _arrayOfTerms;
        private Func<int, int> coef;
        private Func<int, int> exp;

        private Term _term;

        public GenFunc1(int finalExponent, int coefParameter)
        {
            _finalExponent = finalExponent;
            _coefParameter = coefParameter;

            _arrayOfTerms = new List<Term>();

            coef = k => MathHelper.CombinatorialNumber(_finalExponent, k) * (int)Math.Pow(_coefParameter, k);
            exp = k => k;
            InitTerms();
        }

        public override string ToString()
        {
            return $"(1 + ax)^n => (1 + {_coefParameter}x)^{_finalExponent}  :  {ArrayOfTermsToString()}";
        }

        protected string ArrayOfTermsToString()
        {
            var result = "";
            foreach (var term in _arrayOfTerms)
            {
                result += $"[{term}] + ";
            }

            return result.Substring(0, result.Length - 3);
        }

        private void InitTerms()
        {
            for (int i = 0; i <= _finalExponent; i++)
            {
                _arrayOfTerms.Add(new Term(coef, exp, i));
            }
        }
    }
}