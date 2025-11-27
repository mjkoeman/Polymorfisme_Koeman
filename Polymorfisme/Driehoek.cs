using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    public class Driehoek : Vorm
    {
        public double Basis { get; set; }
        public double Height { get; set; }
        public override double BerekenOppervlakte()
        {
            return 0.5 * Basis * Height;
        }
        public Driehoek(string name, double basis, double height)
        {
            Name = name;
            Basis = basis;
            Height = height;
        }
    }
}
