using System;

namespace Eje18
{
    /*Hacer un programa para ingresar un número y luego informar todos los divisores
    pares de ese número.
    Ejemplo A. Si se ingresa 6 se listará: 2 y 6. Ejemplo B. Si se ingresa 8 se listará:
    2, 4 y 8. Ejemplo C. Si se ingresa 11 no se listará nada.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for (x = 1; x <= num; x++)
            {

                if (num % x == 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("El numero: " + x + " es divisor par de: " + num);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
