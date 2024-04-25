﻿using System;

namespace Eje32
{
    internal class Program
    {
        /*Se ingresa una lista de 10 números y se pide determinar si la lista está formada por
    todos números alternados entre pares e impares o impares y pares.
    Ejemplo A: 8, 7, 10, -5, 20, 3, -10, 5, -10, -7 se lista el cartel “Alternados”.
    Ejemplo B: 5, 12, -5, 10, 13, 40, -11, 6, -7, -6 se lista el cartel “Alternados”.
    Ejemplo C: 5, 5, -5, 10, 10, 40, -11, 6, -7, -6 se lista el cartel “No Alternados”.

    */
        static void Main(string[] args)
        {
            int x, num, contP = 0, contI = 0;
            bool p = false, i = false;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    if (p == false)
                    {
                        contP++;
                        p = true;
                        i = false;
                    }
                    else
                    {
                        contP++;
                    }
                }
                else
                {
                    if (i == false)
                    {
                        contI++;
                        i = true;
                        p = false;
                    }
                    else
                    {
                        contI--;
                    }
                }
            }

            if (contP == contI)
            {
                Console.WriteLine("Los numeros estan alternados!");
            }
            else
            {
                Console.WriteLine("Los numeros NO estan alternados...");
            }
        }
    }
}
