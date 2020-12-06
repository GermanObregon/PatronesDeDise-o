using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Decorator;

namespace Metodologia2C2020.Decorator
{
    class DecoradorNotaEnLetras : Decorador
    {
        public DecoradorNotaEnLetras(Idecorator dec) : base(dec)
        {
        }

        public override string mostrarCalificacion()
        {
            List<string> numeros = new List<string>();
            numeros.Add("cero");
            numeros.Add("uno");
            numeros.Add("dos");
            numeros.Add("tres");
            numeros.Add("cuatro");
            numeros.Add("cinco");
            numeros.Add("seis");
            numeros.Add("siete");
            numeros.Add("ocho");
            numeros.Add("nueve");
            numeros.Add("diez");
            

            return this.getDecorador().getNombre() + "   " + this.getDecorador().getCalificacion().getValor() + "(" + numeros[this.getDecorador().getCalificacion().getValor()]+")";
        }
    }
}
