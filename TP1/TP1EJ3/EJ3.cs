using System;

namespace TP1EJ3
{
    class EJ3
    {
        static void Main(string[] args)
        {
            int numero;
            int aciertos = 0;
            Random r = new Random();
            int aleatorio = r.Next(1, 7);
            Console.Write("Adivina el número aleatorio entre 1 y 6: ");

            for(int i = 0; i <= 2; i++)
            {
                numero = 0;
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == aleatorio)
                {
                    Console.WriteLine("El número ingresado es correcto. Felicitaciones!");
                    aciertos++;
                    continue;
                }
                else
                {
                    if (i == 2)
                    {
                        continue;
                    }
                    else if (numero < aleatorio)
                    {
                        Console.Write("Incorrecto, intente un número mas alto: ");
                    }
                    else if (numero > aleatorio)
                    {
                        Console.Write("Incorrecto, intente un número mas bajo: ");
                    }
                }
            }
            if (aciertos == 0)
            {
                Console.WriteLine("Se ha quedado sin intentos, el número era: {0}", aleatorio);
            }
        }
    }
}
