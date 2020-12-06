using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia2C2020.Proxy
{
    class AlumnoProxy : IAlumno
    {
        private Alumno alumno = null;
        private Icomparable _legajo;
        private Icomparable _promedio;
        private Numero _calificacion;
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        public AlumnoProxy(string nombre, int dni, int legajo , int promedio) : base(nombre, dni)
        {
            this._legajo = new Numero(legajo);
            this._promedio = new Numero(promedio);
            this._calificacion = new Numero(0);

        }

        public override Numero getCalificacion()
        {
            if (this.alumno == null)
            {
                return this._calificacion;
            }
            else
            {
                return alumno.getCalificacion();
            }
        }

        public override Icomparable getLegajo()
        {
            if (this.alumno ==  null)
            {
                return this._legajo;
            }
            else
            {
                return alumno.getLegajo();
            }
        }

        public override Icomparable getPromedio()
        {
            if (this.alumno == null)
            {
                return this._promedio;
            }
            else
            {
                return alumno.getPromedio();
            }
        }

        public override string mostrarCalificacion()
        {
            if (this.alumno == null)
            {
                return this.getNombre() + " " + this.getCalificacion();
            }
            else
            {
                return this.alumno.getNombre() + " " + this.alumno.getCalificacion();
            }
            
        }

        public override int respondePreguta(int pregunta)
        {
            if (this.alumno == null)
            {
                this.alumno = new Alumno(this.getNombre(),((Numero)this.getDni()).getValor(),((Numero)this.getLegajo()).getValor(),((Numero)this.getPromedio()).getValor());
                this.alumno.SetCalificacion(this._calificacion.getValor());
            }
            return alumno.respondePreguta(pregunta);
        }

        public override void SetCalificacion(int calificacion)
        {
            if (this.alumno != null)
            {
                alumno.SetCalificacion(calificacion);
            }
            else
            {
                this._calificacion = new Numero(calificacion);
            }
        }

        public override void setLegajo(Icomparable legajo)
        {
            if (this.alumno != null)
            {
                alumno.setLegajo(legajo);
            }
            else
            {
                this._legajo = (Numero)legajo;
            }
        }

        public override void setPromedio(Icomparable promedio)
        {
            if (this.alumno != null)
            {
                alumno.setLegajo(promedio);
            }
            else
            {
                this._promedio = (Numero)promedio;
            }
        }
        public override string ToString()
        {
            return "Nombre: " + base.getNombre().ToString() + " " + "Documento: " + base.getDni() + " " + "Promedio: " + ((Numero)this._promedio).getValor() + " " + "Legajo: " + ((Numero)this.getLegajo()).getValor()+" "+ "Calificacion: "+this.getCalificacion().getValor();

        }
    }
}
