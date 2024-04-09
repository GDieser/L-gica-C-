using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3;

            float promedio;

            Console.WriteLine("Ingrese nota 1:");

            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota 2: ");

            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota 3: ");

            n3 = float.Parse(Console.ReadLine());

            promedio = (n1+n2+n3) / 3;

            Console.WriteLine("El promedio general es: "+promedio.ToString("0.0"));

        }
    }
}
