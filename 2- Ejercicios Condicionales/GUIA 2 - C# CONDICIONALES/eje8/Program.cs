using System;

namespace eje8
{
    /*Basado en los 2 ejercicios anteriores, hacer un programa para ingresar por
    teclado la longitud de los tres lados de un triángulo y luego listar qué tipo de
    triángulo es:
    - Equilátero: si los tres lados son iguales.
    - Isósceles: si dos de los tres lados son iguales.
    - Escaleno: si los tres lados son distintos entre sí.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Ingrese un primer lado del triangulo: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo lado del triangulo: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer lado del triangulo: ");
            c = int.Parse(Console.ReadLine());

            if (a == b)
            {
                if (b == c)
                {
                    Console.WriteLine("El triagulo es: EQUILATERO");
                }
                else
                {
                    Console.WriteLine("El triagulo es: ISOSELES");
                }
            }
            else
            {
                if(b ==c)
                {
                    Console.WriteLine("El triagulo es: ISOSELES");
                }
                else
                {
                    Console.WriteLine("El triagulo es: ESCALENO");
                }
            }

            Console.ReadKey();
        }
    }
}
