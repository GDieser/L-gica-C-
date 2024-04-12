using System;
using System.Diagnostics;

namespace eje11
{
    /*Hacer un programa para ingresar por teclado una cantidad de minutos y mostrar por 
     pantalla a cuántos días,horas y minutos equivalen.
    Ejemplo A: si se ingresan 1520 minutos el programa mostrará por pantalla que 
    equivalen a 1 día, 1 hora y 20 minutos.
    Ejemplo B: si se ingresan 480 minutos el programa mostrará por pantalla que 
    equivalen a 0 día, 8 horas y 0 minutos.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int minutos, resto, horas1, horas2, dias;

            Console.WriteLine("Ingrese la cantidad de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            resto = minutos % 60;
            horas1 = (minutos - resto) / 60;
            horas2 = horas1 % 24;
            dias = horas1 / 24;

            Console.WriteLine(minutos + " de minutos es equivalente a: " + dias + " dia/s, " + horas2 + " horas y " + resto + " minutos");

            Console.ReadKey();
        }
    }
}
