using GeneratingFunctions.Definition.Base;

namespace GeneratingFunctions.Definition
{
    public class GenFunc3 : BaseGeneratingFunction
    {
        private readonly int _finalExponent;

        public GenFunc3(int finalExponent)
        {
            FinalTerm = finalExponent;
            _finalExponent = finalExponent;

            Coef = k => 1;
            Exp = k => k;
            InitFunction();
        }

        public override string ToString()
        {
            return $"{Definition()} : {ArrayOfTermsToString()}";
        }

        public override string Definition()
        {
            return $"(1 - x^(n + 1)) / (1 - x) => (1 + (1 - x^({_finalExponent} + 1)) / (1 - x)";
        }
    }
}