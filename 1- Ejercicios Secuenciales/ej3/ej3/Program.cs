using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, resultado;
            
            Console.WriteLine("Indique los Km recorridos: ");
            
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Indique la velocidad promedio: ");

            n2 = float.Parse(Console.ReadLine());

            resultado = n1 / n2;

            Console.WriteLine("Usted tardara: " +resultado.ToString("0.00") + " horas");

        }
    }
}
