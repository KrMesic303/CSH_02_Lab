using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1.KompleksniBrojevi
{
    public class KompleksniBrojKlasa
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBrojKlasa(double real, double imag)
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
