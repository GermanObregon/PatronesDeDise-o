using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Iterator
{
    class IteradorDeCola : Iterador
    {
        private int _posicionActual;
        private List<Icomparable> _cola;

        public IteradorDeCola(Cola cola)
        {
            this._cola = cola.getCola().ToList<Icomparable>(); ;
            
            this._posicionActual = 0;
        }
        public object Actual()
        {
            return this._cola[_posicionActual];
        }

        public bool Fin()
        {
            return this._posicionActual >= this._cola.Count();
        }

        public void Primero()
        {
            this._posicionActual = 0;

        }

        public void Siguiente()
        {
            this._posicionActual++;
        }
    }
}
