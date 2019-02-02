using GeneratingFunctions.Definition.Base;
using GeneratingFunctions.Helpers;
using System;

namespace GeneratingFunctions.Definition
{
    public class GenFunc6 : BaseGeneratingFunction
    {
        private readonly int _finalParameter;

        private Term _term;

        public GenFunc6(int finalParameter)
        {
            _finalParameter = finalParameter;
            FinalTerm = Common.Settings.DefaultFinalTerm;

            Coef = k => MathHelper.CombinatorialNumber(-_finalParameter, k) * (int)Math.Pow(-1, k);
            Exp = k => k;
            InitFunction();
        }

        public override string ToString()
        {
            return $"{Definition()} : {ArrayOfTermsToString()} ";
        }

        public override string Definition()
        {
            return $"1 / (1 - x)^n => 1 / (1 - x)^{_finalParameter}";
        }
    }
}