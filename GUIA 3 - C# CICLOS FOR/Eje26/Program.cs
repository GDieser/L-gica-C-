using System;

namespace Eje26
{
    /*Hacer un programa que muestre los números primos entre el 1 y el 10000. El usuario no debe
    ingresar nada en este programa.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, contador = 0 ;

            for (x = 1; x <= 10000; x++)
            {

                for (y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine(x);
                }
                contador = 0;
            }
        }
    }
}
