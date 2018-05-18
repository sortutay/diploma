using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomovaPraca
{
    class Poly
    {
        List<Unit> units;


        public Poly()
        {
            units = new List<Unit>();
        }

        public Poly(List<Unit> units0)
        {
            units = units0;
        }

        public void Add(Unit u)
        {
            for (int i = 0; i<units.Count; i++)
            {
                Unit u2 = units[i].Add(u);
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
            for (int i = 0; i<units.Count; i++)
            {
                for (int j = 0; j<p.units.Count; j++)
                {
                    result.Add(units[i].Multiply(p.units[j]));
                }
            }

            return result;
        }

        public Unit GetBase(int ex)
        {
            foreach(Unit u in units)
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
            foreach(Unit u in units){
                result += $"{u} ";
            }

            return result;
        }
    }
}
