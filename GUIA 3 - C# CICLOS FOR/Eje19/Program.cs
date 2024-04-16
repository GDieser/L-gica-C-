using System;

namespace Eje19
{
    /*Hacer un programa para ingresar un número y luego informar la cantidad de divisores de ese número.
    Ejemplo A. Si se ingresa 6 se listará: 4 divisores.
    Ejemplo B. Si se ingresa 9 se listará: 3 divisores.
    Ejemplo C. Si se ingresa 11 se listará: 2 divisores.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, contador = 0;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for (x = 1; x <= num; x++)
            {

                if (num % x == 0)
                {
                    contador++;
                }
            }

            Console.WriteLine("El numero de divisores posibles es: ");
        }
    }
}
