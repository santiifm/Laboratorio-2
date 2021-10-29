using System;
using System.Collections.Generic;
using System.Text;

namespace Desafío_Interfaces
{
    class Documento : Imprimible
    {
        void Imprimible.imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
