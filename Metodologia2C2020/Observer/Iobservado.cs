using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Observer
{
    interface Iobservado
    {
        void agregarObservador(Iobservador o);
        void quitarObservador(Iobservador o);
        void notificar();
    }
}
