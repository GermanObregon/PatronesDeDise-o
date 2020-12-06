using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Command
{
    class OrdenAulaInicia : OrdenEnAula1
    {
        private Aula _aula;

        public OrdenAulaInicia(Aula aula)
        {
            this._aula = aula;
        }
        public void ejecutar()
        {
            this._aula.comenzar();
        }
    }
}
