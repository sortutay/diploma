using GeneratingFunctions.Helpers;
using System;
using System.Collections.Generic;

namespace GeneratingFunctions.Definition
{
    public class GenFunc6 : BaseGeneratingFunction
    {
        private int _finalParameter;

        private List<Term> _arrayOfTerms;
        private Func<int, int> coef;
        private Func<int, int> exp;

        private Term _term;

        public GenFunc6(int finalParameter)
        {
            _finalParameter = finalParameter;
            _arrayOfTerms = new List<Term>();

            coef = k => MathHelper.CombinatorialNumber(-_finalParameter, k) * (int)Math.Pow(-1, k);
            exp = k => k;
            InitTerms();
        }

        public override string ToString()
        {
            return $"1 / (1 - x)^n => 1 / (1 - x)^{_finalParameter} : {ArrayOfTermsToString()} ";
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