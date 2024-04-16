using System;

namespace Eje13
{
    /*Dada una lista de 10 números informar cual es el máximo de los pares.
    Ejemplo A: 2, 10, 20, 8, 25, 13, 36, - 8, -5, 20 se informa máximo: 36
    Ejemplo B 5, -13, 23, 81, -55, -13, 55, 4, 15 ,-20 Se informa máximo: 4
    Ejemplo C: -5, -13, -20, -8, -55, -13, -55, -14, -15, -20 se informa máximo: -8
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, mayor = 0;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese un numero: "); ;
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    if (x == 0)
                    {
                        mayor = num;
                    }
                    else
                    {
                        if (mayor == 0)
                        {
                            mayor = num;
                        }
                        else
                        {
                            if (num > mayor)
                            {
                                mayor = num;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("El maximo de los pares ingresados es: " + mayor);

            Console.ReadKey();
        }
    }
}
