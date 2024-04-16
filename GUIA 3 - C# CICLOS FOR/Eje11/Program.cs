using System;

namespace Eje11
{
    /*Se define a un número como primo cuando tiene solamente dos divisores. Ejemplo A: 2, 7, 11, 13
    son números primos, ya que todos tienen solamente dos divisores.
    Ejemplo B: 6 no es primo, pues tiene 4 divisores (1, 2, 3 y 6)
    Ejemplo C: 9 no es primo, pues tiene 3 divisores (1, 3 y 9)

    Hacer un programa para ingresar un número y luego informar con un cartel aclaratorio si el mismo
    es un número primo o es número no primo.
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

            if (contador == 2)
            {

                Console.WriteLine("El numero es primo...");
            }
            else
            {
                Console.WriteLine("El numero NO es primo...");
            }
            Console.ReadKey();
        }
    }
}
