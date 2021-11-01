using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Herencia_para_Practicar
{
    class Lavadora : Electrodomesticos
    {
        int carga;

        public Lavadora()
        {
            precioBase = 100;
            color = "blanco";
            consumoEnergetico = "f";
            peso = 5;
            carga = 5;
        }
        public Lavadora(double precioBase, int peso)
        {
            color = "blanco";
            consumoEnergetico = "f";
            carga = 5;
        }
        public Lavadora(double precioBase, string color, string consumoEnergetico, int peso, int carga)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }
        public int GetCarga()
        {
            return carga;
        }
        new public double precioFinal()
        {
            double precioFinal;
            if (carga > 30)
            {
                precioFinal = base.precioFinal() + 50;
            }
            else precioFinal = base.precioFinal();
            return precioFinal;
        }
    }
}
