using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Factory_Method
{
    class FabricaDeVendedorConcreto : FabricaDeComparables
    {
        public Icomparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            Icomparable vendedor = new Vendedor(generador.stringAleatorio(8), generador.numeroAleatorio(9999999).getValor(), generador.numeroAleatorio(70000));

            return vendedor;
        }

        public Icomparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            Console.WriteLine("Ingrese Nombre: ");
            string nombre = lector.stringPorTeclado();
            Console.WriteLine("Ingrese dni: ");
            Numero dni = lector.numeroPorTeclado();
            Console.WriteLine("Ingrese sueldo: ");
            Numero sueldo = lector.numeroPorTeclado();
           
            Icomparable Vendedor = new Vendedor(nombre, dni.getValor(),sueldo);
            return Vendedor;
        }
    }
}
