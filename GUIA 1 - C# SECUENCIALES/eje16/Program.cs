using System;

namespace eje16
{
    /* El Laboratorio V&V hace frascos de píldoras para aprender a programar.Cada 
     * frasco contiene 75 píldoras y cada píldora contiene 45 mg de Betamol, 2 grs de 
     * Micilina y 7 mg de Ácido Sinítico.
    Nos solicitan un programa donde se ingrese la cantidad de frascos de un pedido y 
    muestre la cantidad de miligramos de Betamol, Micilina y de Ácido Sinítico que son 
    necesarios para elaborarlos.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int frascos, betamol, micilina, acido, total;

            Console.WriteLine("Ingrese la cantidad de frascos de pildoras desea comprar: ");
            frascos = int.Parse(Console.ReadLine());

            total = frascos * 75;
            betamol = total * 45;
            micilina = total * 2;
            acido = total * 7;

            Console.WriteLine("Se necesitan: " + betamol + " mg de Betamol, " + micilina + " gr de Micilina y " + acido + " mg de acido Sinítico");
        }
    }
}
