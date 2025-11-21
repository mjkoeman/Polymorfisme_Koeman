using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    public abstract class Vorm
    {
        public string Name { get; set; } = null!;

        public abstract double BerekenOppervlakte();
    }
}
