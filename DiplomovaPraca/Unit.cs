using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomovaPraca
{
    class Unit
    {
        public String Name { get; set; }
        public int Exponent { get; set; }
        public int Base { get; set; }

        public Unit() { }
        
        public Unit(String name0, int base0, int exp0)
        {
            Name = name0;
            Base = base0;
            Exponent = exp0;
        }

        public Unit Multiply(Unit u)
        {
            if (Name.Equals(u.Name))
            {
                var ex = Exponent + u.Exponent;
                var b = Base * u.Base;
                return new Unit(Name, b, ex);
            }
            return null;
        }

        public Unit Add(Unit u)
        {
            if (this.Equals(u))
            {
                var b = Base + u.Base;
                return new Unit(Name, b, Exponent);
            }
            return null;
        }

        public override bool Equals(object obj)
        {
            Unit o2 = (Unit)obj;

            if (Name.Equals(o2.Name) && Exponent.Equals(o2.Exponent)) return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Base}{Name}^{Exponent}";
        }

    }
}
