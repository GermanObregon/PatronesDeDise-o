using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020
{
    public class Numero : Icomparable
    {
        private int _valor;

        public Numero(int nuevoValor)
        {
            this._valor = nuevoValor;
        }
        public int getValor()
        {
            return this._valor;
        }

        public bool sosIgual(Icomparable comparable)
        {
            int nuevoValor = ((Numero)comparable).getValor();

            if (this._valor == nuevoValor)
            {
                return true;
            }
            else { return false; }
        }

        public bool sosMayor(Icomparable comparable)
        {
            int nuevoValor = ((Numero)comparable).getValor();

            if (nuevoValor < this._valor )
            {
                return true;
            }
            else { return false; }
        }

        public bool sosMenor(Icomparable comparable)
        {
            int nuevoValor = ((Numero)comparable).getValor();

            if (nuevoValor > this._valor)
            {
                return true;
            }
            else { return false; }
        }
        public override string ToString()
        {
            return this.getValor().ToString();
        }
    }
}
