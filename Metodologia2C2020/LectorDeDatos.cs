using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020
{
    class LectorDeDatos
    {
        public Numero numeroPorTeclado()
        {
            //Console.WriteLine("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return new Numero(num);
        }
        public string stringPorTeclado()
        {
            //Console.WriteLine("Ingrrese un String: ");
            string text = Console.ReadLine();
            return text;
        }
    }
}
