using System;

namespace Eje25
{
    /*Hacer un programa que permita ingresar el legajo y sueldo de 10 empleados y determine:
    El legajo del empleado con mayor sueldo
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, legajo, sueldo, mayor = 0, legajoMayor = 0;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese el legajo del empleado: ");
                legajo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese sueldo: ");
                sueldo = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    mayor = sueldo;
                    legajoMayor = legajo;
                }

                if (sueldo > mayor)
                {
                    mayor = sueldo;
                    legajoMayor = legajo;
                }
            }

            Console.WriteLine("El legajo con mayor sueldo es: " + legajoMayor);

            Console.ReadKey();
        }
    }
}
