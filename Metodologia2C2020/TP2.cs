using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Metodologia2C2020.Strategy;
using Metodologia2C2020.Iterator;


namespace Metodologia2C2020
{
    class TP2
    {
        public static void Run()
        {
            Pila pila = new Pila();
            //Cola cola = new Cola();
            //Diccionario dic = new Diccionario();
            //Conjunto conjunto = new Conjunto();
            //ColeccionMultiple multiple = new ColeccionMultiple(pila , cola);
            //LlenarAlumnos(conjunto); 

            LlenarAlumnos(pila);
            setEstrategia(new estrategiaPorDNI() , pila);
            TP1.Informar(pila);

            setEstrategia(new estrategiaPorLegajo(), pila);
            TP1.Informar(pila);

            setEstrategia(new estrategiaPorPromedio(), pila);
            TP1.Informar(pila);

            
            //LlenarAlumnos(cola);
            //LlenarAlumnos(dic);
            //imprimirElementos(conjunto);
            //imprimirElementos(pila);
            //imprimirElementos(cola);
            //imprimirElementos(dic);
            //TP1.Informar(multiple);
            
            Console.ReadKey();

        }

        public static void setEstrategia (Iestrategia estrategia , Icoleccionable coleccion)
        {
            Iterador iter = coleccion.crearIterador();
            while (!iter.Fin())
            {
                ((Alumno)iter.Actual()).setEstrategia(estrategia);
                iter.Siguiente();
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
                Iestrategia nuevaEtrategia = new estrategiaPorPromedio();
                Icomparable alumno = new Alumno(nombre.ToString(), rnd.Next(5000000, 40000000), rnd.Next(2000), rnd.Next(11));
                ((Alumno)alumno).setEstrategia(nuevaEtrategia);
                coleccion.Agregar(alumno);
                Thread.Sleep(50);
            }
        }
        public static void imprimirElementos(Icoleccionable coleccion)
        {
            Iterador iter =  coleccion.crearIterador();
            while (!iter.Fin())
            {
                Console.WriteLine(iter.Actual());
                iter.Siguiente();
            }
        }
    }
}
