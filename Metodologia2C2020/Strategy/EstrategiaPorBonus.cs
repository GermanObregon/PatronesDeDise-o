using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Strategy
{
    class EstrategiaPorBonus : Iestrategia
    {
        public bool sosIgual(Icomparable self, Icomparable comparable)
        {
            if (((Vendedor)self).getBonus() == ((Vendedor)comparable).getBonus())
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
            if (((Vendedor)self).getBonus() < ((Vendedor)comparable).getBonus()) 
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
            if (((Vendedor)self).getBonus() > ((Vendedor)comparable).getBonus())
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
