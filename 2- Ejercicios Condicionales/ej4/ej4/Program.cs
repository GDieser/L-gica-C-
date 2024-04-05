using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números 
            //distintos y luego mostrar por pantalla el menor de ellos.

            float n1, n2, n3, n4, m;

            Console.WriteLine("Ingrese 1er numero: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 2do numero: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 3er numero: ");
            n3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 4to numero: ");
            n4 = float.Parse(Console.ReadLine());
            
            if(n1 < n2)
                m = n1;
            else
                m = n2;

            if(n3 < m)
                m = n3;
            
            if(n4 < m)
                m=n4;

            Console.WriteLine("El menor es: "+m);
        }
    }
}
