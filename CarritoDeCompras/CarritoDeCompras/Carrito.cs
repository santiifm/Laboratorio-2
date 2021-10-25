using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    class Carrito
    {
        private int CantCamisas;
        private int Descuento;
        
        public void AgregarCamisa()
        {
            CantCamisas++;
        }
        public void QuitarCamisa()
        {
            CantCamisas--;
        }
        public int MostrarCamisas()
        {
            return CantCamisas;
        }
        public int AplicarDescuento()
        {
            if (CantCamisas <= 5 && CantCamisas >= 3)
            {
                Descuento = 10;
            }
            else if (CantCamisas >= 5)
            {
                Descuento = 20;
            }
            return Descuento;
        }

    }
}
