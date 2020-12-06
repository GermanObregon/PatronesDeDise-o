using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;
using Metodologia2C2020.Adapter;

namespace Metodologia2C2020
{
    class Aula
    {
        private Teacher _teacher;
        public void comenzar()
        {
            Console.WriteLine("Comenzando...");
            this._teacher = new Teacher();

        }
        public void nuevoAlumno(IAlumno alumno)
        {
            this._teacher.goToClass(new AdaptadorEstudiante_Student(alumno));
        }
        public void claseLista()
        {
            this._teacher.teachingAClass();
        }
    }
}
