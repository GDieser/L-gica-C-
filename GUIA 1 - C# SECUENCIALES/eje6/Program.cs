using System;

namespace eje6
{
    /*Hacer un programa para que un comercio ingrese por teclado la recaudación en pesos 
     para cada una de las cuatro semanas del mes. El programa debe listar la recaudación 
    promedio por semana y el porcentaje
    de recaudación por semana.
    Ejemplo. Si se ingresa $1600, $1200, $4800 y $400 se listará como recaudación promedio 
    $2000 y como porcentajes por semana: 20%, 15%, 60% y 5%.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int semana1, semana2, semana3, semana4, total;
            float porc1, porc2, porc3, porc4;

            Console.WriteLine("Ingrese lo facurado en la semana 1: ");
            semana1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lo facurado en la semana 2: ");
            semana2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lo facurado en la semana 3: ");
            semana3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lo facurado en la semana 4: ");
            semana4 = int.Parse(Console.ReadLine());

            total = semana1 + semana2 + semana3 + semana4;

            porc1 = (semana1 * 100) / total;
            porc2 = (semana2 * 100) / total;
            porc3 = (semana3 * 100) / total;
            porc4 = (semana4 * 100) / total;

            Console.WriteLine("El porcentaje de ventas de la semana 1 es: " + porc1 + "%");
            Console.WriteLine("El porcentaje de ventas de la semana 2 es: " + porc2 + "%");
            Console.WriteLine("El porcentaje de ventas de la semana 3 es: " + porc3 + "%");
            Console.WriteLine("El porcentaje de ventas de la semana 4 es: " + porc4 + "%");

            Console.ReadKey();
        }
    }
}
