using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Metodologia2C2020
{
    class GeneradorDeDatosAleatorios
    {
        public Numero numeroAleatorio(int max)
        {
            Random rnd = new Random();
            return new Numero(rnd.Next(0, max));
        }

        public string stringAleatorio(int cantidadCaracteres)
        {
            Random rnd = new Random();
            StringBuilder nombre = new StringBuilder();
            char n;
            for (int b = 0; b < cantidadCaracteres; b++)
            {
                double flt = rnd.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                n = Convert.ToChar(shift + 65);
                nombre.Append(n);
                Thread.Sleep(50);
            }
            return nombre.ToString();
        }
    }
}
