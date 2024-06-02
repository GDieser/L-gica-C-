using System;

namespace EJE03
{
    /*3
    Hacer un programa para ingresar una lista de números que finaliza cuando se ingresa un cero y 
    luego informar el porcentaje de números primos y el porcentaje de números no primos. 
    Se informan 2 resultados al final.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0, primo = 0, porcentajePrimo, porcentajeNoPrimo, contadorTotales = 0;

            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                for (int x = 1; x <= numero; x ++)
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
                contadorTotales++;

                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
            }

            porcentajePrimo = (primo * 100) / contadorTotales;
            porcentajeNoPrimo = 100 - porcentajePrimo;

            Console.WriteLine();
            Console.WriteLine("El porcentaje de número primos es de: " + porcentajePrimo + "%");
            Console.WriteLine("El porcetaje de números no primos es de : " + porcentajeNoPrimo + "%");

            Console.ReadKey();
        }
    }
}
