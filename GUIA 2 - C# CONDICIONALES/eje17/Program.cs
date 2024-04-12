using System;

namespace eje17
{
    /*Hacer un programa para ingresar por teclado cuatro números. Si los valores que
    se ingresaran están ordenados en forma creciente, emitir el mensaje “Conjunto
    Ordenado”, caso contrario emitir el mensaje: “Conjunto Desordenado”.
    Ejemplo A: si los números que se ingresan son 8, 10, 12 y 14, entonces están
    ordenados.
    Ejemplo B: si los números que se ingresan son 8, 12, 12 y 14, entonces están
    ordenados.
    Ejemplo C: si los números que se ingresan son 10, 8, 12 y 14, entonces están
    desordenados.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Ingrese un primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer numero: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un cuarto numero: ");
            d = int.Parse(Console.ReadLine());

            if (a <= b && b <= c && c <= d)
            {
                Console.WriteLine("Los numeros ingresados son un Conjunto Ordenado!!!");
            }
            else
            {
                Console.WriteLine("Los numeros ingresados NO son un Conjunto Ordenado...");
            }

            Console.ReadKey();
        }
    }
}
