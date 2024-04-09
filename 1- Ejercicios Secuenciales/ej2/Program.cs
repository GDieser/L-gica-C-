using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resultado;
            
            Console.WriteLine("Indique un numero para elevar al cubo: ");

            n1 = int.Parse(Console.ReadLine());

            resultado = n1 * n1 * n1;

            Console.WriteLine("El resultado es: "+resultado);
        }
    }
}
