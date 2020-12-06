using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Decorator;

namespace Metodologia2C2020.Decorator
{
    class DecoradorNotaPromocion : Decorador
    {
        public DecoradorNotaPromocion(Idecorator dec) : base(dec)
        {
        }

        public override string mostrarCalificacion()
        {
            if (this.getDecorador().getCalificacion().getValor() >= 7)
            {
                return this.getDecorador().getNombre() + "  " + this.getDecorador().getCalificacion().getValor() + "(Promocion)";
            }
            if (this.getDecorador().getCalificacion().getValor() < 7 && this.getDecorador().getCalificacion().getValor() >= 4)
            {
                return this.getDecorador().getNombre() + "  " + this.getDecorador().getCalificacion().getValor() + "(Aprobado)";
            }
            if (this.getDecorador().getCalificacion().getValor() < 4)
            {
                return this.getDecorador().getNombre() + "  " + this.getDecorador().getCalificacion().getValor() + "(Desaprobado)";
            }
            return null;
        }
    }
}
