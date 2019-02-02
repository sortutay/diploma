using GeneratingFunctions.Definition.Base;
using GeneratingFunctions.Helpers;
using System;

namespace GeneratingFunctions.Definition
{
    public class GenFunc1 : BaseGeneratingFunction
    {
        private readonly int _coefParameter;
        private readonly int _finalExponent;

        private Term _term;

        public GenFunc1(int finalExponent, int coefParameter)
        {
            FinalTerm = finalExponent;
            _finalExponent = finalExponent;
            _coefParameter = coefParameter;

            Coef = k => MathHelper.CombinatorialNumber(_finalExponent, k) * (int)Math.Pow(_coefParameter, k);
            Exp = k => k;

            //Init Generate Function can be after initialization of Coef and Exp functions
            InitFunction();
        }

        public override string ToString()
        {
            return $"(1 + ax)^n => (1 + {_coefParameter}x)^{_finalExponent}  :  {ArrayOfTermsToString()}";
        }
    }
}