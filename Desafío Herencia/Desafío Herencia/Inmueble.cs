using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Herencia
{
    abstract class Inmueble{
        private string direccion;
        private int metros;
        private string estado;
        private int antiguedad;
        private int precio_base;

        public Inmueble(string direccion, int metros, string estado, int antiguedad, int precio_base)
        {
            this.direccion = direccion;
            this.metros = metros;
            this.estado = estado;
            this.antiguedad = antiguedad;
            this.precio_base = precio_base;
        }
    }
}
