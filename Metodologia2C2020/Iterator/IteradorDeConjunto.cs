using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Iterator
{
    class IteradorDeConjunto : Iterador
    {
        private int _posicionActual;
        private List<Icomparable> _conjunto;

        public IteradorDeConjunto(Conjunto conjunto)
        {
            this._conjunto = conjunto.getListaConjunto();

            this._posicionActual = 0;
        }
        public object Actual()
        {
            return this._conjunto[_posicionActual];
        }

        public bool Fin()
        {
            return this._posicionActual >= this._conjunto.Count();
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

