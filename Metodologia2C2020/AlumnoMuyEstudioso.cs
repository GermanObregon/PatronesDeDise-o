using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020
{
    class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
        {
        }
        public override int respondePreguta(int pregunta)
        {
            return pregunta % 3;
        }

    }
}
