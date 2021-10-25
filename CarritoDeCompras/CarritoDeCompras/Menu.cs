using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    class Menu
    {
        int salir = 0;
        float precio;
        float descuento;
        float precioFinal;
        Carrito carrito = new Carrito();

        public void Mostrar()
        {
            Console.WriteLine("Bienvenido al Sistema de Compra de Camisas");
            Console.WriteLine("Elija una de las siguientes opciones del menú");
            Console.WriteLine("1- Agregar Camisa al Carrito");
            Console.WriteLine("2- Eliminar Camisa del Carrito");
            Console.WriteLine("3- Salir");
            Console.WriteLine("Carrito: ");
            Console.WriteLine("Cantidad Camisas: " + carrito.MostrarCamisas());
            Console.WriteLine("Precio Unitario: $1000");
            Console.WriteLine("Precio total sin descuento: $" + precio);
            Console.WriteLine("Descuento aplicado: %" + descuento);
            Console.WriteLine("Precio total con descuento: $" + precioFinal);
            Console.WriteLine("Ingrese una opción del menu: ");
        }
        public void Calcular()
        {
            precio = carrito.MostrarCamisas()*1000;
            descuento = carrito.AplicarDescuento();
            precioFinal = precio - (precio * (descuento/100));
        }
        public void SeleccionarOpcion()
        {
            int Entrada = Convert.ToInt32(Console.ReadLine());

            switch (Entrada)
            {
                case 1: carrito.AgregarCamisa();
                    break;

                case 2: carrito.QuitarCamisa();
                    break;
                case 3: Console.Clear();
                    Console.WriteLine("Está seguro que desea salir? S/N");
                    string Salida= Console.ReadLine();
                    if (Salida == "S" || Salida == "s")
                    {
                        salir = 1;
                    }
                    break;
            }
        }
        public int GetSalir()
        {
            return salir;
        }
    }
}
