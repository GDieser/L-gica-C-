using System;

namespace eje2
{
    /*Hacer un programa para ingresar por teclado dos números y luego informar por
    pantalla con un cartel aclaratorio si el primer número es múltiplo del segundo.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Ingrese primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero: ");
            b = int.Parse(Console.ReadLine());

            if( a%b == 0)
            {
                Console.WriteLine("El primer numero es multiplo por el segundo...");
            }
            else
            {
                Console.WriteLine("El primer numero NO es multiplo por el segundo...");
            }

            Console.ReadKey();
        }
    }
}
