using Metodologia2C2020.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Factory_Method
{
    class FabricaDeAlumnosProxy : FabricaDeComparables
    {
        public Icomparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            Icomparable Alumno = new AlumnoProxy(generador.stringAleatorio(5), generador.numeroAleatorio(999999).getValor(), generador.numeroAleatorio(999).getValor(), generador.numeroAleatorio(10).getValor());
            return Alumno;
        }

        public Icomparable crearPorTeclado()
        {
            throw new NotImplementedException();
        }
    }
}
