using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, resultado;

            float n2 = 15000;

            float n3 = 0.05F;
            
            Console.WriteLine("Ingrese total facturado: ");

            n1 = float.Parse(Console.ReadLine());

            resultado = n3*n1 + n2;

            Console.WriteLine("Su sueldo total es: "+resultado);
        }
    }
}
