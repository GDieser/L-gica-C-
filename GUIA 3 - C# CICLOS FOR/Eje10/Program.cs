using System;

namespace Eje10
{
    /*Hacer un programa para ingresar una lista de 10 números, luego informar el máximo y la posición
    del máximo en la lista. En caso de “empates” considerar la primera aparición.
    Ejemplo A: 5, -10, 20, 8, 25, 13, 35, -8, -5, 20. Listará Máximo 35 Posición 7.
    Ejemplo B: 5, -10, 2, 8, 25, 13, 55, -8, 55, 9. Listará Máximo 55 Posición 7.
    Ejemplo C: -15, -10, -20, -8, -25, -13, -55, -6, -55, -20. Listará Máximo -6 Posición 8.
    El tercer ejemplo demuestra que NO SIEMPRE en una lista de números el máximo es un positivo
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, n, may = 0, pos = 0;

            for (x = 1; x <= 10; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    may = n;
                    pos = 1;
                }

                if (n > may)
                {
                    may = n;
                    pos = x;
                }
            }

            Console.WriteLine("Numero maximo: " + may + ", Posicion: " + pos);
        }
    }
}
