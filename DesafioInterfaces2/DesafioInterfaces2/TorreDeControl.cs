using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioInterfaces2
{
    class TorreDeControl
    {
        List<Volable> volador = new List<Volable>();

        public void vuelenTodos()
        {
            foreach (Volable volar in volador)
            {
                volar.volador();
            }
        }
        public void AgregarVolador(Volable unVolable)
        {
            volador.Add(unVolable);
        }
    }
}
