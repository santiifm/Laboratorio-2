using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_SantiagoFernándezMarcello
{
    class Pantalon : Prenda
    {
        public Pantalon(int calidad, int tipo, double precio, int cantidad)
               : base(calidad, tipo, precio, cantidad)
        {
            this.calidadPrenda = calidad;
            this.Tipo = tipo;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public double calcularPrecio()
        {
            double precioFinal;

            precioFinal = precio * cantidad;
            if (Tipo == 1)
            {
                precioFinal = precioFinal * 0.8;
            }
            if (calidadPrenda == 1)
            {
                precioFinal = precioFinal * 1.3;
            }
            return precioFinal;
        }
    }
}
