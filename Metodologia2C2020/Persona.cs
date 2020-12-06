using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020
{
    public class Persona : Icomparable
    {
        private string _nombre;
        private Icomparable _dni;

        public Persona(string nombre , int dni)
        {
            this._nombre = nombre;
            this._dni = new Numero(dni);
        }
        public string getNombre()
        {
            return this._nombre;
        }
        public Icomparable getDni()
        {
            return this._dni;
        }

        public virtual bool sosIgual(Icomparable comparable)
        {
            if (this._dni.sosIgual(comparable) == true)
            {
                return true;
            }else { return false; }
        }

        public virtual bool sosMenor(Icomparable comparable)
        {
            if (this._dni.sosMenor(comparable) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool sosMayor(Icomparable comparable)
        {
            if (this._dni.sosMayor(comparable) == true)
            {
                return true;

            }else { return false; }
        }
    }
}
