using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioInterfaces2
{
    class Pato : Volable
    {
        int energía = 100;
        void Volable.volador()
        {
            Console.WriteLine("Estoy volando como un pato... !Cuak¡");
            energía = energía - 5;
        }
    }
}
