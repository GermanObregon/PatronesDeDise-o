using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Iterator;

namespace Metodologia2C2020
{
    class ColeccionMultiple : Icoleccionable
    {
        private Pila _pila;
        private Cola _cola;

        public ColeccionMultiple(Pila pila , Cola cola)
        {
            this._pila = pila;
            this._cola = cola;

        }

        public void Agregar(Icomparable elemento)
        {

        }
        public List<Icomparable> getListaMultiple()
        {
            List<Icomparable> aux = new List<Icomparable>();
            foreach (Icomparable item in _pila.getPila())
            {
                aux.Add(item);
            }
            foreach (Icomparable item2 in _cola.getCola())
            {
                aux.Add(item2);
            }
            return aux;
        }

        public bool contiene(Icomparable elemento)
        {
            if (this._pila.contiene(elemento) || this._cola.contiene(elemento))
            {
                return true;
            }
            else { return false; }
        }

        public Iterador crearIterador()
        {
            return new IteradorMultiple(this);
        }

        public int Cuantos()
        {
            int cantidadTotal;
            int cantidadEnPila = this._pila.Cuantos();
            int cantidadEnCola = this._cola.Cuantos();
            cantidadTotal = cantidadEnPila + cantidadEnCola;
            return cantidadTotal;
        }

        public Icomparable Maximo()
        {
            Icomparable maximoEnCola = this._cola.Maximo();
            Icomparable maximoEnPila = this._pila.Maximo();

            if (maximoEnCola.sosMayor(maximoEnPila) == true)
            {
                return maximoEnPila;
            }else { return maximoEnCola; }
        }

        public Icomparable Minimo()
        {
            Icomparable minimoEnPila = this._pila.Minimo();
            Icomparable minimoEnCola = this._cola.Minimo();

            if (minimoEnCola.sosMayor(minimoEnPila) == true)
            {
                return minimoEnPila;
            }else { return minimoEnCola; }
        }
    }
}
