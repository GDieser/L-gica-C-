using System;

namespace eje10
{
    /*Hacer un programa para ingresar por teclado una cantidad de horas y mostrar por 
    pantalla a cuantos días y horas equivalen.
    Ejemplo A: si se ingresan 26 horas el programa mostrará por pantalla que equivalen 
    a 1 día y 2 horas.
    Ejemplo B: si se ingresan 72 horas el programa mostrará por pantalla que equivalen 
    a 3 días y 0 horas.
    Ejemplo C: si se ingresan 20 horas el programa mostrará por pantalla que equivalen 
    a 0 días y 20 horas*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, resto, dias;

            Console.WriteLine("Ingrese la cantidad de horas: ");
            horas = int.Parse(Console.ReadLine());

            resto = horas % 24;
            dias = (horas - resto) / 24;

            Console.WriteLine("La cantidad es: " + dias + " dia/s con " + resto + " horas");

            Console.ReadKey();
        }
    }
}
