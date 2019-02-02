using GeneratingFunctions.Definition.Base;
using GeneratingFunctions.Helpers;

namespace GeneratingFunctions.Definition
{
    public class GenFunc5 : BaseGeneratingFunction
    {
        private readonly int _finalParameter;

        public GenFunc5(int finalParameter)
        {
            _finalParameter = finalParameter;
            FinalTerm = Common.Settings.DefaultFinalTerm;
            Coef = k => MathHelper.CombinatorialNumber(-_finalParameter, k);
            Exp = k => k;
            InitFunction();
        }

        public override string ToString()
        {
            return $"{Definition()} : {ArrayOfTermsToString()} ";
        }

        public override string Definition()
        {
            return $"1 / (1 + x)^n => 1 / (1 + x)^{_finalParameter}";
        }
    }
}