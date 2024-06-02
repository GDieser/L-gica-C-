using System;

namespace EJE02
{
    /*2 -
    Hacer un programa para ingresar una lista de 10 números y luego informar cuántos de los números ingresados son primos. 
    Se informa 1 resultado al final.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0, primo = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                for (int x = 1; x <= numero; x++)
                {
                    if (numero%x == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    primo++;
                }
                contador = 0;
            }

            Console.WriteLine("Se ingresaron: " + primo + " de números primos.");
            Console.ReadKey();
        }
    }
}
