using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Iterator;

namespace Metodologia2C2020
{
    interface Icoleccionable : Iterable
    {
        int Cuantos();
        Icomparable Minimo();
        Icomparable Maximo();
        void Agregar(Icomparable elemento);
        Boolean contiene(Icomparable elemento);
    }
}
