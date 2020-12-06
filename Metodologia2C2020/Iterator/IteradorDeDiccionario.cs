using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Iterator
{
    class IteradorDeDiccionario : Iterador
    {
        private int _posicionActual;
        private List<Icomparable> _diccionario;

        public IteradorDeDiccionario(Diccionario diccionario)
        {
            this._diccionario = diccionario.getListaDiccionario();

            this._posicionActual = 0;
        }
        public object Actual()
        {
            return this._diccionario[_posicionActual];
        }

        public bool Fin()
        {
            return this._posicionActual >= this._diccionario.Count();
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

