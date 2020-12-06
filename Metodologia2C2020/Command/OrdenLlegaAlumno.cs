using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Command
{
    class OrdenLlegaAlumno : OrdenEnAula2
    {
        private Aula _aula;
        public OrdenLlegaAlumno(Aula aula)
        {
            this._aula = aula;
        }
        public void ejecutar(Icomparable comparable)
        {
            var alumno = (IAlumno)comparable;
            this._aula.nuevoAlumno(alumno);
        }
    }
}
