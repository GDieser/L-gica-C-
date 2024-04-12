using System;

namespace eje6
{
    /*Hacer un programa para ingresar por teclado tres números y luego determinar e
    informar con una leyenda aclaratoria si los tres son iguales entre sí, caso
    contrario no emitir nada.
    Tener en cuenta: Si A es igual a B y B es igual a C, entonces A y C son iguales*/
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

            if (a == b && a == c)
            {
                Console.WriteLine("Los numeros ingresados son iguales...");
            }
            else
            {
                Console.WriteLine("Los numeros ingresados NO son iguales...");
            }
            Console.ReadKey();
        }
    }
}
