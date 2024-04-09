using System;

namespace eje5
{
    /*Un comercio vende tres marcas de alfajores distintas A, B y C.
     * Hacer un programa para ingresar
    por teclado la cantidad de alfajores vendidos de cada una de las 
    tres marcas y luego se informe el
    porcentaje de ventas para cada una de ellas.

    Ejemplo. Si se ingresa 100, 25 y 75 como cantidades vendidas 
    entonces el programa calculará e
    informará A: 50%, B: 12,50% y C: 37,50%.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            float hav, gual, jorgi, porcHav, porcGual, porcJorgi, total;

            Console.WriteLine("Ingrese la cantidad vendida de alfajores Havana: ");
            hav = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad vendida de alfajores Havana: ");
            gual = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad vendida de alfajores Havana: ");
            jorgi = float.Parse(Console.ReadLine());

            total = hav + gual + jorgi;

            porcHav = (hav * 100) / total;
            porcGual = (gual * 100) / total;
            porcJorgi = (jorgi * 100) / total;

            Console.WriteLine("El porcenjate de ventas de Havana es: " + porcHav + "%");
            Console.WriteLine("El porcentaje de ventas de Gualmayen es: " + porcGual + "%");
            Console.WriteLine("El porcentaje de ventas de Jorgito es: " + porcJorgi + "%");
        }
    }
}
