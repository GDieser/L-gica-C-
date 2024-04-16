using System;

namespace Eje4
{
    /*Hacer un programa para que el usuario ingrese un número positivo y luego se
    muestren por
    pantalla los números entre el 1 y el número ingresado por el usuario.
    Ejemplo. Si el usuario ingresa 15, se mostrarán los números entre el 1 y el 15.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, n;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            for (x = 1; x <= n; x++)
            {

                Console.WriteLine("Numero: " + x );
            }
            Console.ReadKey();
        }
    }
}
