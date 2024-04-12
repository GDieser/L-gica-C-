using System;

namespace eje14
{
    /*Hacer un programa para ingresar el importe de una compra y el descuento a aplicar. 
    Listar por pantalla, el importe sin descuento, el descuento aplicado y el importe 
    total a cobrar.
    Ejemplo: se ingresa importe 4500, descuento 40; se deberá mostrar
    Importe: 4500, Descuento: 1800, total: 2700.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            float importe, descuento, porcentaje1, porcentaje2, total;

            Console.WriteLine("Ingrese importe total: ");
            importe = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese descuento: ");
            descuento = float.Parse(Console.ReadLine());

            porcentaje1 = (100 - descuento) / 100;
            total = importe * porcentaje1;
            porcentaje2 = importe - total;

            Console.WriteLine("Importe total: " + importe + "$ , descuento: " + porcentaje2 + "$, total a pagar: " + total + "$");

            Console.ReadKey();
        }
    }
}
