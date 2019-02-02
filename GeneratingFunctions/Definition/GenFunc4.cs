using GeneratingFunctions.Definition.Base;
using System;

namespace GeneratingFunctions.Definition
{
    public class GenFunc4 : BaseGeneratingFunction
    {
        private readonly int _coefParameter;

        public GenFunc4(int coefParameter)
        {
            _coefParameter = coefParameter;
            FinalTerm = Common.Settings.DefaultFinalTerm;

            Coef = k => (int)Math.Pow(_coefParameter, k);
            Exp = k => k;
            InitFunction();
        }

        public override string ToString()
        {
            return $"{Definition()} : {ArrayOfTermsToString()} ";
        }

        public override string Definition()
        {
            return $"1 / (1 - ax) => 1 / (1 - {_coefParameter}x)";
        }
    }
}