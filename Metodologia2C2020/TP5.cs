using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Proxy;
using MetodologíasDeProgramaciónI;
using Metodologia2C2020.Factory_Method;
using Metodologia2C2020.Iterator;
using Metodologia2C2020.Adapter;
using Metodologia2C2020.Command;

namespace Metodologia2C2020
{
    class TP5
    {
        public static void Run()
        {
            Proxy();
            ////command aplicado solo a la coleccion pila.
            //Aula aula = new Aula();
            //Pila pila = new Pila();
            //pila.setOrdenInicio(new OrdenAulaInicia(aula));
            //pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            //pila.setOrdenAulaLlena(new OrdenAulaLLena(aula));
            
            
            //FabricaDeComparables fabrica = new FabricaDeAlumnosConcretos();

            //TP3.llenar(pila , fabrica);
            //TP3.llenar(pila , fabrica);

            Console.ReadKey();
        }
        public static void Proxy()
        {
            //GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            //IAlumno alumno = new AlumnoProxy(generador.stringAleatorio(8), generador.numeroAleatorio(9999999).getValor());
            //Icomparable legajo = new Numero(generador.numeroAleatorio(999).getValor());
            //Icomparable promedio = new Numero(generador.numeroAleatorio(10).getValor());

            //alumno.setLegajo(legajo);
            //alumno.setPromedio(promedio);
            //alumno.SetCalificacion(5);

            //alumno.respondePreguta(2);

            //Console.WriteLine(alumno);

            Teacher teachaer = new Teacher();
            Collection students = new ListOfStudent();
            Icoleccionable cola = new Cola();
            FabricaDeComparables fabrica = new FabricaDeAlumnosProxy();
            TP3.llenar(cola, fabrica);
            Iterador iter = cola.crearIterador();
            while (!iter.Fin())
            {
                var alumno = (IAlumno)iter.Actual();
                students.addStudent(new AdaptadorEstudiante_Student(alumno));
                iter.Siguiente();
            }

            teachaer.setStudents(students);
            teachaer.teachingAClass();
            Console.ReadKey();

        }
    }
}
