using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Factory_Method
{
    interface FabricaDeComparables
    {
        
        Icomparable crearAleatorio();
        Icomparable crearPorTeclado();

    }
}
