using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;

namespace Metodologia2C2020.Adapter
{
    class AdaptadorEstudiante_Student : Student
    {
        private IAlumno _alumno;

        public AdaptadorEstudiante_Student(IAlumno alumno)
        {
            this._alumno = alumno;
        }
        public bool equals(Student student)
        {
            return false;
        }

        public string getName()
        {
            return this._alumno.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return true;
        }

        public bool lessThan(Student student)
        {
            return false;
        }

        public void setScore(int score)
        {
            this._alumno.SetCalificacion(score);
        }

        public string showResult()
        {
            return this._alumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return this._alumno.respondePreguta(question);
        }
    }
}
