using System;
using System.ComponentModel.Design;

namespace eje4
{
    /*Hacer un programa para ingresar por teclado dos números y luego informar por
    pantalla la diferencia absoluta entre ambos.
    Ejemplo A: Si se ingresan 3 y 8 se emite 5. Si se ingresan 8 y 3 se emite 5.
    Ejemplo B: Si se ingresan -3 y 9 se emite 12. Si se ingresan -12 y -1 se emite 11.
    Ejemplo C: Si se ingresan -3 y -9 se emite 6. Si se ingresan -12 y -9 se emite 3.
    Importante: Verifique que el programa emite SIEMPRE UN VALOR POSITIVO
    porque la diferencia absoluta siempre es un valor positivo*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, diferencia;

            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());

            if ( a > b)
            {
                diferencia = a - b;
                Console.WriteLine("La diferencia absolutas entre ambos numeros es: " + diferencia);
            }
            else
            {
                diferencia = b - a;
                Console.WriteLine("La diferencia absolutas entre ambos numeros es: " + diferencia);
            }

            Console.ReadKey();
        }
    }
}
