using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Strategy
{
    class estrategiaPorDNI : Iestrategia
    {
        
        public bool sosIgual(Icomparable self, Icomparable comparable)
        {

            if (((Alumno)self).getDni().sosIgual(((Alumno)comparable).getDni()) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                
        public bool sosMayor(Icomparable self, Icomparable comparable)
        {
            if (((Alumno)self).getDni().sosMayor(((Alumno)comparable).getDni()) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Icomparable self, Icomparable comparable)
        {
            if (((Alumno)self).getDni().sosMenor(((Alumno)comparable).getDni()) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
