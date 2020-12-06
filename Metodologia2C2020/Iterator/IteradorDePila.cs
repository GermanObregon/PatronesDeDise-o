using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Iterator
{
    class IteradorDePila : Iterador
    {
        private int _posicionActual;
        private List<Icomparable> _pila;

        public IteradorDePila(Pila pila)
        {
            this._pila = pila.getPila().ToList<Icomparable>(); ;

            this._posicionActual = 0;
        }
        public object Actual()
        {
            return this._pila[_posicionActual];
        }

        public bool Fin()
        {
            return this._posicionActual >= this._pila.Count();
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

