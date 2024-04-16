using System;

namespace Eje12
{
    /*Hacer un programa para ingresar una lista de 10 números e informar el máximo de
    los negativos y el mínimo de los positivos.
    Ejemplo: 5, 8, 12, 2, -10, 15, -20, 8, -3, 24. Máximo Negativo -3. Mínimo Positivo 2.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, mayor = 0, menor = 0;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());

                if (x == 0 && num > 0)
                {
                    menor = num;
                }
                else
                {
                    if (x == 0 && num < 0)
                    {
                        mayor = num;
                    }
                }

                if (num > 0)
                {
                    if (menor == 0)
                    {
                        menor = num;
                    }
                    else
                    {
                        if (num < menor)
                        {
                            menor = num;
                        }

                    }
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

            Console.WriteLine("Maximo Negativo: " + mayor + "| Minimo positivo: " + menor);

            Console.ReadKey();
        }
    }
}
