using System;

namespace TP1EJ1
{
    public class Ejercicio1a
    {
        static void Main(string[] args)
        {
            int miliseg = DateTime.Now.Millisecond;
            int dado = miliseg % 100 + 1;
            Console.Write("Ha tirado un: ");
            Console.WriteLine(dado);
        }
    }
}
