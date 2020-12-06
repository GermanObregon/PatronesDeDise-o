using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Decorator
{
    class DecoradorLegajo : Decorador
    {
        public DecoradorLegajo(Idecorator dec) : base(dec)
        {
        }

        public override string mostrarCalificacion()
        {
            var legajo = (Numero)this.getDecorador().getLegajo();
           return  this.getDecorador().getNombre() + "[" + legajo.getValor() + "]" + "    " + this.getDecorador().getCalificacion().getValor();
        }
    }
}
