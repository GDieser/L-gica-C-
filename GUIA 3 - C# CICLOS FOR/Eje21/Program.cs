using System;

namespace Eje21
{
    /*Se define como divisores propios de un número a aquellos que son sus divisores
    excluyendo al número en sí mismo.
    Ejemplo A. Los divisores propios del 4 son: 1 y 2.
    Ejemplo B. Los divisores propios del 12 son: 1, 2, 3, 4 y 6.

    Se define a un número como perfecto cuando la suma de todos sus divisores propios
    coincide con el número en sí mismo.
    Ejemplo A: 6 es número perfecto pues 1+2+3=6
    Ejemplo B: 28 es número perfecto pues 1+2+4+7+14=28
    Ejemplo C: 12 no es número perfecto pues 1+2+3+4+6=16

    Hacer un programa para ingresar un número y luego informar con un cartel aclaratorio si
    el mismo es un número perfecto o no es número perfecto

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, acumulador = 0;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for (x = 1; x <= num; x++)
            {

                if (num%x == 0)
                {
                    acumulador += x;
                }
            }

            if (num == (acumulador - num))
            {
                Console.WriteLine("El numero es perfecto ");
            }
            else
            {
                Console.WriteLine("El numero NO es perfecto ");
            }

            Console.ReadKey();
        }
    }
}
