using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Iterator;

namespace Metodologia2C2020
{
    class Cola : Icoleccionable 
    {
        private Queue<Icomparable> _cola;

        public Cola()
        {
            this._cola = new Queue<Icomparable>();
        }

        public void Agregar(Icomparable elemento)
        {
            this._cola.Enqueue(elemento);
        }

        public bool contiene(Icomparable elemento)
        {
            foreach (Icomparable item in this._cola)
            {
                if (item.sosIgual(elemento) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public int Cuantos()
        {
            return this._cola.Count;
        }
        public Icomparable Maximo()
        {
            Icomparable valorMayor = null;

            foreach (Icomparable elemento in this._cola)
            {
                if (valorMayor == null)
                {
                    valorMayor = elemento;
                }
                if (elemento.sosMayor(valorMayor) == true)
                {
                    valorMayor = elemento;
                }
            }
            return valorMayor;
        }

        public Icomparable Minimo()
        {
            Icomparable valorMinimo = null;

            foreach (Icomparable elemento in this._cola)
            {
                if (valorMinimo == null)
                {
                    valorMinimo = elemento;
                }
                if (elemento.sosMenor(valorMinimo) == true)
                {
                    valorMinimo = elemento;
                }
            }
            return valorMinimo;
        }
        public Queue<Icomparable> getCola()
        {
            return this._cola;
        }

        public Iterador crearIterador()
        {
            return new IteradorDeCola(this);
        }
    }
}
