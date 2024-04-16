using System;

namespace Eje7
{
    /*Hacer un programa para ingresar una lista de 10 números, luego informar cuántos
    son positivos, cuántos son negativos, y cuántos iguales a cero.
    Para resolver este ejercicio sugerimos resolver antes el TP2 EJ 11.

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, contPositivo = 0, contNegativo = 0, contCero = 0;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    contPositivo++;
                }
                else
                {
                    if (num < 0)
                    {
                        contNegativo++;
                    }
                    else
                    {
                        contCero++;
                    }
                }
            }

            Console.WriteLine("Cantidad de Positivos: " + contPositivo);
            Console.WriteLine("Cantidad de Negativos: " +contNegativo);
            Console.WriteLine("Cantidad de Ceros: " + contCero);
        }
    }
}
