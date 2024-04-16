using System;

namespace Eje8
{
    /* Hacer un programa para ingresar una lista de 10 números, luego informar el porcentaje
    de positivos, negativos, y  ceros.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, contPositivo = 0, contNegativo = 0, contCero = 0, porcentajePositivo, porcentajeNegativo, porcentajeCero;

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

            porcentajePositivo = (contPositivo * 100) / 10;
            porcentajeNegativo = (contNegativo * 100) / 10;
            porcentajeCero = (contCero * 100) / 10;

            Console.WriteLine("Positivos: " + porcentajePositivo + "%, Negativos: " + porcentajeNegativo + "%, Cero: " + porcentajeCero + "%");
        }
    }
}
