using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Factory_Method
{
    class FabricaDeAlumnosConcretos : FabricaDeComparables
    {
        


        public Icomparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            Icomparable Alumno = new Alumno(generador.stringAleatorio(5), generador.numeroAleatorio(999999).getValor(), generador.numeroAleatorio(999).getValor(), generador.numeroAleatorio(10).getValor());
            return Alumno;
        }

        public Icomparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            Console.WriteLine("Ingrese Nombre: ");
            string nombre = lector.stringPorTeclado();
            Console.WriteLine("Ingrese dni: ");
            Numero dni = lector.numeroPorTeclado();
            Console.WriteLine("Ingrese Legajo: ");
            Numero Legajo = lector.numeroPorTeclado();
            Console.WriteLine("Ingrese Proemdio: ");
            Numero Promedio = lector.numeroPorTeclado();

            Icomparable alumno = new Alumno(nombre, dni.getValor(), Legajo.getValor() , Promedio.getValor());
            return alumno;

        }
    }
}
