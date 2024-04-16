using System;

namespace Eje14
{
    /*Dada una lista de 7 numeros informar cual es el primer, el segundo, el anteultimo y
    el ultimo numero impar ingresado.
    Ejemplo 8, 4, -5, 7, 9, 18, 5 se informa: Primer impar: -5, Segundo impar: 7, Anteultimo
    impar: 9 y ultimo impar: 5.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, contador = 0, primero = 0, segundo = 0 , ultimo = 0, anteultimo = 0 ;

            for (int x = 1; x < 8; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    contador++;
                    if (contador == 1)
                    {
                        primero = num;
                        ultimo = num;
                    }
                    else
                    {
                        if (contador == 2)
                        {
                            segundo = num;
                            anteultimo = ultimo;
                            ultimo = num;
                        }
                        else
                        {
                            if (contador == 3)
                            {
                                ultimo = num;
                                anteultimo = segundo;
                            }
                            else
                            {
                                if (contador >= 4)
                                {
                                    anteultimo = ultimo;
                                    ultimo = num;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Primer impar: " + primero + ", Segundo impar: " + segundo + ", Anteultimo: " + anteultimo + " y Ultimo: " + ultimo);

            Console.ReadKey();
        }
    }
}
