using System;

namespace eje10
{
    /*Hacer un programa para ingresar cinco números y listar el máximo y el mínimo
    de ellos.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, mayor, menor;

            Console.WriteLine("Ingrese un primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer numero: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer numero: ");
            e = int.Parse(Console.ReadLine());

            if (a > b)
            {
                mayor = a;
                menor = b;
            }
            else
            {
                mayor = b;
                menor = a;
            }

            if (c > mayor)
            {
                mayor = c;
            }
            else
            {
                if (c < menor)
                {
                    menor = c;
                }
            }

            if (d > mayor)
            {
                mayor = d;
            }
            else
            {
                if (d < menor)
                {
                    menor = d;
                }
            }

            if (e > mayor)
            {
                mayor = e;
            }
            else
            {
                if (e < menor)
                {
                    menor = e;
                }
            }

            Console.WriteLine("El numero mayor es: " + mayor);

            Console.WriteLine("El numero menor es: " + menor);

            Console.ReadKey();
        }
    }
}
