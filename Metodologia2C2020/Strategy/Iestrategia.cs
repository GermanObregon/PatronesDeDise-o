using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Strategy
{
    interface Iestrategia
    {
        bool sosMayor(Icomparable self, Icomparable comparable);
        bool sosMenor(Icomparable self, Icomparable comparable);
        bool sosIgual(Icomparable self, Icomparable comparable);
    }
}
