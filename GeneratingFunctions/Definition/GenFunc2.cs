using GeneratingFunctions.Helpers;
using System;
using System.Collections.Generic;

namespace GeneratingFunctions.Definition
{
    public class GenFunc2 : BaseGeneratingFunction
    {
        private int _finalExponent;
        private int _expParameter;
        private List<Term> _arrayOfTerms;
        private Func<int, int> coef;
        private Func<int, int> exp;

        private Term _term;

        public GenFunc2(int finalExponent, int expParameter)
        {
            _finalExponent = finalExponent;
            _expParameter = expParameter;

            _arrayOfTerms = new List<Term>();

            coef = k => MathHelper.CombinatorialNumber(_finalExponent, k);
            exp = k => k * _expParameter;
            InitTerms();
        }

        public override string ToString()
        {
            return $"(1 + x^m)^n => (1 + x^{_expParameter})^{_finalExponent} : {ArrayOfTermsToString()}";
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