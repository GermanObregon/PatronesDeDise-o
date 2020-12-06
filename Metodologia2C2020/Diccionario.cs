using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Iterator;

namespace Metodologia2C2020
{
    class Diccionario : Icoleccionable
    {
        Dictionary<object ,Icomparable> diccionario;
        public Diccionario()
        {
            this.diccionario = new Dictionary<object, Icomparable>();
        }

        //public void agregar(object clave , Icomparable valor)
        //{
        //    this.diccionario.Add(clave, valor);
        //}
        public Icomparable valorDe(object clave)
        {
            return this.diccionario[clave];
        }

        public List<Icomparable> getListaDiccionario()
        {
            List<Icomparable> aux = new List<Icomparable>();
            foreach (Icomparable item in this.diccionario.Values)
            {
                aux.Add(item);

            }
            return aux;
        }

        public void Agregar(Icomparable elemento)
        {
            this.diccionario.Add(diccionario.Count(), elemento);
        }

        public bool contiene(Icomparable elemento)
        {
            return this.diccionario.ContainsValue(elemento);
        }

        public int Cuantos()
        {
            return this.diccionario.Count();
        }

        public Icomparable Maximo()
        {
            Icomparable valorMayor = null;

            foreach (Icomparable elemento in this.diccionario.Values)
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

            foreach (Icomparable elemento in this.diccionario.Values)
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
            return new IteradorDeDiccionario(this);
        }
    }
}
