using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Iterator;
using Metodologia2C2020.Observer;

namespace Metodologia2C2020
{
    class Gerente : Iobservador
    {
        private Conjunto mejores;
        public Gerente()
        {
            this.mejores = new Conjunto();

        }

        public void actualizar(Iobservado o)
        {
            this.venta(((Vendedor)o).getMontoDeVenta(), ((Vendedor)o));
        }

        public void cerrar()
        {
            Iterador iter = mejores.crearIterador();
            while (!iter.Fin())
            {
                Console.WriteLine("Nombre: " + ((Vendedor)iter.Actual()).getNombre() + " " + "Bonus: " + ((Vendedor)iter.Actual()).getBonus());
                iter.Siguiente();
            }
        }
        public void venta (int monto , Vendedor vendedor)
        {
            if (monto >= 5000)
            {
                this.mejores.Agregar(vendedor);
                vendedor.aumentarBonus();

            }
        }
    }
}
