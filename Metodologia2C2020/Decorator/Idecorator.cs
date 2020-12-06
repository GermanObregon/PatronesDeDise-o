using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020;

namespace Metodologia2C2020.Decorator
{
    public interface Idecorator
    {
        string mostrarCalificacion();
        Icomparable getLegajo();
        Numero getCalificacion();
        string getNombre();

    }
}
