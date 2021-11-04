using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_SantiagoFernándezMarcello
{
    abstract class Prenda
    {
        protected int calidadPrenda;
        protected int Tipo;
        protected double precio;
        protected int cantidad;

        public Prenda(int calidadPrenda, int Tipo, double precio, int cantidad)
        {
        }
    }
}
