using Metodologia2C2020.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Decorator;


namespace Metodologia2C2020
{
    class Alumno :IAlumno,  Idecorator 
    {
        private Icomparable _legajo;
        private Icomparable _promedio;
        private Iestrategia estrategia;
        private Numero _calificacion;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.estrategia = new estrategiaPorPromedio();
            this._promedio = new Numero(promedio);
            this._legajo = new Numero(legajo);
            this._calificacion = new Numero(0);
            Console.WriteLine("Creando Alumno Real --> Patron  proxy");
        }
        public override Icomparable getLegajo()
        {
            return this._legajo;
        }
        public override Icomparable getPromedio()
        {
            return this._promedio;
        }
        public override Numero getCalificacion()
        {
            return this._calificacion;
        }
        public override void SetCalificacion(int calificacion)
        {
            this._calificacion = new Numero(calificacion);
        }
        public override  int respondePreguta(int pregunta)
        {
            Random rnd = new Random();
            return rnd.Next(1, 3);

        }
        public override string mostrarCalificacion()
        {
            return this.getNombre() + " " + this.getCalificacion();
        }
       
        public override bool sosIgual(Icomparable comprable)
        {
            return this.estrategia.sosIgual(this , (Alumno)comprable);
        }

        public override bool sosMenor(Icomparable comparable)
        {
            return this.estrategia.sosMenor(this, (Alumno)comparable);
        }

        public override bool  sosMayor(Icomparable comparable)
        {
            return this.estrategia.sosMayor(this, (Alumno)comparable);
        }
        public void setEstrategia (Iestrategia nuevaEstrategia)
        {
            this.estrategia = nuevaEstrategia;
        }

        public override string ToString()
        {
            return "Nombre: " + base.getNombre().ToString() + " " + "Documento: " + base.getDni() +" " + "Promedio: " + this.getPromedio() + " " + "Legajo: " + this.getLegajo(); 

        }

        public override void setLegajo(Icomparable legajo)
        {
            this._legajo = (Numero)legajo;
        }

        public override void setPromedio(Icomparable promedio)
        {
            this._promedio = (Numero)promedio;
        }
    }
}
