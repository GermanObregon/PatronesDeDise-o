using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Metodologia2C2020
{
    class TP1
    {
        public static void Run()
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);


            Console.ReadKey();

        }
        public static void LlenarColeccion(Icoleccionable coleccion)
        {
            for (int i = 0; i < 20; i++)
            {
                Random buscarRamdom = new Random();
                int valorRamdom = buscarRamdom.Next(100);
                Icomparable numero = new Numero(valorRamdom);
                coleccion.Agregar(numero);

            }
        }
        public static void Informar(Icoleccionable coleccion)
        {
            Console.WriteLine("Hay " + coleccion.Cuantos() + " elementos");
            Console.WriteLine("El minimo es " + coleccion.Minimo());
            Console.WriteLine("El maximo es " + coleccion.Maximo());

            Icomparable numeroAcomparar = new Numero(Convert.ToInt16(Console.ReadLine()));
            if (coleccion.contiene(numeroAcomparar) == true)
            {
                Console.WriteLine("El elemento esta en la coleccion");

            }
            else { Console.WriteLine("El elemento no esta en la coleccion"); }

        }
        public static void LlenarPersonas(Icoleccionable coleccion)
        {
            for (int i = 0; i < 20; i++)
            {
                Random rnd = new Random();
                StringBuilder nombre = new StringBuilder();
                char n;
                for (int b = 0; b < 8; b++)
                {
                    double flt = rnd.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    n = Convert.ToChar(shift + 65);
                    nombre.Append(n);
                    Thread.Sleep(50);
                }
                Persona p = new Persona(nombre.ToString(), rnd.Next(5000000, 50000000));
                coleccion.Agregar(p);
                Thread.Sleep(50);

            }
        }
        public static void LlenarAlumnos(Icoleccionable coleccion)
        {
            Random rnd = new Random();
            StringBuilder nombre = new StringBuilder();
            char n;
            for (int b = 0; b < 5; b++)
            {
                double flt = rnd.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                n = Convert.ToChar(shift + 65);
                nombre.Append(n);
                Thread.Sleep(50);
            }
            for (int i = 0; i < 20; i++)
            {
                Icomparable alumno = new Alumno(nombre.ToString(), rnd.Next(5000000, 40000000), rnd.Next(2000), rnd.Next(11));
                coleccion.Agregar(alumno);
                Thread.Sleep(50);
            }
        }
    }
}
