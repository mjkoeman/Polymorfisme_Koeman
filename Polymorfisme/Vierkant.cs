using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    public class Vierkant : Vorm
    {
        public double Rib { get; set; }
            public Vierkant(string name, double rib)
        {
            Name = name;
            Rib = rib;
        }

        public override double BerekenOppervlakte()
        {
            return Rib * Rib;
        }

        public override double BerekenOmtrek()
        {
            return 4 * Rib;
        }
    }
}
