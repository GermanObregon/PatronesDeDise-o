using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Iterator;
using Metodologia2C2020.Command;

namespace Metodologia2C2020
{
    class Pila : Icoleccionable , Ordenable
    {
        private Stack<Icomparable> _pila;
        private OrdenEnAula1 _OrdenInicio;
        private OrdenEnAula1 _OrdenAulaLlena;
        private OrdenEnAula2 _OrdenLlegaAlumno;

        public Pila()
        {
            this._pila = new Stack<Icomparable>();
        }
        public Stack<Icomparable> getPila()
        {
            return this._pila;
        }

        public void Agregar(Icomparable nuevoElemento)
        {
            
            if (this._pila.Count() == 0)
            {
                this._OrdenInicio.ejecutar();
                this._OrdenLlegaAlumno.ejecutar(nuevoElemento);
            }
            this._OrdenLlegaAlumno.ejecutar(nuevoElemento);
            this._pila.Push(nuevoElemento);
            if (this._pila.Count() == 40)
            {
                this._OrdenAulaLlena.ejecutar();
            }
        }

        public bool contiene(Icomparable elemento)
        {
            return this._pila.Contains(elemento);
        }

        public int Cuantos()
        {
            return this._pila.Count;
        }

        public Icomparable Maximo()
        {
            Icomparable valorMayor = null;
            
            foreach (Icomparable elemento in this._pila )
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

            foreach (Icomparable elemento in this._pila)
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

        public Iterador crearIterador()
        {
            return new IteradorDePila(this);
        }

        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            this._OrdenInicio = orden;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            this._OrdenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 orden)
        {
            this._OrdenAulaLlena = orden;
        }
    }
}
