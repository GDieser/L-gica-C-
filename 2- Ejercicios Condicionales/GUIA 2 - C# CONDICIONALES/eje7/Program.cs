using System;

namespace eje7
{
    /*Hacer un programa para ingresar por teclado tres números e informar con una
    leyenda aclaratoria si los tres son todos distintos entre sí, caso contrario no
    emitir nada.
    Tener en cuenta: Si A es distinto de B y B es distinto de C, eso no significa que A
    y C sean distintos. Ejemplo: A=8, B=6 y C=8.
    */
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine("Ingrese un primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer numero: ");
            c = int.Parse(Console.ReadLine());

            if (a != b && a != c)
            {
                if( b != c )
                {
                    Console.WriteLine("Los numeros ingresados son todos distintos...");
                }
            }

            Console.ReadKey();
        }
    }
}
