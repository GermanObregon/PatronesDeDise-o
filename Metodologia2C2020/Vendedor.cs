using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologia2C2020.Observer;
using Metodologia2C2020.Strategy;

namespace Metodologia2C2020
{
    class Vendedor : Persona , Iobservado 
    {
        private Numero sueldoBasico;
        private Double bonus;
        private List<Iobservador> observadores;
        private Iestrategia estrategia;
        private int _montoVenta;

        public Vendedor(string nombre, int dni , Numero sueldo ) : base(nombre, dni)
        {
            this.sueldoBasico = sueldo;
            this.bonus = 1;
            this.observadores = new List<Iobservador>();
            this.estrategia = new EstrategiaPorBonus();


        }
        public override bool sosIgual(Icomparable comparable)
        {
            return estrategia.sosIgual(this, comparable);
        }
        public override bool sosMayor(Icomparable comparable)
        {
            return estrategia.sosMayor(this, comparable);
        }
        public override bool sosMenor(Icomparable comparable)
        {
            return estrategia.sosMenor(this, comparable);
        }
        public Double getBonus()
        {
            return this.bonus;
        }
        public void venta(int monto)
        {
            string valor = Convert.ToString(monto);
            this._montoVenta = monto;
            this.notificar();
            Console.WriteLine(valor);
        }
        public int getMontoDeVenta()
        {
            return this._montoVenta;
        }
        public void aumentarBonus()
        {
            this.bonus = this.bonus + 0.1;
        }

        public void agregarObservador(Iobservador o)
        {
            this.observadores.Add(o);
        }

        public void quitarObservador(Iobservador o)
        {
            this.observadores.Remove(o);
        }

        public void notificar()
        {
            foreach (Iobservador item in observadores)
            {
                item.actualizar(this);

            }
        }
        public override string ToString()
        {
            return "Nombre: " + base.getNombre().ToString() + " " + "Documento: " + base.getDni() + " " + "Sueldo: " + this.sueldoBasico.getValor();

        }
    }
}
