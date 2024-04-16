using System;

namespace Eje9
{
    /*Hacer un programa para ingresar una lista de 10 números, luego informar el máximo.
    Ejemplo A: 5, 10, 20, 8, 25, 13, 35, -8, -5, 20. Se listará Máximo 35.
    Ejemplo B: 5, 10, 20, 8, 55, 13, 55, -8, -5, 20. Se listará Máximo 55.
    Ejemplo C: -15, -10, -20, -8, -25, -13, -55, -6, -55, -20. Se listará Máximo -6
    El tercer ejemplo demuestra que NO SIEMPRE en una lista de números el máximo es un positivo.
    Para resolver este ejercicio sugerimos resolver antes el TP2 EJ 9 y TP2 EJ 10.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, mayor = 0;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    mayor = num;
                }

                if (num > mayor)
                {
                    mayor = num;
                }
            }

            Console.WriteLine("El mayor: " + mayor );

            Console.ReadLine();
        }
    }
}
