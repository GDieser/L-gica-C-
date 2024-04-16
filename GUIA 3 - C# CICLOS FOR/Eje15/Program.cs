using System;

namespace Eje15
{
    /*Hacer un programa para ingresar una lista de 8 números y luego informar si todos están
    ordenados en forma creciente. En caso de haber dos números “empatados” considerarlos como
    crecientes.
    Por ejemplo si la lista fuera:
    Ejemplo A: -10, 1, 5, 7, 15, 18, 20, 23 se emitirá un cartel: “Conjunto Ordenado”
    Ejemplo B: 10, 10, 15, 20, 25, 25, 28, 33 se emitirá un cartel: “Conjunto Ordenado”
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, contador = 0, menor = 0;

            for (x = 0; x < 8; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    menor = num;
                }

                if (num >= menor)
                {
                    contador++;
                }

            }

            if (contador == 8)
            {
                Console.WriteLine("Conjunto ordenado...");
            }
            else
            {
                Console.WriteLine("Conjunto no ordenado...");
            }
            Console.ReadKey();
        }
    }
}
