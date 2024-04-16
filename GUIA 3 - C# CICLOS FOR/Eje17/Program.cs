using System;

namespace Eje17
{
    /*Hacer un programa para ingresar un número y luego informar todos los
    divisores de ese número.
    Ejemplo A. Si se ingresa 6 se listarán: 1, 2, 3 y 6
    Ejemplo B. Si se ingresa 9 se listarán: 1, 3 y 9.
    Ejemplo 3. Si se ingresa 11 se listarán 1 y 11.
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
                    Console.WriteLine("El numero: " + x + " es divisor de: " + num);
                }
            }
            Console.ReadKey();
        }
    }
}
