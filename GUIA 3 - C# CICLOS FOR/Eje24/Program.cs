using System;

namespace Eje24
{
    /*Hacer un programa que permita ingresar el sueldo de 10 empleados y determine:
    El sueldo máximo.
    El sueldo mínimo.
    El sueldo promedio.
    Cantidad de sueldos mayores a $50000.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, sueldo, mayor = 0, menor = 0, contador1 = 0, contTotal = 0, acumulador = 0, promedio;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese el sueldo: ");
                sueldo = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    mayor = sueldo;
                    menor = sueldo;
                }

                if (sueldo > mayor)
                {
                    mayor = sueldo;
                }
                else
                {
                    if (sueldo < menor)
                    {
                        menor = sueldo;
                    }
                }

                if (sueldo > 50000)
                {
                    contador1++;
                }

                acumulador += sueldo;
                contTotal++;

            }

            promedio = acumulador / contTotal;

            Console.WriteLine("Sueldo Maximo: $" + mayor);
            Console.WriteLine("Sueldo menor: $" + menor);
            Console.WriteLine("Suedlo Promedio: $" + promedio);

            Console.ReadKey();
        }
    }
}
