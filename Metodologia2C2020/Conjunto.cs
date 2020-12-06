using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Iterator;

namespace Metodologia2C2020
{
    class Conjunto : Icoleccionable
    {
        List<Icomparable> conjunto;
        public Conjunto()
        {
            this.conjunto = new List<Icomparable>();
        }
        public List<Icomparable> getListaConjunto()
        {
            return this.conjunto;
        }
      

        public void Agregar(Icomparable elemento)
        {
            if (this.conjunto.Contains(elemento) == false)
            {
                this.conjunto.Add(elemento);
            }
        }

        public bool contiene(Icomparable elemento)
        {
            return this.conjunto.Contains(elemento);
        }

        public Iterador crearIterador()
        {
            return new IteradorDeConjunto(this);
        }

        public int Cuantos()
        {
            return this.conjunto.Count();
        }

        public Icomparable Maximo()
        {
            Icomparable valorMayor = null;

            foreach (Icomparable elemento in this.conjunto)
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

            foreach (Icomparable elemento in this.conjunto)
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

        public bool pertenece (Icomparable elemento)
        {
            if (this.conjunto.Contains(elemento) == true)
            {
                return true;
            }
            else { return false; }
        }
    }
}
