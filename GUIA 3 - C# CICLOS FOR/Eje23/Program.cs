using System;

namespace Eje23
{
    /*Dada una lista de 10 números informar la cantidad de duplas de números impares que se
    hayan ingresado consecutivamente.
    Ejemplo A: 12, 3, 5, 7, 6, 9, 13, 10, 7, -5.

    En esta lista las duplas son: 3:5, 5:7, 9:13, 7:-5 por lo tanto se informará que hay 4
    duplas de números impares ingresados consecutivamente.

    Ejemplo B: 3, 5, 7, 10, 3, 5, 7, 10, 3, 5.
    En esta lista las duplas son: 3:5, 5:7, 3:5, 5:7, 3:5 por lo tanto se informará que hay 5
    duplas de números impares ingresados consecutivamente.

    Aclaración: Sólo hay que listar la cantidad de duplas de impares. No hay que mostrar cómo
    están compuestas las duplas de números.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, contador = 0, contDupla = 0;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    contador++;
                }
                else
                {
                    contador = 0;
                }

                if (contador == 2)
                {
                    contDupla++;
                    contador--;
                }
            }

            Console.WriteLine("Se ingresaron: " + contDupla + " duplas de numeros impares");

            Console.ReadKey();
        }
    }
}
