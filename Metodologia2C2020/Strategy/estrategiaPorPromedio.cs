using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Strategy
{
    class estrategiaPorPromedio : Iestrategia
    {
      

        public bool sosIgual(Icomparable self, Icomparable comparable)
        {
            if (((Alumno)self).getPromedio().sosIgual(((Alumno)comparable).getPromedio()) == true)
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
            if (((Alumno)self).getPromedio().sosMayor(((Alumno)comparable).getPromedio()) == true)
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
            if (((Alumno)self).getPromedio().sosMenor(((Alumno)comparable).getPromedio()) == true)
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
