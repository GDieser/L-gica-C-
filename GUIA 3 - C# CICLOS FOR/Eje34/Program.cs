using System;

namespace Eje34
{
    /*
    Desafío

    Tu sobrina está aprendiendo las tablas de multiplicar y quisiera disponer de un programa para
    que pueda corroborar que las cuentas realizadas en su cuaderno sean correctas. Ella sabe que estás
    estudiando programación en la universidad y le parece que es algo que no debería llevarte más que unos pocos minutos.
    Puntualmente te pidió que puedas ingresar un número entre 1 y 15 y dibuje por pantalla las tablas de
    dicho número desde el 0 hasta el 10 inclusive.

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, mult;

            Console.WriteLine("Ingrese un numero para multiplicar (entre 1 y 15) ");
            num = int.Parse(Console.ReadLine());

            if (num > 1)
            {
                if (num <= 15)
                {
                    for (x = 1; x <= 10; x++)
                    {

                        mult = num * x;

                        Console.WriteLine(num + " x "+ x + " = " + mult);
                    }
                }
                else
                {
                    Console.WriteLine("Valor no valido");
                }
            }
            else
            {
                Console.WriteLine("Valor no valido");
            }
        }
    }
}
