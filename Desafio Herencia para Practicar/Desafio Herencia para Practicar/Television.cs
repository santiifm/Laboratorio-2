using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Herencia_para_Practicar
{
    class Television : Electrodomesticos
    {
        private int Resolucion;
        private bool SintonizadorTDT;

        public Television() : base()
        {
            precioBase = 100;
            color = "blanco";
            consumoEnergetico = "f";
            peso = 5;
            this.Resolucion = 20;
            this.SintonizadorTDT = false;
        }
        public Television(double precioBase, int peso) 
            : base(precioBase, peso)
        {
            color = "blanco";
            consumoEnergetico = "f";
            this.Resolucion = 20;
            this.SintonizadorTDT = false;
        }
        public Television(double precioBase, string color, string consumoEnergetico, int peso, int resolucion, bool sintonizadorTDT)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            Resolucion = resolucion;
            SintonizadorTDT = sintonizadorTDT;
        }
        public double getResolucion()
        {
            return Resolucion;
        }
        public bool getSintonizador()
        {
            return SintonizadorTDT;
        }
        new public double precioFinal()
        {

            double incremento = base.precioFinal();


            if (Resolucion > 40)
            {
                incremento += incremento * 0.3;
            }
            if (SintonizadorTDT)
            {
                incremento += incremento * 0.5;
            }

            return incremento;
        }
    }
}
