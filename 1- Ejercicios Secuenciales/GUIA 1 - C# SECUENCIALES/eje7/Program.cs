using System;

namespace eje7
{
    /*Hacer un programa para ingresar por teclado el importe de una venta y el porcentaje 
     de descuento aplicada a la misma y luego informar por pantalla el importe a pagar.
    Ejemplo A. Si el importe de la venta es $1200 y el descuento es el 15% entonces el 
    total a pagar será de $1020.
    Ejemplo B. Si el importe de la venta es $800 y el descuento es el 0% entonces el 
    total a pagar será de $800.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            float importe, descuento, porcentaje, importeTotal;

            Console.WriteLine("Ingrese el importe total");
            importe = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de descuento a realizar: ");
            descuento = float.Parse(Console.ReadLine());

            porcentaje = (100 - descuento) / 100;
            importeTotal = importe * porcentaje;

            Console.WriteLine("El total a abonar es: $" + importeTotal);

            Console.ReadKey();
        }
    }
}
