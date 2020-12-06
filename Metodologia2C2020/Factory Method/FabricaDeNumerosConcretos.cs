using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Factory_Method
{
    class FabricaDeNumerosConcretos : FabricaDeComparables
    {
        public Icomparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return generador.numeroAleatorio(10);
        }

        public Icomparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            return lector.numeroPorTeclado();
        }
    }
}
