using System;

namespace eje9
{
    /*Hacer un programa para ingresar tres números y listar el máximo de ellos.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, may;

            Console.WriteLine("Ingrese un primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer numero: ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                may = a;
            }
            else
            {
                may = b;
            }
            if (c > may)
            {
                may = c;
            }

            Console.WriteLine("El numero mayor ingresado es: " + may);

            Console.ReadKey();

        }
    }
}
