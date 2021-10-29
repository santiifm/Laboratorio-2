using System;

namespace DesafioInterfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Boeing747 boeing = new Boeing747();
            Superman superman = new Superman();
            TorreDeControl torre = new TorreDeControl();

            torre.AgregarVolador(pato);
            torre.AgregarVolador(boeing);
            torre.AgregarVolador(superman);
            torre.vuelenTodos();
        }
    }
}
