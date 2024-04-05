using System;

namespace ej111
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, total = 0, total1 = 0;

            n1 = float.Parse(Console.ReadLine());

            total = n1%12;
            total1 = (n1*0.42f) + (total * 0.08f);
        

            Console.WriteLine("Resultado: " + total1);
        }
    }
}
