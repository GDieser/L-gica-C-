using System;

namespace eje5
{
    /*Un negocio de perfumería efectúa descuentos según el importe de la venta.
    Si el importe es menor a $100 aplicar un descuento del 5%
    Si el importe es entre $100 y hasta $500 aplicar un descuento del 10%
    Si el importe es mayor a $500 aplicar un descuento del 15%
    Hacer un programa donde se ingresa el importe original sin descuento y se
    informe por pantalla el importe con el descuento ya aplicado.
    Importante: Verifique que el programa emita UN SOLO CARTEL*/
    internal class Program
    {
        static void Main(string[] args)
        {
            float importe, descuento;

            Console.WriteLine("Ingrese el importe de la venta: ");
            importe = float.Parse(Console.ReadLine());

            if (importe > 500)
            {
                descuento = importe * 0.85f;
                Console.WriteLine("El importe a abonar es: $" + descuento);
            }
            else if ( importe < 100)
            {
                descuento = importe * 0.95f;
                Console.WriteLine("El importe a abonar es: $" + descuento);
            }
            else
            {
                descuento = importe * 0.9f;
                Console.WriteLine("El importe a abonar es: $" + descuento);
            }
            Console.ReadKey();
        }
    }
}
