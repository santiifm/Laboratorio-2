using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioInterfaces2
{
    class Superman : Volable
    {
        int experiencia = 500;
        void Volable.volador()
        {
            Console.WriteLine("Estoy volando como un campeón...");
            experiencia = experiencia + 3;
        }
    }
}
