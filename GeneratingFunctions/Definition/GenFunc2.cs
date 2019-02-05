using GeneratingFunctions.Definition.Base;
using GeneratingFunctions.Helpers;

namespace GeneratingFunctions.Definition
{
    public class GenFunc2 : BaseGeneratingFunction
    {
        private readonly int _finalExponent;
        private readonly int _expParameter;

        public GenFunc2(int finalExponent, int expParameter)
        {
            FinalTerm = finalExponent;
            _finalExponent = finalExponent;
            _expParameter = expParameter;

            Coef = k => MathHelper.CombinatorialNumber(_finalExponent, k);
            Exp = k => k * _expParameter;
            InitFunction();
        }

        public override string ToString()
        {
            return $"{Definition()} : {ArrayOfTermsToString()}";
        }

        public override string Definition()
        {
            return $"(1 + x^m)^n => (1 + x^{_expParameter})^{_finalExponent}";
        }

        public override BaseGeneratingFunction EvalSummationOperator()
        {
            var resultFunction = new GenFunc2(_finalExponent, _expParameter);
            resultFunction.Coef = k => SummationOperator(Coef, k);
            resultFunction.InitFunction();
            return resultFunction;
        }
    }
}