using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Strategy
{
    class estrategiaPorLegajo : Iestrategia
    {
        
        public bool sosIgual(Icomparable self, Icomparable comparable)
        {
            if (((Alumno)self).getLegajo().sosIgual(((Alumno)comparable).getLegajo()) == true)
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
            if (((Alumno)self).getLegajo().sosMayor(((Alumno)comparable).getLegajo()) == true)
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
            if (((Alumno)self).getLegajo().sosMenor(((Alumno)comparable).getLegajo()) == true)
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
