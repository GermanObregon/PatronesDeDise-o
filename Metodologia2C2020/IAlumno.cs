using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metodologia2C2020
{
    public abstract class IAlumno : Persona
    {
        public IAlumno(string nombre, int dni) : base(nombre, dni)
        {
        }
        public abstract void setLegajo(Icomparable legajo);
        public abstract Icomparable getLegajo();
        public abstract void setPromedio(Icomparable promedio);
        public abstract Icomparable getPromedio();
        public abstract Numero getCalificacion();
        public abstract void SetCalificacion(int calificacion);
        public abstract int respondePreguta(int pregunta);
        public abstract string mostrarCalificacion();

    }
}
