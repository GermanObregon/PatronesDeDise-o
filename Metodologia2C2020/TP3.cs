using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Metodologia2C2020.Factory_Method;
using Metodologia2C2020.Iterator;

namespace Metodologia2C2020
{
    class TP3
    {
        public static void Run()
        {
            Cola cola = new Cola();
            FabricaDeComparables f = new FabricaDeVendedorConcreto();
            llenar(cola , f);
            Gerente gerente = new Gerente();
            foreach (Vendedor item in cola.getCola())
            {
                item.agregarObservador(gerente);
            }
            Console.WriteLine("Jornada de ventas");
            jornadaDeVentas(cola);
            Console.WriteLine("Mejores Vendedores");
            gerente.cerrar();
            //informar(cola, f);



            Console.ReadLine();
        }
        public static void jornadaDeVentas(Icoleccionable vendedores)
        {
            Iterador iter = vendedores.crearIterador();
            while (!iter.Fin())
            {
                Random rnd = new Random();
                int monto = rnd.Next(1, 7000);
                ((Vendedor)iter.Actual()).venta(monto);
                Thread.Sleep(100);
                iter.Siguiente();

            }
           
        }
        public static void llenar(Icoleccionable coleccion , FabricaDeComparables fabrica)
        {
            for (int i = 0; i < 20; i++)
            {
                coleccion.Agregar(fabrica.crearAleatorio());
                Thread.Sleep(50);
            }
        }
        public static void informar(Icoleccionable coleccion , FabricaDeComparables fabrica)
        {
            Console.WriteLine("Cantidad de elementos: " + coleccion.Cuantos());
            Console.WriteLine("El maxiomo es: " + coleccion.Maximo());
            Console.WriteLine("El Minimo es: " + coleccion.Minimo());
            Icomparable aux = fabrica.crearPorTeclado();
            if (coleccion.contiene(aux))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento leido no esta ne la coleccion");
            }
        }
    }
}
