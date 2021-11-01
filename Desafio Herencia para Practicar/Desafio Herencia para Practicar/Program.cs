using System;
using System.Collections.Generic;

namespace Desafio_Herencia_para_Practicar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomesticos> listaElectro = new List<Electrodomesticos>();
            listaElectro.Add(new Lavadora(100, "verde", "a", 15, 200));
            listaElectro.Add(new Television(400, "blanco", "c", 60, 30, true));
            listaElectro.Add(new Lavadora(60, "verde", "c", 20, 250));



            double TotalPrecioElectrod = 0;

            string PrecioxLavadora = "";
            string PrecioxTv = "";
            int l = 0;
            int t = 0;


            var count = listaElectro.Count;


            foreach (Electrodomesticos c in listaElectro)
            {
                TotalPrecioElectrod += c.precioFinal();

                if (c.GetType() == typeof(Lavadora))
                {
                    l++;
                    PrecioxLavadora += "El Precio de la Lavadora " + l + " es " + c.precioFinal() + "\n";

                }
                if (c.GetType() == typeof(Television))
                {
                    t++;
                    PrecioxTv += "El Precio del Televisor " + t + " es " + c.precioFinal() + "\n";

                }

            }


            Console.WriteLine("La suma del precio de los electrodomesticos es de " + TotalPrecioElectrod);
            Console.WriteLine(PrecioxLavadora);
            Console.WriteLine(PrecioxTv);
        }
    }
}
