using System;

namespace GeneratingFunctions
{
    public class TermSimple
    {
        public Func<int> ExponentDefinition;

        public TermSimple()
        {
        }

        public TermSimple(string name0, int base0, int exp0)
        {
            Name = name0;
            Coefficient = base0;
            Exponent = exp0;
        }
        public string Name { get; set; }
        public int Exponent { get; set; }
        public int Coefficient { get; set; }

        public TermSimple Multiply(TermSimple u)
        {
            if (Name.Equals(u.Name))
            {
                var ex = Exponent + u.Exponent;
                var b = Coefficient * u.Coefficient;
                return new TermSimple(Name, b, ex);
            }
            return null;
        }

        public TermSimple Add(TermSimple u)
        {
            if (Equals(u))
            {
                var b = Coefficient + u.Coefficient;
                return new TermSimple(Name, b, Exponent);
            }
            return null;
        }

        public override bool Equals(object obj)
        {
            TermSimple o2 = (TermSimple)obj;

            if (Name.Equals(o2.Name) && Exponent.Equals(o2.Exponent)) return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Coefficient}{Name}^{Exponent}";
        }
    }
}