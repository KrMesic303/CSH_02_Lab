using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1.KompleksniBrojevi
{
    public class KompleksniBrojStruktura
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBrojStruktura(double real, double imag)
        {
            RealniDio = real;
            ImaginarniDio = imag;

        }

        public override string ToString()
        {
            return string.Format($"{RealniDio} + {ImaginarniDio}i");
        }
    }
}
