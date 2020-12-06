using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Command
{
    interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 orden);
        void setOrdenLlegaAlumno(OrdenEnAula2 orden);
        void setOrdenAulaLlena(OrdenEnAula1 orden);
    }
}
