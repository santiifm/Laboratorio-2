using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Herencia
{
    class Locales : Inmueble
    {
        private int numero_de_ventanas;

        public Locales (string direccion, int metros, string estado, int antiguedad, int precio_base, int numero_de_ventanas)
            :base(direccion, metros, estado, antiguedad, precio_base)
        {
            this.numero_de_ventanas = numero_de_ventanas;
        }

        public double precio_final(int metros, int antiguedad, int precio_base, int numero_de_ventanas)
        {
            double precio_final = precio_base;
            if (antiguedad <= 15)
            {
                precio_final = precio_final * 0.99;
            }
            else precio_final = precio_final * 0.98;
            if (numero_de_ventanas <= 1)
            {
                precio_final = precio_final * 0.98;
            }
            else if (numero_de_ventanas >= 4)
            {
                precio_final = precio_final * 1.02;
            }
            if (metros > 50)
            {
                precio_final = precio_final * 1.01;
            }
            return precio_final;
        }

    }
}
