using System;
using System.Collections.Generic;
using System.Text;

namespace Desafío_Interfaces
{
    class Foto : Imprimible
    {
        void Imprimible.imprimir() {
            Console.WriteLine("Soy una selfie pal Insta");
        }
    }
}
