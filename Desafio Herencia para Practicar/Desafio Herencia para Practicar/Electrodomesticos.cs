using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Herencia_para_Practicar
{
    class Electrodomesticos
    {
        protected double precioBase;
        protected string color;
        protected string consumoEnergetico;
        protected int peso;

        public Electrodomesticos()
        {
            precioBase = 100;
            color = "blanco";
            consumoEnergetico = "f";
            peso = 5;
        }
        public Electrodomesticos(double precioBase, int peso)
        {
            this.precioBase = precioBase;
            color = "blanco";
            consumoEnergetico = "f";
            this.peso = peso;
        }
        public Electrodomesticos(double precioBase, string color, string consumoEnergetico, int peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.peso = peso;
            comprobarConsumoEnergetico(consumoEnergetico);
            comprobarColor(color);
        }
        private void comprobarConsumoEnergetico(string letra)
        {
            if (letra == "a" || letra == "b" || letra == "c" || letra == "d" || letra == "e" || letra == "f")
            {
                this.consumoEnergetico = letra;
            }
            else this.consumoEnergetico = "f";
        }
        private void comprobarColor(string color)
        {
            if (color == "blanco" || color == "negro" || color == "rojo" || color == "azul" || color == "gris")
            {
                this.color = color;
            }
            else color = "blanco";
        }
        public double precioFinal()
        {
            double precioFinal;
            double aumentoPeso;
            double aumentoConsumo;

            if (consumoEnergetico == "a")
            {
                aumentoConsumo = 100;
            }
            else if (consumoEnergetico == "b")
            {
                aumentoConsumo = 80;
            }
            else if (consumoEnergetico == "c")
            {
                aumentoConsumo = 60;
            }
            else if (consumoEnergetico == "d")
            {
                aumentoConsumo = 50;
            }
            else if (consumoEnergetico == "e")
            {
                aumentoConsumo = 30;
            }
            else aumentoConsumo = 10;

            if (peso > 0 && peso <= 19)
            {
                aumentoPeso = 10;
            }
            else if (peso > 20 && peso <= 49)
            {
                aumentoPeso = 50;
            }
            else if (peso > 50 && peso <= 79)
            {
                aumentoPeso = 80;
            }
            else aumentoPeso = 100;

            return precioFinal = precioBase + aumentoConsumo + aumentoPeso;
        }
        public double GetPrecioBase()
        {
            return precioBase;
        }
        public int GetPeso()
        {
            return peso;
        }
        public string GetColor()
        {
            return color;
        }
        public string GetConsumoEnergetico()
        {
            return consumoEnergetico;
        }
    }
}
