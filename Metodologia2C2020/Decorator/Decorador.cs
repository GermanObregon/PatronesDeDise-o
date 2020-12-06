using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Decorator
{
    public abstract class Decorador : Idecorator
    {
        private Idecorator elemento_dec;

        public Decorador(Idecorator dec)
        {
            this.elemento_dec = dec;
        }
        public abstract string mostrarCalificacion();

        public Idecorator getDecorador()
        {
            return this.elemento_dec;
        }

        public Icomparable getLegajo()
        {
            return elemento_dec.getLegajo();
        }

        public Numero getCalificacion()
        {
            return elemento_dec.getCalificacion();
        }

        public string getNombre()
        {
            return elemento_dec.getNombre();
        }
    }
}
