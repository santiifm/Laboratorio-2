using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioInterfaces2
{
    class Boeing747 : Volable
    {
        int HorasDeVuelo = 233;
        void Volable.volador()
        {
            Console.WriteLine("Estoy volando como un avión...");
            HorasDeVuelo = HorasDeVuelo + 13;
        }
    }
}
