using System;

namespace Eje3
{
    /*Hacer un programa para mostrar por pantalla los números del 20 al 1 en orden 
     * decreciente.
    Importante: El programa no tiene ningún ingreso de datos.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 20; x >= 1; x--)
            {
                Console.WriteLine("Numero: " + x);
            }
            Console.ReadKey();
        }
    }
}
