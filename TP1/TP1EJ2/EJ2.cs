using System;

namespace TP1EJ2
{
    class EJ2
    {
        static void Main(string[] args)
        {
            Random dado = new Random();
            int aleatorio1 = dado.Next(1, 11);
            int aleatorio2 = dado.Next(11, 21);
            Console.WriteLine("Usted ha tirado {0} y {1}.", aleatorio1, aleatorio2);
        }
    }
}
