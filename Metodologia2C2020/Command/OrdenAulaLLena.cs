using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Command
{
    class OrdenAulaLLena : OrdenEnAula1
    {
        private Aula _aula;
        public OrdenAulaLLena(Aula aula)
        {
            this._aula = aula;
        }
        public void ejecutar()
        {
            this._aula.claseLista();
        }
    }
}
