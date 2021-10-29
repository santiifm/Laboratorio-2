using System;
using System.Collections.Generic;
using System.Text;

namespace Desafío_Interfaces
{
    class Contrato : Imprimible
    {
        void Imprimible.imprimir()
        {
            Console.WriteLine("Soy un contrato muy legal");
        }
    }
}
