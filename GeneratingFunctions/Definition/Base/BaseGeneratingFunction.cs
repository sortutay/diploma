using System;
using System.Collections.Generic;

namespace GeneratingFunctions.Definition.Base
{
    public abstract class BaseGeneratingFunction
    {
        protected List<Term> ArrayOfTerms;

        protected Func<int, long> Coef;
        protected Func<int, long> Exp;

        protected Func<Func<int, long>, int, long> SummationOperator = (func, i) =>
        {
            long result = 0;
            for (var k = i; k >= 0; k--)
            {
                result += func(k);
            }
            return result;
        };

        protected int FinalTerm;

        public abstract string Definition();

        public abstract BaseGeneratingFunction EvalSummationOperator();

        protected void InitFunction()
        {
            ArrayOfTerms = new List<Term>();
            for (var i = 0; i < FinalTerm; i++)
            {
                ArrayOfTerms.Add(new Term(Coef, Exp, i));
            }
        }

        protected Term GetCoef(int order)
        {
            if (order > 0 || order < FinalTerm)
            {
                return ArrayOfTerms[order];
            }

            return null;
        }

        protected string ArrayOfTermsToString()
        {
            var result = "";
            foreach (var term in ArrayOfTerms)
            {
                result += $"[{term}] + ";
            }

            return result.Substring(0, result.Length - 3);
        }

        private void bla()
        {
        }

        private void GenerateOtherTerms(int finalIndex)
        {
            if (FinalTerm >= finalIndex)
            {
                return;
            }
            for (var i = FinalTerm; i < finalIndex; i++)
            {
                ArrayOfTerms.Add(new Term(Coef, Exp, i));
            }
        }
    }
}