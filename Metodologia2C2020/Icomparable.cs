using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020
{
    public interface Icomparable
    {
        Boolean sosIgual(Icomparable comparable);
        Boolean sosMenor(Icomparable comparable);
        Boolean sosMayor(Icomparable comparable);

    }
}
