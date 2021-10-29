using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Desafío_Interfaces
{
    class Impresora
    {
        List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void ImprimirTodo()
        {
            foreach (Imprimible imprimir in ColaDeImpresion)
            {
                imprimir.imprimir();
            }
        }
        public void AgregarImprimible(Imprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
