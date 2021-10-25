using System;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            do
            {
                Console.Clear();
                menu.Mostrar();
                menu.SeleccionarOpcion();
                menu.Calcular();
            } while (menu.GetSalir()!=1);
        }
    }
}
