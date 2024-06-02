using System;

namespace EJE01
{
    /*1
    Hacer un programa para ingresar una lista de 10 números y luego informar cuántos de los números ingresados son perfectos. 
    Se informa 1 resultado al final.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0, acumulador = 0, resultado, x, z;

            for ( z = 0; z < 10; z++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                for (x = 1; x < numero; x++)
                {
                    if (numero % x == 0)
                    {
                        acumulador += x;
                    }
                }

                if (acumulador == numero)
                {
                    contador++;
                }
                acumulador = 0;

            }

            Console.WriteLine("La cantidad de número perfectos ingresados son: " + contador);

            Console.ReadKey();
        }
    }
}
