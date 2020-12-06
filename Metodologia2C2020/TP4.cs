using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;
using Metodologia2C2020.Factory_Method;
using Metodologia2C2020.Iterator;
using Metodologia2C2020.Adapter;
using Metodologia2C2020.Decorator;
namespace Metodologia2C2020
{
    class TP4
    {
        public static void Run()
        {
            decorator();
            Console.ReadKey();
            
        }
        public static void decorator()
        {
            FabricaDeComparables fabrica = new FabricaDeAlumnosConcretos();
            Alumno alumno = (Alumno)fabrica.crearAleatorio();
            alumno.SetCalificacion(3);
            Decorador alumnoDecorado = new DecoradorNotaPromocion(alumno);
            Console.WriteLine(alumnoDecorado.mostrarCalificacion());
            

        }
        public static void  Adapter()
        {
            Teacher teachaer = new Teacher();
            Collection students = new ListOfStudent();
            Icoleccionable cola = new Cola();
            FabricaDeComparables fabrica = new FabricaDeAlumnosConcretos();
            TP3.llenar(cola, fabrica);
            Iterador iter = cola.crearIterador();
            while (!iter.Fin())
            {
                var alumno = (Alumno)iter.Actual();
                students.addStudent(new AdaptadorEstudiante_Student(alumno));
                iter.Siguiente();
            }

            teachaer.setStudents(students);
            teachaer.teachingAClass();
            Console.ReadKey();

        }
    }
}
