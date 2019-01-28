using System;
using System.Collections.Generic;

namespace GeneratingFunctions
{
    public class Poly
    {
        private List<TermSimple> units;

        public Poly()
        {
            units = new List<TermSimple>();
        }

        public Poly(List<TermSimple> units0)
        {
            units = units0;
        }

        public void Add(TermSimple u)
        {
            for (int i = 0; i < units.Count; i++)
            {
                TermSimple u2 = units[i].Add(u);
                if (u2 != null)
                {
                    units[i] = u2;
                    return;
                }
            }

            units.Add(u);
        }

        public Poly Multiply(Poly p)
        {
            Poly result = new Poly();
            for (int i = 0; i < units.Count; i++)
            {
                for (int j = 0; j < p.units.Count; j++)
                {
                    result.Add(units[i].Multiply(p.units[j]));
                }
            }

            return result;
        }

        public TermSimple GetBase(int ex)
        {
            foreach (TermSimple u in units)
            {
                if (ex == u.Exponent)
                {
                    return u;
                }
            }

            throw new ArgumentException($"Cant find variable with exponent {ex}");
        }

        public override string ToString()
        {
            var result = "Poly: ";
            foreach (TermSimple u in units)
            {
                result += $"{u} ";
            }

            return result;
        }
    }
}